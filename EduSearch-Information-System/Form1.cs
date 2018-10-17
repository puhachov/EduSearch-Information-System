using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Dictionary<string, Control>[] currentPageResults;
        Dictionary<string, string>[] searchResults;
        LuceneApp luceneApp;


        public Form1()
        {
            InitializeComponent();
            currentPage = 1;
            resultsPerPage = 10;
            luceneApp = new LuceneApp();
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
            watch.Stop();
            long elapsedS = watch.ElapsedMilliseconds / 1000;

            lblIndexInformation.Text = String.Format("Index of {0} documents created in {1} seconds",luceneApp.GetIndexSize(),elapsedS);

            groupBoxIndexSelection.Hide();
            tabControl1.Show();
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSimpleSearch.Text;

            labelTermSearch.Text = searchText;
            listView1.Clear();

            searchResults = getResults(new string[] { "search" });

            totalResults = searchResults.Length;
            totalPages = (totalResults / resultsPerPage)+1;

            Console.WriteLine("Writing {0} results over {1} page", totalResults, totalPages);

            changePage(1);
        }

        private void displayPage(int page) {
            page = page > 0 ? page - 1 : 0;
            int startingResult = page * resultsPerPage;
            int endingResult = limitToRange(page * resultsPerPage + resultsPerPage,searchResults.Length,0);
            int boxPosition = 0;

            Console.WriteLine("Displaying result {0}, {1} for page {2}", startingResult,endingResult,page+1);
            listView1.Controls.Clear();
            for (int i = startingResult; i < endingResult; i++)
            {
                GroupBox result = new GroupBox();

                Label title = new Label();
                title.Text = searchResults[i]["title"];
                title.Location = new Point(0, 0);
                title.Size = new Size(150, 30);

                Label author = new Label();
                author.Text = searchResults[i]["author"];
                author.Location = new Point(150, 0);
                author.Size = new Size(150, 30);

                Label bibliographicInfo = new Label();
                bibliographicInfo.Text = searchResults[i]["bibliographicInfo"];
                bibliographicInfo.Location = new Point(300, 0);
                bibliographicInfo.Size = new Size(150, 30);

                Label textAbstract = new Label();
                textAbstract.Text = searchResults[i]["abstract"];
                textAbstract.Location = new Point(0, 50);
                textAbstract.Size = new Size(400, 30);

                result.Controls.Add(title);
                result.Controls.Add(author);
                result.Controls.Add(bibliographicInfo);
                result.Controls.Add(textAbstract);

                listView1.Controls.Add(result);
                result.Size = new Size(450, 80);
                result.Location = new Point(0, boxPosition * 80);
                boxPosition++;

            }
        }

        public Dictionary<string,string>[] getResults(string[] search) {
            int returnSize = 26;
            Dictionary<string,string>[] results = new Dictionary<string, string>[returnSize];
            
            for(int i = 0; i < returnSize; i++) {
                results[i] = new Dictionary<string, string>();
                results[i].Add("title","Title-"+(i+1));
                results[i].Add("author", "Author-"+(i+1));
                results[i].Add("bibliographicInfo", "bibinfo-" + (i+1));
                results[i].Add("abstract", "Abstract-" + (i+1));
            }
            return results;
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
    }
}
