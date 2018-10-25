using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
        int currentSearch;

        const string DOC_TITLE = "Title";
        const string DOC_AUTHOR = "Author";
        const string DOC_BIB = "Bibliography";
        const string DOC_BODY = "Body";
        const string DOC_ID = "ID";
        const string DOC_RANK = "Rank";

        public Form1()
        {
            InitializeComponent();
            currentPage = 1;
            resultsPerPage = 10;
            currentSearch = 0;
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

        private void createIndex(string collectionLoc, string indexLoc)
        {
            lblIndexFeedback.Text = "Creating index";
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            luceneApp.CreateIndex(collectionLoc, indexLoc);
            luceneApp.CreateSearcher();
            luceneApp.CreateParser();
            watch.Stop();
            float elapsedS = watch.ElapsedMilliseconds / (float)1000.00;

            lblIndexInformation.Text = String.Format("Index of {0} documents created in {1} seconds", luceneApp.GetIndexSize(), elapsedS);

            groupBoxIndexSelection.Hide();
            tabControl1.Show();
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            // Start stopwatch
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

            // Get user input
            string searchText = txtSimpleSearch.Text.ToLower().Replace("\n", " ");
            
            // If user input field is not empty
            if (searchText.Length > 0)
            {
                List<String> phraseList = null;
                BooleanQuery booleanQuery = new BooleanQuery();
                Query parsedSearch = luceneApp.ParseSearchText(searchText);

                // Define weights for the fields
                Dictionary<string, float> weights = new Dictionary<string, float>();

                weights.Add(DOC_AUTHOR, (float)numAuthorWeight.Value);
                weights.Add(DOC_TITLE, (float)numTitleWeight.Value);
                weights.Add(DOC_BIB, (float)numBibWeight.Value);
                weights.Add(DOC_BODY, (float)numBodyWeight.Value);

                // If single/multi phrase search
                if (fullPhrase.Checked)
                {                  
                    parsedSearch = luceneApp.CreateFullPhrase(searchText);
                    searchResults = luceneApp.SearchIndex(parsedSearch, weights);
                }
                // If single/multi term search
                else
                {
                    // If query expansion
                    if (queryExpansionCB.Checked)
                    {
                        List<String> stringList = luceneApp.SimpleTokenizeQuery(searchText);
                        searchText = luceneApp.QueryExpansion(stringList, checkForNoun.Checked, checkForAdj.Checked, checkForVerb.Checked, checkForAdverb.Checked);
                        //booleanQuery = luceneApp.BooleanQueryExpansion(stringList.ToList(), checkForNoun.Checked, checkForAdj.Checked, checkForVerb.Checked, checkForAdverb.Checked);
                        System.Console.WriteLine("searchText after QE" + searchText);
                        // Search
                        //searchResults = luceneApp.SearchIndex(booleanQuery, weights);
                        parsedSearch = luceneApp.ParseSearchText(searchText);
                        System.Console.WriteLine("parsedSearch after ParseSearchText" + parsedSearch);
                        searchResults = luceneApp.SearchIndex(parsedSearch, weights);
                    }
                    else {
                        parsedSearch = luceneApp.ParseSearchText(searchText);
                        searchResults = luceneApp.SearchIndex(parsedSearch, weights);
                    }
                }

                totalResults = searchResults.Count;
                totalPages = (totalResults / resultsPerPage) + 1;

                Console.WriteLine("Writing {0} results over {1} page", totalResults, totalPages);

                watch.Stop();
                float elapsedS = watch.ElapsedMilliseconds / (float)1000.00;
                searchInfo.Text = String.Format("{0} results returned in {1} seconds for a search of: {2}", totalResults, elapsedS, parsedSearch.ToString());

                changePage(1);
                currentSearch++;
            }
            else
            {
                watch.Stop();
                searchInfo.Text = "Please enter search text to get results, dingus.";
            }

        }

        private void displayPage(int page)
        {
            page = page > 0 ? page - 1 : 0;
            int startingResult = page * resultsPerPage;
            int endingResult = limitToRange(page * resultsPerPage + resultsPerPage, searchResults.Count, 0);
            int boxPosition = 0;

            int groupBoxHeight = 100;
            int groupBoxWidth = 680;

            int titleHeight = 50;
            int titleWidth = 250;
            int titleX = 7;
            int titleY = 12;

            int infoHeight = 30;
            int infoWidth = 250;
            int infoX = 7;
            int infoY = 60;

            int abstractHeight = 60;
            int abstractWidth = 400;
            int abstractX = 260;
            int abstractY = 12;

            int openX = 595;
            int openY = 65;

            Console.WriteLine("Displaying result {0}, {1} for page {2}", startingResult, endingResult, page + 1);

            listPanel1.Controls.Clear();


            for (int i = startingResult; i < endingResult; i++)
            {
                GroupBox result = new GroupBox();

                TextBox title = new TextBox();
                title.Text = searchResults[i][DOC_TITLE].ToUpper();
                title.AutoSize = false;
                title.Location = new Point(titleX, titleY);
                title.Size = new Size(titleWidth, titleHeight);
                title.Multiline = true;
                title.BorderStyle = BorderStyle.None;
                title.Font = new Font("Adobe Caslon Pro", 10);
                title.ReadOnly = true;

                TextBox info = new TextBox();
                info.Text = searchResults[i][DOC_AUTHOR] + "  -  " + searchResults[i][DOC_BIB];
                info.AutoSize = false;
                info.Location = new Point(infoX, infoY);
                info.Size = new Size(infoWidth, infoHeight);
                info.Multiline = true;
                info.BorderStyle = BorderStyle.None;
                info.ReadOnly = true;

                TextBox textAbstract = new TextBox();
                textAbstract.Text = Truncate(searchResults[i][DOC_BODY], 250);
                textAbstract.AutoSize = false;
                textAbstract.Location = new Point(abstractX, abstractY);
                textAbstract.Size = new Size(abstractWidth, abstractHeight);
                textAbstract.SendToBack();
                textAbstract.Multiline = true;
                textAbstract.BorderStyle = BorderStyle.None;
                textAbstract.Font = new Font("Times New Roman", 9);
                textAbstract.ReadOnly = true;

                Button openResult = new Button();
                openResult.Text = "Open";
                openResult.Location = new Point(openX, openY);
                openResult.BringToFront();

                openResult.Click += delegate { openDoc(i); };

                result.Controls.Add(openResult);
                result.Controls.Add(title);
                result.Controls.Add(info);
                result.Controls.Add(textAbstract);


                //TODO Assign full result window


                listPanel1.Controls.Add(result);
                result.Size = new Size(groupBoxWidth, groupBoxHeight);
                result.Location = new Point(0, boxPosition * groupBoxHeight);
                boxPosition++;

            }

        }

        private void openDoc(int resultsIndex) {
            Dictionary<string,string> result = searchResults[resultsIndex];
            Form docWindow = new Form();

            docWindow.Size = new Size(600, 600);

            TextBox title = new TextBox();
            title.Text = searchResults[resultsIndex][DOC_TITLE].ToUpper();
            title.AutoSize = false;
            title.Location = new Point(13, 12);
            title.Size = new Size(559, 53);
            title.Multiline = true;
            title.BorderStyle = BorderStyle.None;
            title.Font = new Font("Adobe Caslon Pro", 10);
            title.ReadOnly = true;

            TextBox author = new TextBox();
            author.Text = searchResults[resultsIndex][DOC_AUTHOR];
            author.AutoSize = false;
            author.Location = new Point(13, 71);
            author.Size = new Size(252, 20);
            author.Multiline = true;
            author.BorderStyle = BorderStyle.None;
            author.ReadOnly = true;

            TextBox bib = new TextBox();
            bib.Text = searchResults[resultsIndex][DOC_BIB];
            bib.AutoSize = false;
            bib.Location = new Point(13, 122);
            bib.Size = new Size(252, 20);
            bib.Multiline = true;
            bib.BorderStyle = BorderStyle.None;
            bib.ReadOnly = true;

            TextBox textAbstract = new TextBox();
            textAbstract.Text = searchResults[resultsIndex][DOC_BODY];
            textAbstract.AutoSize = false;
            textAbstract.Location = new Point(13, 168);
            textAbstract.Size = new Size(560, 381);
            textAbstract.SendToBack();
            textAbstract.Multiline = true;
            textAbstract.BorderStyle = BorderStyle.None;
            textAbstract.ScrollBars = ScrollBars.Vertical;
            textAbstract.Font = new Font("Times New Roman", 9);
            textAbstract.ReadOnly = true;

            docWindow.Controls.Add(title);
            docWindow.Controls.Add(author);
            docWindow.Controls.Add(bib);
            docWindow.Controls.Add(textAbstract);

            docWindow.Show();
        }

        private void btnPaginationNext_Click(object sender, EventArgs e)
        {
            int newPage = limitToRange(currentPage + 1, totalPages, 1);
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

        private void changePage(int newPage)
        {
            Console.WriteLine("changing to page {0}", newPage);
            changePagination(newPage);
            displayPage(newPage);
            currentPage = newPage;
        }

        private int limitToRange(int value, int max, int min)
        {
            if (value > max) { return max; };
            if (value < min) { return min; };
            return value;
        }

        private void changePagination(int newPage)
        {
            Console.WriteLine("Changing pagination to page {0} of {1} total pages", newPage, totalPages);
            if (newPage < 2)
            {
                btnPaginationPrv.Hide();
            }
            if (newPage < totalPages)
            {
                btnPaginationNext.Show();
            }
            if (newPage >= totalPages)
            {
                btnPaginationNext.Hide();
            }
            if (newPage > 1)
            {
                btnPaginationPrv.Show();
            }
            newPage = newPage > 0 ? newPage - 1 : 0;
            lblPaginationDisplay.Text = String.Format("Results {0} .. {1} of {2}", ((newPage * resultsPerPage) + 1), limitToRange(newPage * resultsPerPage + resultsPerPage, totalResults, 1), totalResults);
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            int resultNo = 1;
            FolderBrowserDialog saveTo = new FolderBrowserDialog();
            saveTo.Description = "Select where to save your results";
            DialogResult saveResult = saveTo.ShowDialog();
            if (saveResult == DialogResult.OK) {
                string filePath = @saveTo.SelectedPath+"\\results.txt";
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {                    
                    foreach (Dictionary<string, string> result in searchResults)
                    {
                        string paddedResult = numQueryNo.Text.PadLeft(3, '0');
                        sw.WriteLine(String.Format("{0} Q0 {1} {2} {3} n10323546_n10305769_n8551138_googs \n", paddedResult, result[DOC_ID].Replace("\n", ""), resultNo.ToString(), result[DOC_RANK]));
                        resultNo++;
                    }
                }
            }
        }

        private void lblSearchOptionsTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPaginationDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnMPPaginationPrev_Click(object sender, EventArgs e)
        {

        }

        private void lblMPPagination_Click(object sender, EventArgs e)
        {

        }

        private void btnMPPaginationNext_Click(object sender, EventArgs e)
        {

        }

        private void lblTermDisplayTitle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkPhrase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabSimpleSearch_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void queryExpansionCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numAuthorWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numBibWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numTitleWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numBodyWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numQueryNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIndexInformation_Click(object sender, EventArgs e)
        {

        }

        private void lblIndexInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtSimpleSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
