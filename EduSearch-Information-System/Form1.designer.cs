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
            this.listPanel1 = new System.Windows.Forms.Panel();
            this.txtSimpleSearch = new System.Windows.Forms.TextBox();
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.lblTermDisplayTitle = new System.Windows.Forms.Label();
            this.lblSearchDetails = new System.Windows.Forms.Label();
            this.btnPaginationPrv = new System.Windows.Forms.Button();
            this.btnPaginationNext = new System.Windows.Forms.Button();
            this.lblPaginationDisplay = new System.Windows.Forms.Label();
            this.lblSearchOptionsTitle = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.lblIndexInfoTitle = new System.Windows.Forms.Label();
            this.lblIndexInformation = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.checkPhrase = new System.Windows.Forms.CheckBox();
            this.searchInfo = new System.Windows.Forms.TextBox();
            this.groupBoxIndexSelection.SuspendLayout();
            this.tabSimpleSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            // listPanel1
            // 
            this.listPanel1.AutoScroll = true;
            this.listPanel1.Location = new System.Drawing.Point(392, 7);
            this.listPanel1.Name = "listPanel1";
            this.listPanel1.Size = new System.Drawing.Size(708, 631);
            this.listPanel1.TabIndex = 19;
            // 
            // txtSimpleSearch
            // 
            this.txtSimpleSearch.Location = new System.Drawing.Point(15, 118);
            this.txtSimpleSearch.Name = "txtSimpleSearch";
            this.txtSimpleSearch.Size = new System.Drawing.Size(339, 20);
            this.txtSimpleSearch.TabIndex = 0;
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Location = new System.Drawing.Point(180, 144);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(174, 23);
            this.btnSimpleSearch.TabIndex = 1;
            this.btnSimpleSearch.Text = "Search";
            this.btnSimpleSearch.UseVisualStyleBackColor = true;
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // lblTermDisplayTitle
            // 
            this.lblTermDisplayTitle.AutoSize = true;
            this.lblTermDisplayTitle.Location = new System.Drawing.Point(12, 194);
            this.lblTermDisplayTitle.Name = "lblTermDisplayTitle";
            this.lblTermDisplayTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTermDisplayTitle.TabIndex = 3;
            this.lblTermDisplayTitle.Text = "Search Results:";
            this.lblTermDisplayTitle.Click += new System.EventHandler(this.lblTermDisplayTitle_Click);
            // 
            // lblSearchDetails
            // 
            this.lblSearchDetails.AutoSize = true;
            this.lblSearchDetails.Location = new System.Drawing.Point(369, 17);
            this.lblSearchDetails.Name = "lblSearchDetails";
            this.lblSearchDetails.Size = new System.Drawing.Size(0, 13);
            this.lblSearchDetails.TabIndex = 5;
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
            // lblIndexInfoTitle
            // 
            this.lblIndexInfoTitle.AutoSize = true;
            this.lblIndexInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexInfoTitle.Location = new System.Drawing.Point(11, 302);
            this.lblIndexInfoTitle.Name = "lblIndexInfoTitle";
            this.lblIndexInfoTitle.Size = new System.Drawing.Size(171, 24);
            this.lblIndexInfoTitle.TabIndex = 17;
            this.lblIndexInfoTitle.Text = "Index Information";
            // 
            // lblIndexInformation
            // 
            this.lblIndexInformation.AutoSize = true;
            this.lblIndexInformation.Location = new System.Drawing.Point(19, 258);
            this.lblIndexInformation.Name = "lblIndexInformation";
            this.lblIndexInformation.Size = new System.Drawing.Size(0, 13);
            this.lblIndexInformation.TabIndex = 18;
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
            // searchInfo
            // 
            this.searchInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInfo.Location = new System.Drawing.Point(15, 210);
            this.searchInfo.Multiline = true;
            this.searchInfo.Name = "searchInfo";
            this.searchInfo.Size = new System.Drawing.Size(340, 20);
            this.searchInfo.TabIndex = 21;
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
    }
}

