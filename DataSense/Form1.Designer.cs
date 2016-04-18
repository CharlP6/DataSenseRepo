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
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.chHasHeaders = new System.Windows.Forms.CheckBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.btnColour = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lstGraph = new System.Windows.Forms.ListBox();
            this.lstDocStats = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSelectedDocNum = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstDocList = new DataSense.BetterListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.Location = new System.Drawing.Point(12, 12);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCSV.TabIndex = 2;
            this.btnLoadCSV.Text = "Load CSV";
            this.btnLoadCSV.UseVisualStyleBackColor = true;
            this.btnLoadCSV.Click += new System.EventHandler(this.btnLoadCSV_Click);
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
            this.chHasHeaders.Visible = false;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.Filter = "CSV file|*.csv";
            this.OFD.Multiselect = true;
            // 
            // lstStatus
            // 
            this.lstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStatus.DisplayMember = "Status";
            this.lstStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(1174, 41);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstStatus.Size = new System.Drawing.Size(175, 290);
            this.lstStatus.TabIndex = 7;
            this.lstStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstStatus_DrawItem);
            // 
            // btnColour
            // 
            this.btnColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColour.Location = new System.Drawing.Point(1274, 12);
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
            this.lstGraph.Size = new System.Drawing.Size(899, 448);
            this.lstGraph.TabIndex = 9;
            this.lstGraph.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstGraph_DrawItem);
            this.lstGraph.SelectedIndexChanged += new System.EventHandler(this.lstGraph_SelectedIndexChanged);
            // 
            // lstDocStats
            // 
            this.lstDocStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocStats.BackColor = System.Drawing.Color.White;
            this.lstDocStats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDocStats.FormattingEnabled = true;
            this.lstDocStats.HorizontalScrollbar = true;
            this.lstDocStats.Location = new System.Drawing.Point(3, 29);
            this.lstDocStats.Name = "lstDocStats";
            this.lstDocStats.Size = new System.Drawing.Size(436, 420);
            this.lstDocStats.TabIndex = 12;
            this.lstDocStats.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(7, 3);
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
            this.splitContainer1.Size = new System.Drawing.Size(1351, 461);
            this.splitContainer1.SplitterDistance = 905;
            this.splitContainer1.TabIndex = 13;
            // 
            // lblSelectedDocNum
            // 
            this.lblSelectedDocNum.AutoSize = true;
            this.lblSelectedDocNum.Location = new System.Drawing.Point(4, 10);
            this.lblSelectedDocNum.Name = "lblSelectedDocNum";
            this.lblSelectedDocNum.Size = new System.Drawing.Size(70, 13);
            this.lblSelectedDocNum.TabIndex = 13;
            this.lblSelectedDocNum.Text = "Selected doc";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstDocList);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.btnAnalyze);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadCSV);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.chHasHeaders);
            this.splitContainer2.Panel1.Controls.Add(this.btnColour);
            this.splitContainer2.Panel1.Controls.Add(this.lstStatus);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1363, 811);
            this.splitContainer2.SplitterDistance = 338;
            this.splitContainer2.TabIndex = 14;
            // 
            // lstDocList
            // 
            this.lstDocList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocList.FormattingEnabled = true;
            this.lstDocList.Location = new System.Drawing.Point(143, 15);
            this.lstDocList.Name = "lstDocList";
            this.lstDocList.Size = new System.Drawing.Size(1025, 316);
            this.lstDocList.TabIndex = 6;
            this.lstDocList.Scroll += new DataSense.BetterListBox.BetterListBoxScrollDelegate(this.betterListBox1_Scroll);
            this.lstDocList.SelectedIndexChanged += new System.EventHandler(this.betterListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter to Exclude:";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(12, 86);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 9;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter to Include:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 814);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.Text = "DataSense";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.CheckBox chHasHeaders;
        private System.Windows.Forms.OpenFileDialog OFD;
        private BetterListBox lstDocList;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lstGraph;
        private System.Windows.Forms.ListBox lstDocStats;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSelectedDocNum;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

