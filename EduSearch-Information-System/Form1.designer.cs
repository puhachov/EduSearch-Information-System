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
            this.tabMultiPhraseSearch = new System.Windows.Forms.TabPage();
            this.lblMPTitle = new System.Windows.Forms.Label();
            this.btnMPSaveResults = new System.Windows.Forms.Button();
            this.lblMPSearchOptions = new System.Windows.Forms.Label();
            this.lblMPPagination = new System.Windows.Forms.Label();
            this.btnMPPaginationNext = new System.Windows.Forms.Button();
            this.btnMPPaginationPrev = new System.Windows.Forms.Button();
            this.lblMPSearchInfo = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnMPSearch = new System.Windows.Forms.Button();
            this.txtBoxMPSearchInput = new System.Windows.Forms.TextBox();
            this.tabSimpleSearch = new System.Windows.Forms.TabPage();
            this.lblIndexInformation = new System.Windows.Forms.Label();
            this.lblIndexInfoTitle = new System.Windows.Forms.Label();
            this.labelTermSearch = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.lblSearchOptionsTitle = new System.Windows.Forms.Label();
            this.lblPaginationDisplay = new System.Windows.Forms.Label();
            this.btnPaginationNext = new System.Windows.Forms.Button();
            this.btnPaginationPrv = new System.Windows.Forms.Button();
            this.lblSearchDetails = new System.Windows.Forms.Label();
            this.lblTermDisplayTitle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.txtSimpleSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxIndexSelection.SuspendLayout();
            this.tabMultiPhraseSearch.SuspendLayout();
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
            // tabMultiPhraseSearch
            // 
            this.tabMultiPhraseSearch.Controls.Add(this.lblMPTitle);
            this.tabMultiPhraseSearch.Controls.Add(this.btnMPSaveResults);
            this.tabMultiPhraseSearch.Controls.Add(this.lblMPSearchOptions);
            this.tabMultiPhraseSearch.Controls.Add(this.lblMPPagination);
            this.tabMultiPhraseSearch.Controls.Add(this.btnMPPaginationNext);
            this.tabMultiPhraseSearch.Controls.Add(this.btnMPPaginationPrev);
            this.tabMultiPhraseSearch.Controls.Add(this.lblMPSearchInfo);
            this.tabMultiPhraseSearch.Controls.Add(this.listView2);
            this.tabMultiPhraseSearch.Controls.Add(this.btnMPSearch);
            this.tabMultiPhraseSearch.Controls.Add(this.txtBoxMPSearchInput);
            this.tabMultiPhraseSearch.Location = new System.Drawing.Point(4, 22);
            this.tabMultiPhraseSearch.Name = "tabMultiPhraseSearch";
            this.tabMultiPhraseSearch.Size = new System.Drawing.Size(1097, 790);
            this.tabMultiPhraseSearch.TabIndex = 2;
            this.tabMultiPhraseSearch.Text = "Multi-Phrase Search";
            this.tabMultiPhraseSearch.UseVisualStyleBackColor = true;
            // 
            // lblMPTitle
            // 
            this.lblMPTitle.AutoSize = true;
            this.lblMPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblMPTitle.Location = new System.Drawing.Point(89, 29);
            this.lblMPTitle.Name = "lblMPTitle";
            this.lblMPTitle.Size = new System.Drawing.Size(180, 29);
            this.lblMPTitle.TabIndex = 30;
            this.lblMPTitle.Text = "Phrase Search";
            this.lblMPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMPSaveResults
            // 
            this.btnMPSaveResults.Location = new System.Drawing.Point(15, 534);
            this.btnMPSaveResults.Name = "btnMPSaveResults";
            this.btnMPSaveResults.Size = new System.Drawing.Size(101, 23);
            this.btnMPSaveResults.TabIndex = 29;
            this.btnMPSaveResults.Text = "Save Results";
            this.btnMPSaveResults.UseVisualStyleBackColor = true;
            // 
            // lblMPSearchOptions
            // 
            this.lblMPSearchOptions.AutoSize = true;
            this.lblMPSearchOptions.Location = new System.Drawing.Point(130, 483);
            this.lblMPSearchOptions.Name = "lblMPSearchOptions";
            this.lblMPSearchOptions.Size = new System.Drawing.Size(80, 13);
            this.lblMPSearchOptions.TabIndex = 28;
            this.lblMPSearchOptions.Text = "Search Options";
            // 
            // lblMPPagination
            // 
            this.lblMPPagination.AutoSize = true;
            this.lblMPPagination.Location = new System.Drawing.Point(573, 539);
            this.lblMPPagination.Name = "lblMPPagination";
            this.lblMPPagination.Size = new System.Drawing.Size(96, 13);
            this.lblMPPagination.TabIndex = 23;
            this.lblMPPagination.Text = "Results 1..10 of 50";
            // 
            // btnMPPaginationNext
            // 
            this.btnMPPaginationNext.Location = new System.Drawing.Point(804, 534);
            this.btnMPPaginationNext.Name = "btnMPPaginationNext";
            this.btnMPPaginationNext.Size = new System.Drawing.Size(75, 23);
            this.btnMPPaginationNext.TabIndex = 22;
            this.btnMPPaginationNext.Text = "Next";
            this.btnMPPaginationNext.UseVisualStyleBackColor = true;
            // 
            // btnMPPaginationPrev
            // 
            this.btnMPPaginationPrev.Location = new System.Drawing.Point(372, 534);
            this.btnMPPaginationPrev.Name = "btnMPPaginationPrev";
            this.btnMPPaginationPrev.Size = new System.Drawing.Size(75, 23);
            this.btnMPPaginationPrev.TabIndex = 21;
            this.btnMPPaginationPrev.Text = "Previous";
            this.btnMPPaginationPrev.UseVisualStyleBackColor = true;
            this.btnMPPaginationPrev.Visible = false;
            // 
            // lblMPSearchInfo
            // 
            this.lblMPSearchInfo.AutoSize = true;
            this.lblMPSearchInfo.Location = new System.Drawing.Point(15, 154);
            this.lblMPSearchInfo.Name = "lblMPSearchInfo";
            this.lblMPSearchInfo.Size = new System.Drawing.Size(218, 13);
            this.lblMPSearchInfo.TabIndex = 18;
            this.lblMPSearchInfo.Text = "Current results are for a processed search of:";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(360, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(532, 562);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnMPSearch
            // 
            this.btnMPSearch.Location = new System.Drawing.Point(180, 110);
            this.btnMPSearch.Name = "btnMPSearch";
            this.btnMPSearch.Size = new System.Drawing.Size(174, 23);
            this.btnMPSearch.TabIndex = 16;
            this.btnMPSearch.Text = "Search";
            this.btnMPSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxMPSearchInput
            // 
            this.txtBoxMPSearchInput.Location = new System.Drawing.Point(15, 84);
            this.txtBoxMPSearchInput.Name = "txtBoxMPSearchInput";
            this.txtBoxMPSearchInput.Size = new System.Drawing.Size(339, 20);
            this.txtBoxMPSearchInput.TabIndex = 15;
            // 
            // tabSimpleSearch
            // 
            this.tabSimpleSearch.Controls.Add(this.lblIndexInformation);
            this.tabSimpleSearch.Controls.Add(this.lblIndexInfoTitle);
            this.tabSimpleSearch.Controls.Add(this.labelTermSearch);
            this.tabSimpleSearch.Controls.Add(this.lblSearchTitle);
            this.tabSimpleSearch.Controls.Add(this.btnSaveResults);
            this.tabSimpleSearch.Controls.Add(this.lblSearchOptionsTitle);
            this.tabSimpleSearch.Controls.Add(this.lblPaginationDisplay);
            this.tabSimpleSearch.Controls.Add(this.btnPaginationNext);
            this.tabSimpleSearch.Controls.Add(this.btnPaginationPrv);
            this.tabSimpleSearch.Controls.Add(this.lblSearchDetails);
            this.tabSimpleSearch.Controls.Add(this.lblTermDisplayTitle);
            this.tabSimpleSearch.Controls.Add(this.listView1);
            this.tabSimpleSearch.Controls.Add(this.btnSimpleSearch);
            this.tabSimpleSearch.Controls.Add(this.txtSimpleSearch);
            this.tabSimpleSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSimpleSearch.Name = "tabSimpleSearch";
            this.tabSimpleSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimpleSearch.Size = new System.Drawing.Size(1097, 790);
            this.tabSimpleSearch.TabIndex = 0;
            this.tabSimpleSearch.Text = "Simple Search";
            this.tabSimpleSearch.UseVisualStyleBackColor = true;
            // 
            // lblIndexInformation
            // 
            this.lblIndexInformation.AutoSize = true;
            this.lblIndexInformation.Location = new System.Drawing.Point(19, 258);
            this.lblIndexInformation.Name = "lblIndexInformation";
            this.lblIndexInformation.Size = new System.Drawing.Size(0, 13);
            this.lblIndexInformation.TabIndex = 18;
            // 
            // lblIndexInfoTitle
            // 
            this.lblIndexInfoTitle.AutoSize = true;
            this.lblIndexInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexInfoTitle.Location = new System.Drawing.Point(15, 230);
            this.lblIndexInfoTitle.Name = "lblIndexInfoTitle";
            this.lblIndexInfoTitle.Size = new System.Drawing.Size(171, 24);
            this.lblIndexInfoTitle.TabIndex = 17;
            this.lblIndexInfoTitle.Text = "Index Information";
            // 
            // labelTermSearch
            // 
            this.labelTermSearch.AutoSize = true;
            this.labelTermSearch.Location = new System.Drawing.Point(240, 154);
            this.labelTermSearch.Name = "labelTermSearch";
            this.labelTermSearch.Size = new System.Drawing.Size(0, 13);
            this.labelTermSearch.TabIndex = 16;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSearchTitle.Location = new System.Drawing.Point(83, 29);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(159, 29);
            this.lblSearchTitle.TabIndex = 15;
            this.lblSearchTitle.Text = "Term Search";
            this.lblSearchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(18, 740);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(101, 23);
            this.btnSaveResults.TabIndex = 14;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            // 
            // lblSearchOptionsTitle
            // 
            this.lblSearchOptionsTitle.AutoSize = true;
            this.lblSearchOptionsTitle.Location = new System.Drawing.Point(135, 702);
            this.lblSearchOptionsTitle.Name = "lblSearchOptionsTitle";
            this.lblSearchOptionsTitle.Size = new System.Drawing.Size(80, 13);
            this.lblSearchOptionsTitle.TabIndex = 13;
            this.lblSearchOptionsTitle.Text = "Search Options";
            // 
            // lblPaginationDisplay
            // 
            this.lblPaginationDisplay.AutoSize = true;
            this.lblPaginationDisplay.Location = new System.Drawing.Point(724, 745);
            this.lblPaginationDisplay.Name = "lblPaginationDisplay";
            this.lblPaginationDisplay.Size = new System.Drawing.Size(96, 13);
            this.lblPaginationDisplay.TabIndex = 8;
            this.lblPaginationDisplay.Text = "Results 1..10 of 50";
            this.lblPaginationDisplay.Visible = false;
            // 
            // btnPaginationNext
            // 
            this.btnPaginationNext.Location = new System.Drawing.Point(826, 740);
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
            this.btnPaginationPrv.Location = new System.Drawing.Point(643, 740);
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
            this.lblTermDisplayTitle.Location = new System.Drawing.Point(15, 154);
            this.lblTermDisplayTitle.Name = "lblTermDisplayTitle";
            this.lblTermDisplayTitle.Size = new System.Drawing.Size(218, 13);
            this.lblTermDisplayTitle.TabIndex = 3;
            this.lblTermDisplayTitle.Text = "Current results are for a processed search of:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(360, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(731, 778);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Location = new System.Drawing.Point(180, 110);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(174, 23);
            this.btnSimpleSearch.TabIndex = 1;
            this.btnSimpleSearch.Text = "Search";
            this.btnSimpleSearch.UseVisualStyleBackColor = true;
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // txtSimpleSearch
            // 
            this.txtSimpleSearch.Location = new System.Drawing.Point(15, 84);
            this.txtSimpleSearch.Name = "txtSimpleSearch";
            this.txtSimpleSearch.Size = new System.Drawing.Size(339, 20);
            this.txtSimpleSearch.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimpleSearch);
            this.tabControl1.Controls.Add(this.tabMultiPhraseSearch);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 816);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 838);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxIndexSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxIndexSelection.ResumeLayout(false);
            this.groupBoxIndexSelection.PerformLayout();
            this.tabMultiPhraseSearch.ResumeLayout(false);
            this.tabMultiPhraseSearch.PerformLayout();
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
        private System.Windows.Forms.TabPage tabMultiPhraseSearch;
        private System.Windows.Forms.Button btnMPSaveResults;
        private System.Windows.Forms.Label lblMPSearchOptions;
        private System.Windows.Forms.Label lblMPPagination;
        private System.Windows.Forms.Button btnMPPaginationNext;
        private System.Windows.Forms.Button btnMPPaginationPrev;
        private System.Windows.Forms.Label lblMPSearchInfo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnMPSearch;
        private System.Windows.Forms.TextBox txtBoxMPSearchInput;
        private System.Windows.Forms.TabPage tabSimpleSearch;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Label lblSearchOptionsTitle;
        private System.Windows.Forms.Label lblPaginationDisplay;
        private System.Windows.Forms.Button btnPaginationNext;
        private System.Windows.Forms.Button btnPaginationPrv;
        private System.Windows.Forms.Label lblSearchDetails;
        private System.Windows.Forms.Label lblTermDisplayTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSimpleSearch;
        private System.Windows.Forms.TextBox txtSimpleSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblMPTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Label labelTermSearch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label lblIndexLocation;
        private System.Windows.Forms.Label lblCollectionLocation;
        private System.Windows.Forms.Label lblIndexInformation;
        private System.Windows.Forms.Label lblIndexInfoTitle;
    }
}

