using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using System.IO;
using System.Text.RegularExpressions;

namespace EduSearch_Information_System
{
    class LuceneApplication
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

        public LuceneApplication(string collectionPath, string indexPath)
        {
            this.indexPath = indexPath;
            this.collectionPath = collectionPath;
            luceneIndexDirectory = null;
            analyzer = null;
            writer = null;
        }


        public void CreateIndex()
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(this.indexPath);
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            //IndexDeletionPolicy p;
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);

        }

        public List<string> createDocumentsList()
        {
            List<string> docs = new List<string>();
            DirectoryInfo d = new DirectoryInfo(this.collectionPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                string content = File.ReadAllText(file.FullName);
                docs.Add(content);

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
                Console.WriteLine("Rank " + rank + " text " + myFieldValue);

            }
        }




        static void Main(string[] args)
        {
//------------------------------------FETCHING COLLECTION AND POPULATING INDEX----------------------------------------------------------------
            string collectionPath  = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + @"\resources\crandocs";


            string indexPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + @"\index";

            LuceneApplication myLuceneApp = new LuceneApplication(collectionPath, indexPath);
           

            myLuceneApp.CreateIndex();

            System.Console.WriteLine("Adding Collection to Index");

            myLuceneApp.IndexCollection();


            System.Console.WriteLine("All documents added.\n");

            // clean up
            myLuceneApp.CleanUpIndexer();


//--------------------------------------------READING INFORMATION NEEDS---------------------------------------------------------------
            string infoNeedPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + @"\resources\cran_information_needs.txt";
            string infoNeed = FileRead.FileRead.ReadFile(infoNeedPath);

            //extract information needs into an array
            string pattern = @"(.D)\n([\w\W]+?).I ([0-9]{3})";
            Regex re1 = new Regex(pattern);
            Match match = Regex.Match(infoNeed, pattern);
            int i = 1;
            foreach (Group group in match.Groups)
            {
                Console.WriteLine("Group"+ i.ToString() + group.ToString()+"\n");
                i++;
            }
            Console.WriteLine(match.Groups);

            string lastMatchPattern = @"[\s\S]+\.D\n([\s\S]+)";
            Regex re2 = new Regex(lastMatchPattern);
            Match lastMatch = Regex.Match(infoNeed, lastMatchPattern);



            myLuceneApp.CreateSearcher();
            myLuceneApp.CreateParser();

            // Activity 6
            myLuceneApp.SearchIndex("\nworld");

            // Activity  7
            myLuceneApp.DisplayResults(myLuceneApp.SearchIndex("\nworld"));

            myLuceneApp.CleanUpSearch();
            System.Console.ReadLine();


        }
    }
}
