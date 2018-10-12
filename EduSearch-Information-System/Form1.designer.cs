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
            this.btnIndexAccept = new System.Windows.Forms.Button();
            this.lblIndexFeedback = new System.Windows.Forms.Label();
            this.lblCollectionLoc = new System.Windows.Forms.Label();
            this.btnCollectionLoc = new System.Windows.Forms.Button();
            this.lblIndexLoc = new System.Windows.Forms.Label();
            this.btnIndexLoc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabMultiPhraseSearch = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabSimpleSearch = new System.Windows.Forms.TabPage();
            this.labelTermSearch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.groupBoxIndexSelection.SuspendLayout();
            this.tabMultiPhraseSearch.SuspendLayout();
            this.tabSimpleSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnIndexAccept.Click += new System.EventHandler(this.btnIndexAccept_Click);
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
            // 
            // btnCollectionLoc
            // 
            this.btnCollectionLoc.Location = new System.Drawing.Point(6, 35);
            this.btnCollectionLoc.Name = "btnCollectionLoc";
            this.btnCollectionLoc.Size = new System.Drawing.Size(113, 23);
            this.btnCollectionLoc.TabIndex = 4;
            this.btnCollectionLoc.Text = "Browse";
            this.btnCollectionLoc.UseVisualStyleBackColor = true;
            // 
            // lblIndexLoc
            // 
            this.lblIndexLoc.AutoSize = true;
            this.lblIndexLoc.Location = new System.Drawing.Point(279, 16);
            this.lblIndexLoc.Name = "lblIndexLoc";
            this.lblIndexLoc.Size = new System.Drawing.Size(150, 13);
            this.lblIndexLoc.TabIndex = 6;
            this.lblIndexLoc.Text = "Plesase Select Index Location";
            // 
            // btnIndexLoc
            // 
            this.btnIndexLoc.Location = new System.Drawing.Point(282, 35);
            this.btnIndexLoc.Name = "btnIndexLoc";
            this.btnIndexLoc.Size = new System.Drawing.Size(113, 23);
            this.btnIndexLoc.TabIndex = 3;
            this.btnIndexLoc.Text = "Browse";
            this.btnIndexLoc.UseVisualStyleBackColor = true;
            // 
            // tabMultiPhraseSearch
            // 
            this.tabMultiPhraseSearch.Controls.Add(this.label10);
            this.tabMultiPhraseSearch.Controls.Add(this.button1);
            this.tabMultiPhraseSearch.Controls.Add(this.label1);
            this.tabMultiPhraseSearch.Controls.Add(this.label2);
            this.tabMultiPhraseSearch.Controls.Add(this.label3);
            this.tabMultiPhraseSearch.Controls.Add(this.label4);
            this.tabMultiPhraseSearch.Controls.Add(this.label5);
            this.tabMultiPhraseSearch.Controls.Add(this.label6);
            this.tabMultiPhraseSearch.Controls.Add(this.button2);
            this.tabMultiPhraseSearch.Controls.Add(this.button3);
            this.tabMultiPhraseSearch.Controls.Add(this.label7);
            this.tabMultiPhraseSearch.Controls.Add(this.label8);
            this.tabMultiPhraseSearch.Controls.Add(this.label9);
            this.tabMultiPhraseSearch.Controls.Add(this.listView2);
            this.tabMultiPhraseSearch.Controls.Add(this.button4);
            this.tabMultiPhraseSearch.Controls.Add(this.textBox1);
            this.tabMultiPhraseSearch.Location = new System.Drawing.Point(4, 22);
            this.tabMultiPhraseSearch.Name = "tabMultiPhraseSearch";
            this.tabMultiPhraseSearch.Size = new System.Drawing.Size(903, 574);
            this.tabMultiPhraseSearch.TabIndex = 2;
            this.tabMultiPhraseSearch.Text = "Multi-Phrase Search";
            this.tabMultiPhraseSearch.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label10.Location = new System.Drawing.Point(89, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "Phrase Search";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save Results";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Abstract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bibliographic Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Results 1..10 of 50";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "No search submitted";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Current results are for a processed search of:";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(360, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(532, 562);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 15;
            // 
            // tabSimpleSearch
            // 
            this.tabSimpleSearch.Controls.Add(this.labelTermSearch);
            this.tabSimpleSearch.Controls.Add(this.label11);
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
            // labelTermSearch
            // 
            this.labelTermSearch.AutoSize = true;
            this.labelTermSearch.Location = new System.Drawing.Point(240, 154);
            this.labelTermSearch.Name = "labelTermSearch";
            this.labelTermSearch.Size = new System.Drawing.Size(0, 13);
            this.labelTermSearch.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label11.Location = new System.Drawing.Point(83, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "Term Search";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
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
            this.Controls.Add(this.groupBoxIndexSelection);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTermSearch;
    }
}

