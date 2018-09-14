using System;
using System.Collections.Generic;
using System.IO;
using static EduSearch_Information_System.LuceneApp;
using Lucene.Net.Search; // for IndexSearcher
using System.Text.RegularExpressions;
using static FileReadProcess;



/*---------------------------------------------------------
.NET regex online tester
http://regexstorm.net/tester
     
     
     


*///-----------------------------------------------------

namespace EduSearch_Information_System
{
   
    class InformationRetrievalSystem
    {
        static void Main(string[] args)
        {
            // initialization

            //to store information needs
            List<string> infoNeed = new List<string>();
            string infoNeedPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + @"\resources\cran_information_needs.txt";


            //------------------------------------FETCHING COLLECTION AND POPULATING INDEX----------------------------------------------------------------
            string collectionPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + @"\resources\crandocs";
            string indexPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + @"\index";

            LuceneApp myLuceneApp = new LuceneApp(collectionPath, indexPath);
            myLuceneApp.CreateIndex();

            System.Console.WriteLine("Adding Collection to Index\n");
            myLuceneApp.IndexCollection();
            System.Console.WriteLine("All documents added.\n");
            myLuceneApp.CleanUpIndexer();


            //--------------------------------------------READING INFORMATION NEEDS---------------------------------------------------------------
           
            string infoNeedText = FileReadProcess.ReadFile(infoNeedPath);
            infoNeed = FileReadProcess.getInformationNeeds(infoNeedText);
            Console.WriteLine("Printing Information needs:\n-------------------------------------------------------------------");
            printList(infoNeed);

            //--------------------------------------------SEARCHING INDEX------------------------------------
            myLuceneApp.CreateSearcher();
            myLuceneApp.CreateParser();


            TopDocs topdocs = myLuceneApp.SearchIndex(infoNeed[0]);

            myLuceneApp.DisplayResults(topdocs);


            myLuceneApp.CleanUpSearch();
            System.Console.ReadLine();


        }
    }

        
    
}
