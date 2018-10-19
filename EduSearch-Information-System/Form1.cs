using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser

namespace EduSearch_Information_System
{
    public partial class Form1 : Form
    {

        int currentPage;
        int resultsPerPage;
        int totalResults;
        int totalPages;
        private bool indexLocationSelected = false;
        private bool collectionLocationSelected = false;
        List<Dictionary<string, string>> searchResults;
        LuceneApp luceneApp;

        const string DOC_TITLE = "Title";
        const string DOC_AUTHOR = "Author";
        const string DOC_BIB = "Bibliography";
        const string DOC_BODY = "Body";
        const string DOC_ID = "ID";

        public Form1()
        {
            InitializeComponent();
            currentPage = 1;
            resultsPerPage = 10;
            luceneApp = new LuceneApp();
        }


        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        private void btnIndexAccept_Click(object sender, EventArgs e)
        {
            if (indexLocationSelected && collectionLocationSelected)
            {
                createIndex(lblCollectionLocation.Text, lblIndexLocation.Text);
            }
            else
            {
                lblIndexFeedback.Text = "Please select index and collection locations before attempting to create the index";
            }
        }

        private void createIndex(string collectionLoc, string indexLoc) {
            lblIndexFeedback.Text = "Creating index";
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            luceneApp.CreateIndex(collectionLoc, indexLoc);
            luceneApp.CreateSearcher();
            luceneApp.CreateParser();
            watch.Stop();
            float elapsedS = watch.ElapsedMilliseconds / (float)1000.00;

            lblIndexInformation.Text = String.Format("Index of {0} documents created in {1} seconds",luceneApp.GetIndexSize(),elapsedS);

            groupBoxIndexSelection.Hide();
            tabControl1.Show();
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {            

            string searchText = txtSimpleSearch.Text;
            Query parsedSearch;
            try
            {
                parsedSearch = luceneApp.ParseSearchText(searchText);
                labelTermSearch.Text = parsedSearch.ToString().Remove(0, 4);
                searchResults = luceneApp.SearchIndex(parsedSearch);

                listView1.Clear();

                totalResults = searchResults.Count;
                totalPages = (totalResults / resultsPerPage) + 1;

                Console.WriteLine("Writing {0} results over {1} page", totalResults, totalPages);

                changePage(1);
            }
            catch
            {
                labelTermSearch.Text = "Please enter search text to get results, dingus.";
            }            
            
        }

        private void displayPage(int page) {
            page = page > 0 ? page - 1 : 0;
            int startingResult = page * resultsPerPage;
            int endingResult = limitToRange(page * resultsPerPage + resultsPerPage,searchResults.Count,0);
            int boxPosition = 0;

            int groupBoxHeight = 80;
            int groupBoxWidth = 700;

            int titleHeight = 30;
            int titleWidth = 250;
            int titleX = 7;
            int titleY = 12;

            int infoHeight = 30;
            int infoWidth = 250;
            int infoX = 7;
            int infoY = 40;

            int abstractHeight = 80;
            int abstractWidth = 400;
            int abstractX = 280;
            int abstractY = 0;

            int openX = 617;
            int openY = 57;

            Console.WriteLine("Displaying result {0}, {1} for page {2}", startingResult,endingResult,page+1);

            listView1.Controls.Clear();

            for (int i = startingResult; i < endingResult; i++)
            {
                GroupBox result = new GroupBox();

                Label title = new Label();
                title.Text = searchResults[i][DOC_TITLE];
                title.AutoSize = false;
                title.Location = new Point(titleX, titleY);
                title.MaximumSize = new Size(titleWidth, titleHeight);
                title.BackColor = Color.Transparent;

                Label info = new Label();
                info.Text = searchResults[i][DOC_AUTHOR] + "  -  " + searchResults[i][DOC_BIB];
                info.AutoSize = false;
                info.Location = new Point(infoX, infoY);
                info.Size = new Size(infoWidth, infoHeight);
                info.BackColor = Color.Transparent;

                Label textAbstract = new Label();
                textAbstract.Text = Truncate(searchResults[i][DOC_BODY],250);
                textAbstract.AutoSize = false;
                textAbstract.Location = new Point(abstractX, abstractY);
                textAbstract.Size = new Size(abstractWidth, abstractHeight);
                textAbstract.BackColor = Color.Transparent;

                Button openResult = new Button();
                openResult.Text = "Open";
                openResult.Location = new Point(openX,openY);
                openResult.BringToFront();

                result.Controls.Add(title);
                result.Controls.Add(info);                
                result.Controls.Add(textAbstract);
                result.Controls.Add(openResult);

                //TODO Assign full result window

                listView1.Controls.Add(result);
                result.Size = new Size(groupBoxWidth, groupBoxHeight);
                result.Location = new Point(0, boxPosition * groupBoxHeight);
                boxPosition++;

            }
        }

        private void btnPaginationNext_Click(object sender, EventArgs e)
        {            
            int newPage = limitToRange(currentPage + 1,totalPages,1);
            if (newPage != currentPage)
            {
                changePage(newPage);
            }
        }

        private void btnPaginationPrv_Click(object sender, EventArgs e)
        {
            int newPage = limitToRange(currentPage - 1, totalPages, 1);
            if (newPage != currentPage)
            {
                changePage(newPage);
            }
        }

        private void changePage(int newPage) {
            Console.WriteLine("changing to page {0}", newPage);           
            changePagination(newPage);
            displayPage(newPage);
            currentPage = newPage;
        }

        private int limitToRange(int value, int max, int min) {
            if( value > max ) { return max; };
            if (value < min ) { return min; };
            return value;
        }

        private void changePagination(int newPage) {
            Console.WriteLine("Changing pagination to page {0} of {1} total pages", newPage,totalPages);
            if (newPage < 2) {
                btnPaginationPrv.Hide();
            }
            if (newPage < totalPages) {
                btnPaginationNext.Show();                
            }
            if (newPage >= totalPages) {
                btnPaginationNext.Hide();
            }
            if (newPage > 1) {
                btnPaginationPrv.Show();
            }
            newPage = newPage > 0 ? newPage - 1 : 0;
            lblPaginationDisplay.Text = String.Format("Results {0} .. {1} of {2}",((newPage * resultsPerPage)+1),limitToRange(newPage * resultsPerPage + resultsPerPage,totalResults,1),totalResults);
            lblPaginationDisplay.Show();
        }

        private void btnCollectionLoc_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblCollectionLocation.Text = folderBrowserDialog1.SelectedPath;
            collectionLocationSelected = true;
        }

        private void btnIndexLoc_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblIndexLocation.Text = folderBrowserDialog1.SelectedPath;
            indexLocationSelected = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
