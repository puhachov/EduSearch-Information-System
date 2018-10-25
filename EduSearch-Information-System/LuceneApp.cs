using System;
using System.Collections.Generic;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using System.IO; //to work with directories
using Syn.WordNet;
using System.Text.RegularExpressions;
using static FileReadProcess; //to read and process files


namespace EduSearch_Information_System
{
    class LuceneApp
    {
        private Lucene.Net.Store.Directory luceneIndexDirectory;
        private Lucene.Net.Analysis.Analyzer analyzer;
        private Lucene.Net.Analysis.Analyzer shingleAnalyzer;
        private Lucene.Net.Index.IndexWriter writer;
        private Lucene.Net.Search.IndexSearcher searcher;
        private Lucene.Net.QueryParsers.QueryParser parser;
        private Similarity newSimilarity;
        public string indexPath { get; set; }
        public string collectionPath { get; set; }

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const int MAX_SHINGLE_SIZE = 2;
        const string DOC_TITLE = "Title";
        const string DOC_AUTHOR = "Author";
        const string DOC_BIB = "Bibliography";
        const string DOC_BODY = "Body";
        const string DOC_ID = "ID";
        const string DOC_RANK = "Rank";

        public string[] parserFields;
        public Dictionary<string,float> fieldWeights;

        WordNetEngine wordNetEngine;

        private string[] STOP_WORDS = new string[]{ "a", "about", "above", "after", "again", "against", "all", "am", "an", "and", "any", "are",
            "aren't", "as", "at", "be", "because", "been", "before", "being", "below", "between", "both", "but", "by", "can't",
            "cannot", "could", "couldn't", "did", "didn't", "do", "does", "doesn't", "doing", "don't", "down", "during", "each", "few",
            "for", "from", "further", "had", "hadn't", "has", "hasn't", "have", "haven't", "having", "he", "he'd", "he'll", "he's", "her",
            "here", "here's", "hers", "herself", "him", "himself", "his", "how", "how's", "i", "i'd", "i'll", "i'm", "i've", "if", "in",
            "into", "is", "isn't", "it", "it's", "its", "itself", "let's", "me", "more", "most", "mustn't", "my", "myself", "no", "nor",
            "not", "of", "off", "on", "once", "only", "or", "other", "ought", "our", "ours	ourselves", "out", "over", "own", "same",
            "shan't", "she", "she'd", "she'll", "she's", "should", "shouldn't", "so", "some", "such", "than", "that", "that's", "the",
            "their", "theirs", "them", "themselves", "then", "there", "there's", "these", "they", "they'd", "they'll", "they're", "they've",
            "this", "those", "through", "to", "too", "under", "until", "up", "very", "was", "wasn't", "we", "we'd", "we'll", "we're",
            "we've", "were", "weren't", "what", "what's", "when", "when's", "where", "where's", "which", "while", "who", "who's", "whom",
            "why", "why's", "with", "won't", "would", "wouldn't", "you", "you'd", "you'll", "you're", "you've", "your", "yours", "yourself", "yourselves" };

        private Dictionary<string, string[]> cranquelIdeal = new Dictionary<string, string[]>();

        public LuceneApp()
        {
            luceneIndexDirectory = null;
            analyzer = null;
            writer = null;
            newSimilarity = new NewSimilarity();
            parserFields = new string[] { DOC_TITLE, DOC_AUTHOR, DOC_BIB, DOC_BODY };
            fieldWeights = new Dictionary<string, float>();
            foreach(string field in parserFields) {
                fieldWeights.Add(field, 1);
            }            

            // Init WordNet
            // Src: https://developer.syn.co.in/tutorial/wordnet/tutorial.html
            var directory = "../../../wordnetdic";

            wordNetEngine = new WordNetEngine();

            // data sources
            wordNetEngine.AddDataSource(new StreamReader(Path.Combine(directory, "data.adj")), PartOfSpeech.Adjective);
            wordNetEngine.AddDataSource(new StreamReader(Path.Combine(directory, "data.adv")), PartOfSpeech.Adverb);
            wordNetEngine.AddDataSource(new StreamReader(Path.Combine(directory, "data.noun")), PartOfSpeech.Noun);
            wordNetEngine.AddDataSource(new StreamReader(Path.Combine(directory, "data.verb")), PartOfSpeech.Verb);

            // indexes
            wordNetEngine.AddIndexSource(new StreamReader(Path.Combine(directory, "index.adj")), PartOfSpeech.Adjective);
            wordNetEngine.AddIndexSource(new StreamReader(Path.Combine(directory, "index.adv")), PartOfSpeech.Adverb);
            wordNetEngine.AddIndexSource(new StreamReader(Path.Combine(directory, "index.noun")), PartOfSpeech.Noun);
            wordNetEngine.AddIndexSource(new StreamReader(Path.Combine(directory, "index.verb")), PartOfSpeech.Verb);

            Console.WriteLine("Loading database...");
            wordNetEngine.Load();
            Console.WriteLine("Load completed.");
        }

