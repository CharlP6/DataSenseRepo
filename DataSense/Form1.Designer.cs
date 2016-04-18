namespace DataSense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.chHasHeaders = new System.Windows.Forms.CheckBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.btnColour = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lstGraph = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lstDocStats = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSelectedDocNum = new System.Windows.Forms.Label();
            this.lstDocList = new DataSense.BetterListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstDocList);
            this.groupBox1.Location = new System.Drawing.Point(140, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Headers";
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.Location = new System.Drawing.Point(12, 12);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCSV.TabIndex = 2;
            this.btnLoadCSV.Text = "Load CSV";
            this.btnLoadCSV.UseVisualStyleBackColor = true;
            this.btnLoadCSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // chHasHeaders
            // 
            this.chHasHeaders.AutoSize = true;
            this.chHasHeaders.Location = new System.Drawing.Point(12, 41);
            this.chHasHeaders.Name = "chHasHeaders";
            this.chHasHeaders.Size = new System.Drawing.Size(112, 17);
            this.chHasHeaders.TabIndex = 3;
            this.chHasHeaders.Text = "CSV Has Headers";
            this.chHasHeaders.UseVisualStyleBackColor = true;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.Filter = "CSV file|*.csv";
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(12, 98);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 4;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // lstStatus
            // 
            this.lstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(1020, 40);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstStatus.Size = new System.Drawing.Size(163, 251);
            this.lstStatus.TabIndex = 7;
            this.lstStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // btnColour
            // 
            this.btnColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColour.Location = new System.Drawing.Point(1108, 12);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(75, 23);
            this.btnColour.TabIndex = 8;
            this.btnColour.Text = "Colours";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // lstGraph
            // 
            this.lstGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGraph.BackColor = System.Drawing.Color.Gray;
            this.lstGraph.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstGraph.FormattingEnabled = true;
            this.lstGraph.HorizontalScrollbar = true;
            this.lstGraph.ItemHeight = 6;
            this.lstGraph.Location = new System.Drawing.Point(3, 3);
            this.lstGraph.Name = "lstGraph";
            this.lstGraph.Size = new System.Drawing.Size(778, 316);
            this.lstGraph.TabIndex = 9;
            this.lstGraph.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox2_DrawItem);
            this.lstGraph.SelectedIndexChanged += new System.EventHandler(this.lstGraph_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lstDocStats
            // 
            this.lstDocStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocStats.BackColor = System.Drawing.Color.White;
            this.lstDocStats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDocStats.FormattingEnabled = true;
            this.lstDocStats.Location = new System.Drawing.Point(3, 29);
            this.lstDocStats.Name = "lstDocStats";
            this.lstDocStats.Size = new System.Drawing.Size(377, 290);
            this.lstDocStats.TabIndex = 12;
            this.lstDocStats.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem_1);
            this.lstDocStats.SelectedIndexChanged += new System.EventHandler(this.lstDocStats_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 297);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstGraph);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSelectedDocNum);
            this.splitContainer1.Panel2.Controls.Add(this.lstDocStats);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 331);
            this.splitContainer1.SplitterDistance = 784;
            this.splitContainer1.TabIndex = 13;
            // 
            // lblSelectedDocNum
            // 
            this.lblSelectedDocNum.AutoSize = true;
            this.lblSelectedDocNum.Location = new System.Drawing.Point(4, 10);
            this.lblSelectedDocNum.Name = "lblSelectedDocNum";
            this.lblSelectedDocNum.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedDocNum.TabIndex = 13;
            // 
            // lstDocList
            // 
            this.lstDocList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocList.FormattingEnabled = true;
            this.lstDocList.Location = new System.Drawing.Point(6, 19);
            this.lstDocList.Name = "lstDocList";
            this.lstDocList.Size = new System.Drawing.Size(862, 251);
            this.lstDocList.TabIndex = 6;
            this.lstDocList.Scroll += new DataSense.BetterListBox.BetterListBoxScrollDelegate(this.betterListBox1_Scroll);
            this.lstDocList.SelectedIndexChanged += new System.EventHandler(this.betterListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.chHasHeaders);
            this.Controls.Add(this.btnLoadCSV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.CheckBox chHasHeaders;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnAnalyse;
        private BetterListBox lstDocList;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lstGraph;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lstDocStats;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSelectedDocNum;
    }
}

