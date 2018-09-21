namespace AssignmentWindow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSimpleSearch = new System.Windows.Forms.TabPage();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.lblSearchOptionsTitle = new System.Windows.Forms.Label();
            this.lblResult1Abstract = new System.Windows.Forms.Label();
            this.lblResult1Bib = new System.Windows.Forms.Label();
            this.lblResult1Author = new System.Windows.Forms.Label();
            this.lblResult1Title = new System.Windows.Forms.Label();
            this.lblPaginationDisplay = new System.Windows.Forms.Label();
            this.btnPaginationNext = new System.Windows.Forms.Button();
            this.btnPaginationPrv = new System.Windows.Forms.Button();
            this.lblSearchDetails = new System.Windows.Forms.Label();
            this.lblTermDisplay = new System.Windows.Forms.Label();
            this.lblTermDisplayTitle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.txtSimpleSearch = new System.Windows.Forms.TextBox();
            this.tabMultiTermSearch = new System.Windows.Forms.TabPage();
            this.groupBoxIndexSelection = new System.Windows.Forms.GroupBox();
            this.btnIndexAccept = new System.Windows.Forms.Button();
            this.lblIndexFeedback = new System.Windows.Forms.Label();
            this.lblCollectionLoc = new System.Windows.Forms.Label();
            this.btnCollectionLoc = new System.Windows.Forms.Button();
            this.lblIndexLoc = new System.Windows.Forms.Label();
            this.btnIndexLoc = new System.Windows.Forms.Button();
            this.tabMultiPhraseSearch = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabSimpleSearch.SuspendLayout();
            this.groupBoxIndexSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimpleSearch);
            this.tabControl1.Controls.Add(this.tabMultiTermSearch);
            this.tabControl1.Controls.Add(this.tabMultiPhraseSearch);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 600);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabSimpleSearch
            // 
            this.tabSimpleSearch.Controls.Add(this.btnSaveResults);
            this.tabSimpleSearch.Controls.Add(this.lblSearchOptionsTitle);
            this.tabSimpleSearch.Controls.Add(this.lblResult1Abstract);
            this.tabSimpleSearch.Controls.Add(this.lblResult1Bib);
            this.tabSimpleSearch.Controls.Add(this.lblResult1Author);
            this.tabSimpleSearch.Controls.Add(this.lblResult1Title);
            this.tabSimpleSearch.Controls.Add(this.lblPaginationDisplay);
            this.tabSimpleSearch.Controls.Add(this.btnPaginationNext);
            this.tabSimpleSearch.Controls.Add(this.btnPaginationPrv);
            this.tabSimpleSearch.Controls.Add(this.lblSearchDetails);
            this.tabSimpleSearch.Controls.Add(this.lblTermDisplay);
            this.tabSimpleSearch.Controls.Add(this.lblTermDisplayTitle);
            this.tabSimpleSearch.Controls.Add(this.listView1);
            this.tabSimpleSearch.Controls.Add(this.btnSimpleSearch);
            this.tabSimpleSearch.Controls.Add(this.txtSimpleSearch);
            this.tabSimpleSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSimpleSearch.Name = "tabSimpleSearch";
            this.tabSimpleSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimpleSearch.Size = new System.Drawing.Size(903, 574);
            this.tabSimpleSearch.TabIndex = 0;
            this.tabSimpleSearch.Text = "Simple Search";
            this.tabSimpleSearch.UseVisualStyleBackColor = true;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(20, 534);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(101, 23);
            this.btnSaveResults.TabIndex = 14;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            // 
            // lblSearchOptionsTitle
            // 
            this.lblSearchOptionsTitle.AutoSize = true;
            this.lblSearchOptionsTitle.Location = new System.Drawing.Point(135, 483);
            this.lblSearchOptionsTitle.Name = "lblSearchOptionsTitle";
            this.lblSearchOptionsTitle.Size = new System.Drawing.Size(80, 13);
            this.lblSearchOptionsTitle.TabIndex = 13;
            this.lblSearchOptionsTitle.Text = "Search Options";
            this.lblSearchOptionsTitle.Click += new System.EventHandler(this.lblSearchOptionsTitle_Click);
            // 
            // lblResult1Abstract
            // 
            this.lblResult1Abstract.AutoSize = true;
            this.lblResult1Abstract.Location = new System.Drawing.Point(377, 70);
            this.lblResult1Abstract.Name = "lblResult1Abstract";
            this.lblResult1Abstract.Size = new System.Drawing.Size(46, 13);
            this.lblResult1Abstract.TabIndex = 12;
            this.lblResult1Abstract.Text = "Abstract";
            // 
            // lblResult1Bib
            // 
            this.lblResult1Bib.AutoSize = true;
            this.lblResult1Bib.Location = new System.Drawing.Point(543, 45);
            this.lblResult1Bib.Name = "lblResult1Bib";
            this.lblResult1Bib.Size = new System.Drawing.Size(88, 13);
            this.lblResult1Bib.TabIndex = 11;
            this.lblResult1Bib.Text = "Bibliographic Info";
            // 
            // lblResult1Author
            // 
            this.lblResult1Author.AutoSize = true;
            this.lblResult1Author.Location = new System.Drawing.Point(453, 45);
            this.lblResult1Author.Name = "lblResult1Author";
            this.lblResult1Author.Size = new System.Drawing.Size(38, 13);
            this.lblResult1Author.TabIndex = 10;
            this.lblResult1Author.Text = "Author";
            // 
            // lblResult1Title
            // 
            this.lblResult1Title.AutoSize = true;
            this.lblResult1Title.Location = new System.Drawing.Point(377, 45);
            this.lblResult1Title.Name = "lblResult1Title";
            this.lblResult1Title.Size = new System.Drawing.Size(27, 13);
            this.lblResult1Title.TabIndex = 9;
            this.lblResult1Title.Text = "Title";
            // 
            // lblPaginationDisplay
            // 
            this.lblPaginationDisplay.AutoSize = true;
            this.lblPaginationDisplay.Location = new System.Drawing.Point(578, 539);
            this.lblPaginationDisplay.Name = "lblPaginationDisplay";
            this.lblPaginationDisplay.Size = new System.Drawing.Size(96, 13);
            this.lblPaginationDisplay.TabIndex = 8;
            this.lblPaginationDisplay.Text = "Results 1..10 of 50";
            this.lblPaginationDisplay.Click += new System.EventHandler(this.lblPaginationDisplay_Click);
            // 
            // btnPaginationNext
            // 
            this.btnPaginationNext.Location = new System.Drawing.Point(809, 534);
            this.btnPaginationNext.Name = "btnPaginationNext";
            this.btnPaginationNext.Size = new System.Drawing.Size(75, 23);
            this.btnPaginationNext.TabIndex = 7;
            this.btnPaginationNext.Text = "Next";
            this.btnPaginationNext.UseVisualStyleBackColor = true;
            // 
            // btnPaginationPrv
            // 
            this.btnPaginationPrv.Location = new System.Drawing.Point(377, 534);
            this.btnPaginationPrv.Name = "btnPaginationPrv";
            this.btnPaginationPrv.Size = new System.Drawing.Size(75, 23);
            this.btnPaginationPrv.TabIndex = 6;
            this.btnPaginationPrv.Text = "Previous";
            this.btnPaginationPrv.UseVisualStyleBackColor = true;
            this.btnPaginationPrv.Visible = false;
            // 
            // lblSearchDetails
            // 
            this.lblSearchDetails.AutoSize = true;
            this.lblSearchDetails.Location = new System.Drawing.Point(374, 17);
            this.lblSearchDetails.Name = "lblSearchDetails";
            this.lblSearchDetails.Size = new System.Drawing.Size(0, 13);
            this.lblSearchDetails.TabIndex = 5;
            this.lblSearchDetails.Click += new System.EventHandler(this.lblSearchTime_Click);
            // 
            // lblTermDisplay
            // 
            this.lblTermDisplay.AutoSize = true;
            this.lblTermDisplay.Location = new System.Drawing.Point(17, 184);
            this.lblTermDisplay.Name = "lblTermDisplay";
            this.lblTermDisplay.Size = new System.Drawing.Size(104, 13);
            this.lblTermDisplay.TabIndex = 4;
            this.lblTermDisplay.Text = "No search submitted";
            // 
            // lblTermDisplayTitle
            // 
            this.lblTermDisplayTitle.AutoSize = true;
            this.lblTermDisplayTitle.Location = new System.Drawing.Point(20, 154);
            this.lblTermDisplayTitle.Name = "lblTermDisplayTitle";
            this.lblTermDisplayTitle.Size = new System.Drawing.Size(218, 13);
            this.lblTermDisplayTitle.TabIndex = 3;
            this.lblTermDisplayTitle.Text = "Current results are for a processed search of:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(365, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(532, 562);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Location = new System.Drawing.Point(185, 110);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(174, 23);
            this.btnSimpleSearch.TabIndex = 1;
            this.btnSimpleSearch.Text = "Search";
            this.btnSimpleSearch.UseVisualStyleBackColor = true;
            // 
            // txtSimpleSearch
            // 
            this.txtSimpleSearch.Location = new System.Drawing.Point(20, 84);
            this.txtSimpleSearch.Name = "txtSimpleSearch";
            this.txtSimpleSearch.Size = new System.Drawing.Size(339, 20);
            this.txtSimpleSearch.TabIndex = 0;
            // 
            // tabMultiTermSearch
            // 
            this.tabMultiTermSearch.Location = new System.Drawing.Point(4, 22);
            this.tabMultiTermSearch.Name = "tabMultiTermSearch";
            this.tabMultiTermSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiTermSearch.Size = new System.Drawing.Size(903, 574);
            this.tabMultiTermSearch.TabIndex = 1;
            this.tabMultiTermSearch.Text = "Multi-Term Search";
            this.tabMultiTermSearch.UseVisualStyleBackColor = true;
            // 
            // groupBoxIndexSelection
            // 
            this.groupBoxIndexSelection.Controls.Add(this.btnIndexAccept);
            this.groupBoxIndexSelection.Controls.Add(this.lblIndexFeedback);
            this.groupBoxIndexSelection.Controls.Add(this.lblCollectionLoc);
            this.groupBoxIndexSelection.Controls.Add(this.btnCollectionLoc);
            this.groupBoxIndexSelection.Controls.Add(this.lblIndexLoc);
            this.groupBoxIndexSelection.Controls.Add(this.btnIndexLoc);
            this.groupBoxIndexSelection.Location = new System.Drawing.Point(166, 211);
            this.groupBoxIndexSelection.Name = "groupBoxIndexSelection";
            this.groupBoxIndexSelection.Size = new System.Drawing.Size(530, 160);
            this.groupBoxIndexSelection.TabIndex = 8;
            this.groupBoxIndexSelection.TabStop = false;
            this.groupBoxIndexSelection.Text = "Indexing";
            // 
            // btnIndexAccept
            // 
            this.btnIndexAccept.Location = new System.Drawing.Point(194, 101);
            this.btnIndexAccept.Name = "btnIndexAccept";
            this.btnIndexAccept.Size = new System.Drawing.Size(113, 23);
            this.btnIndexAccept.TabIndex = 9;
            this.btnIndexAccept.Text = "Create Index";
            this.btnIndexAccept.UseVisualStyleBackColor = true;
            // 
            // lblIndexFeedback
            // 
            this.lblIndexFeedback.AutoSize = true;
            this.lblIndexFeedback.Location = new System.Drawing.Point(92, 80);
            this.lblIndexFeedback.Name = "lblIndexFeedback";
            this.lblIndexFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblIndexFeedback.TabIndex = 8;
            // 
            // lblCollectionLoc
            // 
            this.lblCollectionLoc.AutoSize = true;
            this.lblCollectionLoc.Location = new System.Drawing.Point(6, 16);
            this.lblCollectionLoc.Name = "lblCollectionLoc";
            this.lblCollectionLoc.Size = new System.Drawing.Size(165, 13);
            this.lblCollectionLoc.TabIndex = 5;
            this.lblCollectionLoc.Text = "Please Select Collection Location";
            this.lblCollectionLoc.Click += new System.EventHandler(this.lblCollectionLoc_Click);
            // 
            // btnCollectionLoc
            // 
            this.btnCollectionLoc.Location = new System.Drawing.Point(6, 35);
            this.btnCollectionLoc.Name = "btnCollectionLoc";
            this.btnCollectionLoc.Size = new System.Drawing.Size(113, 23);
            this.btnCollectionLoc.TabIndex = 4;
            this.btnCollectionLoc.Text = "Browse";
            this.btnCollectionLoc.UseVisualStyleBackColor = true;
            this.btnCollectionLoc.Click += new System.EventHandler(this.btnCollectionLoc_Click);
            // 
            // lblIndexLoc
            // 
            this.lblIndexLoc.AutoSize = true;
            this.lblIndexLoc.Location = new System.Drawing.Point(279, 16);
            this.lblIndexLoc.Name = "lblIndexLoc";
            this.lblIndexLoc.Size = new System.Drawing.Size(150, 13);
            this.lblIndexLoc.TabIndex = 6;
            this.lblIndexLoc.Text = "Plesase Select Index Location";
            this.lblIndexLoc.Click += new System.EventHandler(this.lblIndexLoc_Click);
            // 
            // btnIndexLoc
            // 
            this.btnIndexLoc.Location = new System.Drawing.Point(282, 35);
            this.btnIndexLoc.Name = "btnIndexLoc";
            this.btnIndexLoc.Size = new System.Drawing.Size(113, 23);
            this.btnIndexLoc.TabIndex = 3;
            this.btnIndexLoc.Text = "Browse";
            this.btnIndexLoc.UseVisualStyleBackColor = true;
            this.btnIndexLoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabMultiPhraseSearch
            // 
            this.tabMultiPhraseSearch.Location = new System.Drawing.Point(4, 22);
            this.tabMultiPhraseSearch.Name = "tabMultiPhraseSearch";
            this.tabMultiPhraseSearch.Size = new System.Drawing.Size(903, 574);
            this.tabMultiPhraseSearch.TabIndex = 2;
            this.tabMultiPhraseSearch.Text = "Multi-Phrase Search";
            this.tabMultiPhraseSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 622);
            this.Controls.Add(this.groupBoxIndexSelection);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabSimpleSearch.ResumeLayout(false);
            this.tabSimpleSearch.PerformLayout();
            this.groupBoxIndexSelection.ResumeLayout(false);
            this.groupBoxIndexSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSimpleSearch;
        private System.Windows.Forms.Button btnSimpleSearch;
        private System.Windows.Forms.TextBox txtSimpleSearch;
        private System.Windows.Forms.TabPage tabMultiTermSearch;
        private System.Windows.Forms.TabPage tabMultiPhraseSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnIndexLoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCollectionLoc;
        private System.Windows.Forms.Label lblCollectionLoc;
        private System.Windows.Forms.Label lblIndexLoc;
        private System.Windows.Forms.GroupBox groupBoxIndexSelection;
        private System.Windows.Forms.Button btnIndexAccept;
        private System.Windows.Forms.Label lblIndexFeedback;
        private System.Windows.Forms.Label lblSearchDetails;
        private System.Windows.Forms.Label lblTermDisplay;
        private System.Windows.Forms.Label lblTermDisplayTitle;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Label lblSearchOptionsTitle;
        private System.Windows.Forms.Label lblResult1Abstract;
        private System.Windows.Forms.Label lblResult1Bib;
        private System.Windows.Forms.Label lblResult1Author;
        private System.Windows.Forms.Label lblResult1Title;
        private System.Windows.Forms.Label lblPaginationDisplay;
        private System.Windows.Forms.Button btnPaginationNext;
        private System.Windows.Forms.Button btnPaginationPrv;
    }
}