        public int GetIndexSize() {            
            return writer.MaxDoc();
        }

        public void CreateIndex(string collectionPath, string indexPath){
            HashSet<string> stopWordsSet = new HashSet<string>(STOP_WORDS);
            this.indexPath = indexPath;
            this.collectionPath = collectionPath;

            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(this.indexPath);

            analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(VERSION, "English", stopWordsSet);
            shingleAnalyzer = new Lucene.Net.Analysis.Shingle.ShingleAnalyzerWrapper(analyzer, MAX_SHINGLE_SIZE);

            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, shingleAnalyzer, true, mfl);
            writer.SetSimilarity(newSimilarity);

            IndexCollection();

        }

        private List<Dictionary<string,string>> createDocumentsList()
        {
            List<Dictionary<string,string>> docs = new List<Dictionary<string, string>>();
            DirectoryInfo d = new DirectoryInfo(this.collectionPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            

            foreach (FileInfo file in Files)
            {
                string content = File.ReadAllText(file.FullName);
                docs.Add(FileReadProcess.getDocumentParts(content));
            }
            return docs;
        }

        public void IndexCollection()
        {
            List<Dictionary<string,string>> docs = createDocumentsList();
            foreach (Dictionary<string,string> entry in docs)
            {
                Lucene.Net.Documents.Document doc = new Document();
                foreach (KeyValuePair<string, string> section in entry)
                {
                    Lucene.Net.Documents.Field field = new Field(section.Key, section.Value, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);                    
                    doc.Add(field);
                }
                writer.AddDocument(doc);
            }
            CleanUpIndexer();
        }

        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }



        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
            searcher.Similarity = newSimilarity;
        }

        public void CreateParser()
        {
            parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, parserFields, shingleAnalyzer, fieldWeights);
        }


        public void CleanUpSearch()
        {
            searcher.Dispose();
        }

        public List<String> SimpleTokenizeQuery(String query)
        {
            List<String> tokens = new List<String>();
            Lucene.Net.Analysis.Analyzer simpleAnalyzer = new SimpleAnalyzer();
            TokenStream tokenStream = simpleAnalyzer.TokenStream(null, new StringReader(query));
            tokenStream.Reset();
            do
            {
                tokens.Add(tokenStream.GetAttribute<Lucene.Net.Analysis.Tokenattributes.ITermAttribute>().Term);
            }
            while (tokenStream.IncrementToken());

            return tokens;
        }

        public String QueryExpansion(IEnumerable<String> tokens, Boolean checkForNoun, Boolean checkForAdj, Boolean checkForVerb, Boolean checkForAdverb)
        {
            String expansion = "";


            foreach (String token in tokens)
            {
                bool isToken = false;
                foreach (string sw in STOP_WORDS)
                {
                    if (sw.Contains(token))
                    {
                        isToken = true;
                    }
                }
                if (token == "" || token == " " || isToken == true)
                {
                    System.Console.WriteLine("Token: {0} : {0}", token, isToken);
                    continue;
                }
                System.Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~ Getting synonyms from WordNet\n");
                System.Console.WriteLine("Synonyms for token =  " + token + "\n");

                expansion += token + "^5 ";

                // For each token, add synonym
                // src: https://developer.syn.co.in/api/Syn.WordNet.WordNetEngine.html
                SynSet synSet_noun = wordNetEngine.GetMostCommonSynSet(token, PartOfSpeech.Noun);
                SynSet synSet_adjective = wordNetEngine.GetMostCommonSynSet(token, PartOfSpeech.Adjective);
                SynSet synSet_verb = wordNetEngine.GetMostCommonSynSet(token, PartOfSpeech.Verb);
                SynSet synSet_adverb = wordNetEngine.GetMostCommonSynSet(token, PartOfSpeech.Adverb);


                System.Console.WriteLine("~~~~~~~ Nouns\n");

                if (checkForNoun)
                {
                    try
                    {
                        foreach (var noun_syn in synSet_noun.Words)
                        {
                            if (!expansion.Contains(noun_syn))
                            {
                                expansion += noun_syn + "^1 ";
                                System.Console.WriteLine(noun_syn);
                            }
                        }
                    }
                    catch (NullReferenceException e)
                    {

                        // Noun does not contain synonym
                    }
                }

                System.Console.WriteLine("~~~~~~~ Adjectives\n");

                if (checkForAdj)
                {
                    try
                    {
                        foreach (var adj_syn in synSet_adjective.Words)
                        {
                            if (!expansion.Contains(adj_syn))
                            {
                                expansion += adj_syn + "^1 ";
                                System.Console.WriteLine(adj_syn);
                            }
                        }
                    }
                    catch (NullReferenceException e)
                    {

                        // Noun does not contain adjectives
                    }
                }

                System.Console.WriteLine("~~~~~~~ Verbs\n");

                if (checkForVerb)
                {
                    try
                    {
                        foreach (var adj_verb in synSet_verb.Words)
                        {
                            if (!expansion.Contains(adj_verb))
                            {
                                expansion += adj_verb + "^1 ";
                                System.Console.WriteLine(adj_verb);
                            }
                        }
                    }
                    catch (NullReferenceException e)
                    {

                        // Noun does not contain adjectives
                    }
                }

                System.Console.WriteLine("~~~~~~~ Adverbs\n");

                if (checkForAdverb)
                {
                    try
                    {
                        foreach (var adj_adverb in synSet_adverb.Words)
                        {
                            if (!expansion.Contains(adj_adverb))
                            {
                                expansion += adj_adverb + "^1 ";
                                System.Console.WriteLine(adj_adverb);
                            }
                        }
                    }
                    catch (NullReferenceException e)
                    {

                        // Noun does not contain adjectives
                    }
                }

                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");

            }

            return expansion;
        }     

        public Query CreateFullPhrase(string searchText)
        {
            Query parsedSearch;
            try
            {
                string output = "\"";
                output += searchText.Replace("\"", "").ToLower();
                output += "\"";                
                parsedSearch = parser.Parse(output);

            }
            catch
            {
                parsedSearch = null;
            }
            return parsedSearch;
        }

        public List<String> getPhrasesInString(String query)
        {
            List<String> phrases = new List<string>();

            // Use regex to fetch phrases (everything between " ")
            MatchCollection mc = Regex.Matches(query, @"""([^""]|"""")*""");
            foreach (Match m in mc)
            {
                String phrase = m.ToString();
                System.Console.WriteLine("Phrase: " + phrase);
                phrases.Add(phrase);
            }

            return phrases;
        }


        // ================================================================================================================================================================
        // ================================================================================================================================================================

        public Query ParseSearchText(string query)
        {
            Query parsedSearch;
            try
            {
                query = query.ToLower();
                parsedSearch = parser.Parse(query);

            }
            catch
            {
                parsedSearch = null;
            }

            return parsedSearch;
        }

        public List<Dictionary<string,string>> SearchIndex(Query query, Dictionary<string,float> weights){

            //parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, parserFields, shingleAnalyzer, weights);
            TopDocs results = null;
            //System.Console.WriteLine("Searching for " + query.ToString());
            try
            {
                results = searcher.Search(query,200);
            }
            catch (Exception e)
            {
                // invalid string
            }
            List<Dictionary<string, string>> fullResults = new List<Dictionary<string, string>>();

            int docIndex = 0;

            foreach (ScoreDoc doc in results.ScoreDocs)
            {
                Document fullDoc = searcher.Doc(doc.Doc);
                Dictionary<string, string> fields = new Dictionary<string, string>();
                foreach (Field f in fullDoc.GetFields())
                {
                    fields[f.Name] = f.StringValue;
                }
                fields[DOC_RANK] = doc.Score.ToString().Replace("\n","");
                if(fields.Keys.Count > 0)
                {
                    fullResults.Add(fields);
                }                
                docIndex++;
            }

            Console.WriteLine("================================================================================================");
            System.Console.WriteLine("Number of results is " + results.TotalHits);

            DisplayResults(results);

            return fullResults;

        }


        public void DisplayResults(TopDocs results)
        {
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                // retrieve the document from the 'ScoreDoc' object
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(DOC_BODY).ToString();
                //Console.WriteLine("Rank " + rank + " score " + scoreDoc.Score + " text " + myFieldValue);
                foreach (KeyValuePair<string, string[]> resultList in cranquelIdeal) {
                    if (Array.Exists(cranquelIdeal[resultList.Key], element => element == scoreDoc.Doc.ToString())) {
                        Console.WriteLine(scoreDoc.Doc + " found in results list "+ resultList.Key);
                    }
                }
                
                

            }
        }

        public static void printList(List<string> L)
        {
            foreach (string item in L)
            {
                Console.WriteLine(item + "\n------------------------------------------------------------------------------------------------");
            }
        }

    }

    /*
     * 
     * 
        SINGLE
        System.Console.WriteLine("\n\n ~~~~~~~~~~~~~~~~~~~~~~~~ \n method: ParseSearchText\n variable: queryText\n " + queryText + "\n ~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");

        LOOP
        System.Console.WriteLine("\n\n ~~~~~~~~~~~~~~~~~~~~~~~~ \n method: ParseSearchText --> foreach\n");
        foreach (var item in collection)
	    {
            System.Console.WriteLine(" variable: item\n " + item + "\n");
	    }
        System.Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");

     * 
     */

}
 