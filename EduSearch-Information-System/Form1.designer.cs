namespace EduSearch_Information_System
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
            this.groupBoxIndexSelection = new System.Windows.Forms.GroupBox();
            this.lblCollectionLocation = new System.Windows.Forms.Label();
            this.lblIndexLocation = new System.Windows.Forms.Label();
            this.btnIndexAccept = new System.Windows.Forms.Button();
            this.lblIndexFeedback = new System.Windows.Forms.Label();
            this.lblCollectionLoc = new System.Windows.Forms.Label();
            this.btnCollectionLoc = new System.Windows.Forms.Button();
            this.lblIndexLoc = new System.Windows.Forms.Label();
            this.btnIndexLoc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabSimpleSearch = new System.Windows.Forms.TabPage();
            this.searchInfo = new System.Windows.Forms.TextBox();
            this.checkPhrase = new System.Windows.Forms.CheckBox();
            this.lblIndexInformation = new System.Windows.Forms.Label();
            this.lblIndexInfoTitle = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.lblSearchOptionsTitle = new System.Windows.Forms.Label();
            this.lblPaginationDisplay = new System.Windows.Forms.Label();
            this.btnPaginationNext = new System.Windows.Forms.Button();
            this.btnPaginationPrv = new System.Windows.Forms.Button();
            this.lblSearchDetails = new System.Windows.Forms.Label();
            this.lblTermDisplayTitle = new System.Windows.Forms.Label();
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.txtSimpleSearch = new System.Windows.Forms.TextBox();
            this.listPanel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.numQueryNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBodyWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numTitleWeight = new System.Windows.Forms.NumericUpDown();
            this.numBibWeight = new System.Windows.Forms.NumericUpDown();
            this.numAuthorWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIndexSelection.SuspendLayout();
            this.tabSimpleSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQueryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBodyWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTitleWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBibWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAuthorWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIndexSelection
            // 
            this.groupBoxIndexSelection.Controls.Add(this.lblCollectionLocation);
            this.groupBoxIndexSelection.Controls.Add(this.lblIndexLocation);
            this.groupBoxIndexSelection.Controls.Add(this.btnIndexAccept);
            this.groupBoxIndexSelection.Controls.Add(this.lblIndexFeedback);
            this.groupBoxIndexSelection.Controls.Add(this.lblCollectionLoc);
            this.groupBoxIndexSelection.Controls.Add(this.btnCollectionLoc);
            this.groupBoxIndexSelection.Controls.Add(this.lblIndexLoc);
            this.groupBoxIndexSelection.Controls.Add(this.btnIndexLoc);
            this.groupBoxIndexSelection.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIndexSelection.Name = "groupBoxIndexSelection";
            this.groupBoxIndexSelection.Size = new System.Drawing.Size(530, 160);
            this.groupBoxIndexSelection.TabIndex = 8;
            this.groupBoxIndexSelection.TabStop = false;
            this.groupBoxIndexSelection.Text = "Indexing";
            // 
            // lblCollectionLocation
            // 
            this.lblCollectionLocation.AutoSize = true;
            this.lblCollectionLocation.Location = new System.Drawing.Point(30, 65);
            this.lblCollectionLocation.Name = "lblCollectionLocation";
            this.lblCollectionLocation.Size = new System.Drawing.Size(0, 13);
            this.lblCollectionLocation.TabIndex = 12;
            // 
            // lblIndexLocation
            // 
            this.lblIndexLocation.AutoSize = true;
            this.lblIndexLocation.Location = new System.Drawing.Point(512, 61);
            this.lblIndexLocation.Name = "lblIndexLocation";
            this.lblIndexLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIndexLocation.Size = new System.Drawing.Size(0, 13);
            this.lblIndexLocation.TabIndex = 11;
            // 
            // btnIndexAccept
            // 
            this.btnIndexAccept.Location = new System.Drawing.Point(210, 131);
            this.btnIndexAccept.Name = "btnIndexAccept";
            this.btnIndexAccept.Size = new System.Drawing.Size(113, 23);
            this.btnIndexAccept.TabIndex = 9;
            this.btnIndexAccept.Text = "Create Index";
            this.btnIndexAccept.UseVisualStyleBackColor = true;
            this.btnIndexAccept.Click += new System.EventHandler(this.btnIndexAccept_Click);
            // 
            // lblIndexFeedback
            // 
            this.lblIndexFeedback.AutoSize = true;
            this.lblIndexFeedback.Location = new System.Drawing.Point(272, 106);
            this.lblIndexFeedback.Name = "lblIndexFeedback";
            this.lblIndexFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblIndexFeedback.TabIndex = 8;
            this.lblIndexFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCollectionLoc
            // 
            this.lblCollectionLoc.AutoSize = true;
            this.lblCollectionLoc.Location = new System.Drawing.Point(6, 16);
            this.lblCollectionLoc.Name = "lblCollectionLoc";
            this.lblCollectionLoc.Size = new System.Drawing.Size(165, 13);
            this.lblCollectionLoc.TabIndex = 5;
            this.lblCollectionLoc.Text = "Please Select Collection Location";
            // 
            // btnCollectionLoc
            // 
            this.btnCollectionLoc.Location = new System.Drawing.Point(30, 35);
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
            this.lblIndexLoc.Location = new System.Drawing.Point(374, 19);
            this.lblIndexLoc.Name = "lblIndexLoc";
            this.lblIndexLoc.Size = new System.Drawing.Size(150, 13);
            this.lblIndexLoc.TabIndex = 6;
            this.lblIndexLoc.Text = "Plesase Select Index Location";
            // 
            // btnIndexLoc
            // 
            this.btnIndexLoc.Location = new System.Drawing.Point(396, 35);
            this.btnIndexLoc.Name = "btnIndexLoc";
            this.btnIndexLoc.Size = new System.Drawing.Size(113, 23);
            this.btnIndexLoc.TabIndex = 3;
            this.btnIndexLoc.Text = "Browse";
            this.btnIndexLoc.UseVisualStyleBackColor = true;
            this.btnIndexLoc.Click += new System.EventHandler(this.btnIndexLoc_Click);
            // 
            // tabSimpleSearch
            // 
            this.tabSimpleSearch.Controls.Add(this.numAuthorWeight);
            this.tabSimpleSearch.Controls.Add(this.numBibWeight);
            this.tabSimpleSearch.Controls.Add(this.numTitleWeight);
            this.tabSimpleSearch.Controls.Add(this.label6);
            this.tabSimpleSearch.Controls.Add(this.label5);
            this.tabSimpleSearch.Controls.Add(this.label4);
            this.tabSimpleSearch.Controls.Add(this.label3);
            this.tabSimpleSearch.Controls.Add(this.label2);
            this.tabSimpleSearch.Controls.Add(this.numBodyWeight);
            this.tabSimpleSearch.Controls.Add(this.label1);
            this.tabSimpleSearch.Controls.Add(this.numQueryNo);
            this.tabSimpleSearch.Controls.Add(this.searchInfo);
            this.tabSimpleSearch.Controls.Add(this.checkPhrase);
            this.tabSimpleSearch.Controls.Add(this.lblIndexInformation);
            this.tabSimpleSearch.Controls.Add(this.lblIndexInfoTitle);
            this.tabSimpleSearch.Controls.Add(this.lblSearchTitle);
            this.tabSimpleSearch.Controls.Add(this.btnSaveResults);
            this.tabSimpleSearch.Controls.Add(this.lblSearchOptionsTitle);
            this.tabSimpleSearch.Controls.Add(this.lblPaginationDisplay);
            this.tabSimpleSearch.Controls.Add(this.btnPaginationNext);
            this.tabSimpleSearch.Controls.Add(this.btnPaginationPrv);
            this.tabSimpleSearch.Controls.Add(this.lblSearchDetails);
            this.tabSimpleSearch.Controls.Add(this.lblTermDisplayTitle);
            this.tabSimpleSearch.Controls.Add(this.btnSimpleSearch);
            this.tabSimpleSearch.Controls.Add(this.txtSimpleSearch);
            this.tabSimpleSearch.Controls.Add(this.listPanel1);
            this.tabSimpleSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSimpleSearch.Name = "tabSimpleSearch";
            this.tabSimpleSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimpleSearch.Size = new System.Drawing.Size(1109, 692);
            this.tabSimpleSearch.TabIndex = 0;
            this.tabSimpleSearch.Text = "Simple Search";
            this.tabSimpleSearch.UseVisualStyleBackColor = true;
            // 
            // searchInfo
            // 
            this.searchInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInfo.Location = new System.Drawing.Point(20, 295);
            this.searchInfo.Multiline = true;
            this.searchInfo.Name = "searchInfo";
            this.searchInfo.Size = new System.Drawing.Size(339, 89);
            this.searchInfo.TabIndex = 21;
            // 
            // checkPhrase
            // 
            this.checkPhrase.AutoSize = true;
            this.checkPhrase.Location = new System.Drawing.Point(15, 95);
            this.checkPhrase.Name = "checkPhrase";
            this.checkPhrase.Size = new System.Drawing.Size(126, 17);
            this.checkPhrase.TabIndex = 20;
            this.checkPhrase.Text = "Search for full phrase";
            this.checkPhrase.UseVisualStyleBackColor = true;
            // 
            // lblIndexInformation
            // 
            this.lblIndexInformation.AutoSize = true;
            this.lblIndexInformation.Location = new System.Drawing.Point(17, 428);
            this.lblIndexInformation.Name = "lblIndexInformation";
            this.lblIndexInformation.Size = new System.Drawing.Size(0, 13);
            this.lblIndexInformation.TabIndex = 18;
            // 
            // lblIndexInfoTitle
            // 
            this.lblIndexInfoTitle.AutoSize = true;
            this.lblIndexInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexInfoTitle.Location = new System.Drawing.Point(16, 387);
            this.lblIndexInfoTitle.Name = "lblIndexInfoTitle";
            this.lblIndexInfoTitle.Size = new System.Drawing.Size(171, 24);
            this.lblIndexInfoTitle.TabIndex = 17;
            this.lblIndexInfoTitle.Text = "Index Information";
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSearchTitle.Location = new System.Drawing.Point(109, 23);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(159, 29);
            this.lblSearchTitle.TabIndex = 15;
            this.lblSearchTitle.Text = "Term Search";
            this.lblSearchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(8, 638);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(101, 23);
            this.btnSaveResults.TabIndex = 14;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // lblSearchOptionsTitle
            // 
            this.lblSearchOptionsTitle.AutoSize = true;
            this.lblSearchOptionsTitle.Location = new System.Drawing.Point(121, 604);
            this.lblSearchOptionsTitle.Name = "lblSearchOptionsTitle";
            this.lblSearchOptionsTitle.Size = new System.Drawing.Size(80, 13);
            this.lblSearchOptionsTitle.TabIndex = 13;
            this.lblSearchOptionsTitle.Text = "Search Options";
            this.lblSearchOptionsTitle.Click += new System.EventHandler(this.lblSearchOptionsTitle_Click);
            // 
            // lblPaginationDisplay
            // 
            this.lblPaginationDisplay.AutoSize = true;
            this.lblPaginationDisplay.Location = new System.Drawing.Point(713, 657);
            this.lblPaginationDisplay.Name = "lblPaginationDisplay";
            this.lblPaginationDisplay.Size = new System.Drawing.Size(96, 13);
            this.lblPaginationDisplay.TabIndex = 8;
            this.lblPaginationDisplay.Text = "Results 1..10 of 50";
            this.lblPaginationDisplay.Visible = false;
            this.lblPaginationDisplay.Click += new System.EventHandler(this.lblPaginationDisplay_Click);
            // 
            // btnPaginationNext
            // 
            this.btnPaginationNext.Location = new System.Drawing.Point(815, 652);
            this.btnPaginationNext.Name = "btnPaginationNext";
            this.btnPaginationNext.Size = new System.Drawing.Size(75, 23);
            this.btnPaginationNext.TabIndex = 7;
            this.btnPaginationNext.Text = "Next";
            this.btnPaginationNext.UseVisualStyleBackColor = true;
            this.btnPaginationNext.Visible = false;
            this.btnPaginationNext.Click += new System.EventHandler(this.btnPaginationNext_Click);
            // 
            // btnPaginationPrv
            // 
            this.btnPaginationPrv.Location = new System.Drawing.Point(632, 652);
            this.btnPaginationPrv.Name = "btnPaginationPrv";
            this.btnPaginationPrv.Size = new System.Drawing.Size(75, 23);
            this.btnPaginationPrv.TabIndex = 6;
            this.btnPaginationPrv.Text = "Previous";
            this.btnPaginationPrv.UseVisualStyleBackColor = true;
            this.btnPaginationPrv.Visible = false;
            this.btnPaginationPrv.Click += new System.EventHandler(this.btnPaginationPrv_Click);
            // 
            // lblSearchDetails
            // 
            this.lblSearchDetails.AutoSize = true;
            this.lblSearchDetails.Location = new System.Drawing.Point(369, 17);
            this.lblSearchDetails.Name = "lblSearchDetails";
            this.lblSearchDetails.Size = new System.Drawing.Size(0, 13);
            this.lblSearchDetails.TabIndex = 5;
            // 
            // lblTermDisplayTitle
            // 
            this.lblTermDisplayTitle.AutoSize = true;
            this.lblTermDisplayTitle.Location = new System.Drawing.Point(17, 279);
            this.lblTermDisplayTitle.Name = "lblTermDisplayTitle";
            this.lblTermDisplayTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTermDisplayTitle.TabIndex = 3;
            this.lblTermDisplayTitle.Text = "Search Results:";
            this.lblTermDisplayTitle.Click += new System.EventHandler(this.lblTermDisplayTitle_Click);
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Location = new System.Drawing.Point(185, 229);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(174, 23);
            this.btnSimpleSearch.TabIndex = 1;
            this.btnSimpleSearch.Text = "Search";
            this.btnSimpleSearch.UseVisualStyleBackColor = true;
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // txtSimpleSearch
            // 
            this.txtSimpleSearch.Location = new System.Drawing.Point(15, 118);
            this.txtSimpleSearch.Name = "txtSimpleSearch";
            this.txtSimpleSearch.Size = new System.Drawing.Size(339, 20);
            this.txtSimpleSearch.TabIndex = 0;
            // 
            // listPanel1
            // 
            this.listPanel1.AutoScroll = true;
            this.listPanel1.Location = new System.Drawing.Point(392, 7);
            this.listPanel1.Name = "listPanel1";
            this.listPanel1.Size = new System.Drawing.Size(708, 631);
            this.listPanel1.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimpleSearch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 718);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // numQueryNo
            // 
            this.numQueryNo.Location = new System.Drawing.Point(69, 164);
            this.numQueryNo.Name = "numQueryNo";
            this.numQueryNo.Size = new System.Drawing.Size(61, 20);
            this.numQueryNo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "QueryNo.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numBodyWeight
            // 
            this.numBodyWeight.DecimalPlaces = 2;
            this.numBodyWeight.Location = new System.Drawing.Point(200, 164);
            this.numBodyWeight.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            this.numBodyWeight.Name = "numBodyWeight";
            this.numBodyWeight.Size = new System.Drawing.Size(52, 20);
            this.numBodyWeight.TabIndex = 26;
            this.numBodyWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Field Weights";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Biblio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Title";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numTitleWeight
            // 
            this.numTitleWeight.DecimalPlaces = 2;
            this.numTitleWeight.Location = new System.Drawing.Point(200, 201);
            this.numTitleWeight.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            this.numTitleWeight.Name = "numTitleWeight";
            this.numTitleWeight.Size = new System.Drawing.Size(52, 20);
            this.numTitleWeight.TabIndex = 33;
            this.numTitleWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBibWeight
            // 
            this.numBibWeight.DecimalPlaces = 2;
            this.numBibWeight.Location = new System.Drawing.Point(302, 201);
            this.numBibWeight.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            this.numBibWeight.Name = "numBibWeight";
            this.numBibWeight.Size = new System.Drawing.Size(52, 20);
            this.numBibWeight.TabIndex = 34;
            this.numBibWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAuthorWeight
            // 
            this.numAuthorWeight.DecimalPlaces = 2;
            this.numAuthorWeight.Location = new System.Drawing.Point(302, 164);
            this.numAuthorWeight.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            this.numAuthorWeight.Name = "numAuthorWeight";
            this.numAuthorWeight.Size = new System.Drawing.Size(52, 20);
            this.numAuthorWeight.TabIndex = 35;
            this.numAuthorWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 719);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxIndexSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIndexSelection.ResumeLayout(false);
            this.groupBoxIndexSelection.PerformLayout();
            this.tabSimpleSearch.ResumeLayout(false);
            this.tabSimpleSearch.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQueryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBodyWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTitleWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBibWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAuthorWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIndexLoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCollectionLoc;
        private System.Windows.Forms.Label lblCollectionLoc;
        private System.Windows.Forms.Label lblIndexLoc;
        private System.Windows.Forms.GroupBox groupBoxIndexSelection;
        private System.Windows.Forms.Button btnIndexAccept;
        private System.Windows.Forms.Label lblIndexFeedback;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label lblIndexLocation;
        private System.Windows.Forms.Label lblCollectionLocation;
        private System.Windows.Forms.TabPage tabSimpleSearch;
        private System.Windows.Forms.Label lblIndexInformation;
        private System.Windows.Forms.Label lblIndexInfoTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Label lblSearchOptionsTitle;
        private System.Windows.Forms.Label lblPaginationDisplay;
        private System.Windows.Forms.Button btnPaginationNext;
        private System.Windows.Forms.Button btnPaginationPrv;
        private System.Windows.Forms.Label lblSearchDetails;
        private System.Windows.Forms.Label lblTermDisplayTitle;
        private System.Windows.Forms.Button btnSimpleSearch;
        private System.Windows.Forms.TextBox txtSimpleSearch;
        private System.Windows.Forms.Panel listPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox checkPhrase;
        private System.Windows.Forms.TextBox searchInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBodyWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQueryNo;
        private System.Windows.Forms.NumericUpDown numAuthorWeight;
        private System.Windows.Forms.NumericUpDown numBibWeight;
        private System.Windows.Forms.NumericUpDown numTitleWeight;
    }
}

