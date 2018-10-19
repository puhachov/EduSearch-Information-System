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
        private Lucene.Net.Analysis.Analyzer shingleAnalyzer;
        private Lucene.Net.Index.IndexWriter writer;
        private Lucene.Net.Search.IndexSearcher searcher;
        private Lucene.Net.QueryParsers.QueryParser parser;
        public string indexPath { get; set; }
        public string collectionPath { get; set; }

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const int MAX_SHINGLE_SIZE = 2;
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

        private Dictionary<string, string[]> cranquelIdeal = new Dictionary<string, string[]>();

        public LuceneApp()
        {
            luceneIndexDirectory = null;
            analyzer = null;
            writer = null;
            cranquelIdeal.Add("001", new string[] { "184", "29", "31", "12", "51", "102", "13", "14", "15", "57", "378", "859", "185", "30", "37", "52", "142", "195", "875", "56", "66", "95", "462", "497", "858", "876", "879", "880", "486" });
            cranquelIdeal.Add("002", new string[] { "12", "15", "184", "858", "51", "102", "202", "14", "52", "380", "746", "859", "948", "285", "390", "391", "442", "497", "643", "856", "857", "877", "864", "658", "486" });
            cranquelIdeal.Add("23", new string[] { "900", "902", "200", "201", "601", "899", "903", "593", "199", "594", "901", "544", "597", "749", "917", "919", "1333", "634", "687", "698", "1290", "700", "704", "705", "1109", "1112", "1141", "1197", "1256", "1259", "1272", "1289", "892" });
            cranquelIdeal.Add("157", new string[] { "273", "1105", "1106", "93", "161", "302", "122", "666", "1107", "556", "25", "1011", "19", "35", "1355", "372", "410", "456", "36", "44", "215", "626", "1151", "354", "369", "370", "421", "557", "605", "655", "657", "689", "1307", "318", "423", "1304", "160", "482", "572", "1006" });
            cranquelIdeal.Add("219", new string[] { "1391", "666", "667", "1258", "1078", "1080", "1081", "1394", "1395", "1214", "1198", "1204", "1300", "559", "630", "662", "1107", "1213", "1191" });
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
            TopDocs results = searcher.Search(query, 40);
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
}