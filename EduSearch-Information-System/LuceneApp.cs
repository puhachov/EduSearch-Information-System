using System;
using System.Collections.Generic;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using System.IO; //to work with directories
using static FileReadProcess; //to read and process files


namespace EduSearch_Information_System
{
    class LuceneApp
    {
        private Lucene.Net.Store.Directory luceneIndexDirectory;
        private Lucene.Net.Analysis.Analyzer analyzer;
        private Lucene.Net.Index.IndexWriter writer;
        private Lucene.Net.Search.IndexSearcher searcher;
        private Lucene.Net.QueryParsers.QueryParser parser;
        public string indexPath { get; set; }
        public string collectionPath { get; set; }

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";
        private readonly string[] STOP_WORDS = new string[]{ "a", "about", "above", "after", "again", "against", "all", "am", "an", "and", "any", "are",
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

        public LuceneApp()
        {
            luceneIndexDirectory = null;
            analyzer = null;
            writer = null;
        }

        public int GetIndexSize() {            
            return writer.MaxDoc();
        }

        public void CreateIndex(string collectionPath, string indexPath)
        {
            HashSet<string> stopWordsSet = new HashSet<string>(STOP_WORDS);
            this.indexPath = indexPath;
            this.collectionPath = collectionPath;
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(this.indexPath);                        
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION,stopWordsSet);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);

            IndexCollection();

        }

        private List<string> createDocumentsList()
        {
            List<string> docs = new List<string>();
            DirectoryInfo d = new DirectoryInfo(this.collectionPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            

            foreach (FileInfo file in Files)
            {
                string content = File.ReadAllText(file.FullName);
                docs.Add(FileReadProcess.getAbstract(content));
            }
            return docs;
        }

        public void IndexCollection()
        {
            List<string> docs = createDocumentsList();
            foreach (string text in docs)
            {

                TextReader reader = new StringReader(text);
                Lucene.Net.Analysis.NGram.NGramTokenizer tokeniser = new Lucene.Net.Analysis.NGram.NGramTokenizer(reader, 2, 2);

                //TODO: use tokeniser to create index

                Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
                Lucene.Net.Documents.Document doc = new Document();
                doc.Add(field);
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
        }

        public void CreateParser()
        {
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
        }


        public void CleanUpSearch()
        {
            searcher.Dispose();
        }


        public TopDocs SearchIndex(string querytext)
        {
            System.Console.WriteLine("Searching for " + querytext);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 100);
            Console.WriteLine("================================================================================================");
            System.Console.WriteLine("Number of results is " + results.TotalHits);
            return results;

        }


        public void DisplayResults(TopDocs results)
        {
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                // retrieve the document from the 'ScoreDoc' object
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                //Console.WriteLine("Rank " + rank + " score " + scoreDoc.Score + " text " + myFieldValue);
                Console.WriteLine("Rank " + rank + " text:\n------------------------------------------------------------------ " + myFieldValue);

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
}