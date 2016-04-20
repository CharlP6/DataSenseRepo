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
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.btnColour = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lstGraph = new System.Windows.Forms.ListBox();
            this.lstDocStats = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedDocNum = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.customPanel1 = new DataSense.CustomPanel();
            this.panelADV = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTypeFilter = new System.Windows.Forms.ComboBox();
            this.cmbDiscFilter = new System.Windows.Forms.ComboBox();
            this.cmbCoyFilter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilterAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkStatusFilter = new System.Windows.Forms.CheckBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.radSortAge = new System.Windows.Forms.RadioButton();
            this.radSortName = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterInclude = new System.Windows.Forms.TextBox();
            this.txtFilterExclude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDocList = new DataSense.BetterListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.panelADV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.lstStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStatus.DisplayMember = "Status";
            this.lstStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.IntegralHeight = false;
            this.lstStatus.Location = new System.Drawing.Point(1128, 29);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstStatus.Size = new System.Drawing.Size(175, 356);
            this.lstStatus.TabIndex = 7;
            this.lstStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstStatus_DrawItem);
            // 
            // btnColour
            // 
            this.btnColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColour.BackColor = System.Drawing.SystemColors.Control;
            this.btnColour.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColour.Location = new System.Drawing.Point(1280, 3);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(23, 23);
            this.btnColour.TabIndex = 8;
            this.btnColour.UseVisualStyleBackColor = false;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // lstGraph
            // 
            this.lstGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGraph.BackColor = System.Drawing.Color.Gray;
            this.lstGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGraph.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstGraph.FormattingEnabled = true;
            this.lstGraph.HorizontalScrollbar = true;
            this.lstGraph.IntegralHeight = false;
            this.lstGraph.ItemHeight = 6;
            this.lstGraph.Location = new System.Drawing.Point(1, 29);
            this.lstGraph.Name = "lstGraph";
            this.lstGraph.Size = new System.Drawing.Size(882, 377);
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
            this.lstDocStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDocStats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDocStats.FormattingEnabled = true;
            this.lstDocStats.HorizontalScrollbar = true;
            this.lstDocStats.IntegralHeight = false;
            this.lstDocStats.Location = new System.Drawing.Point(3, 29);
            this.lstDocStats.Name = "lstDocStats";
            this.lstDocStats.Size = new System.Drawing.Size(468, 377);
            this.lstDocStats.TabIndex = 12;
            this.lstDocStats.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lstGraph);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSelectedDocNum);
            this.splitContainer1.Panel2.Controls.Add(this.lstDocStats);
            this.splitContainer1.Size = new System.Drawing.Size(1319, 411);
            this.splitContainer1.SplitterDistance = 890;
            this.splitContainer1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status Timeline Visualisation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedDocNum
            // 
            this.lblSelectedDocNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedDocNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDocNum.Location = new System.Drawing.Point(3, 3);
            this.lblSelectedDocNum.Name = "lblSelectedDocNum";
            this.lblSelectedDocNum.Size = new System.Drawing.Size(468, 23);
            this.lblSelectedDocNum.TabIndex = 13;
            this.lblSelectedDocNum.Text = "Selected document";
            this.lblSelectedDocNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.customPanel1);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.lstDocList);
            this.splitContainer2.Panel1.Controls.Add(this.btnColour);
            this.splitContainer2.Panel1.Controls.Add(this.lstStatus);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1319, 807);
            this.splitContainer2.SplitterDistance = 392;
            this.splitContainer2.TabIndex = 14;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BorderColour = System.Drawing.Color.LightGray;
            this.customPanel1.Controls.Add(this.panelADV);
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.radSortAge);
            this.customPanel1.Controls.Add(this.radSortName);
            this.customPanel1.Controls.Add(this.checkBox1);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.txtFilterInclude);
            this.customPanel1.Controls.Add(this.txtFilterExclude);
            this.customPanel1.Location = new System.Drawing.Point(867, 29);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(255, 356);
            this.customPanel1.TabIndex = 12;
            // 
            // panelADV
            // 
            this.panelADV.Controls.Add(this.label11);
            this.panelADV.Controls.Add(this.label10);
            this.panelADV.Controls.Add(this.label9);
            this.panelADV.Controls.Add(this.cmbTypeFilter);
            this.panelADV.Controls.Add(this.cmbDiscFilter);
            this.panelADV.Controls.Add(this.cmbCoyFilter);
            this.panelADV.Enabled = false;
            this.panelADV.Location = new System.Drawing.Point(3, 105);
            this.panelADV.Name = "panelADV";
            this.panelADV.Size = new System.Drawing.Size(249, 85);
            this.panelADV.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Filter for document type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Filter for discipline:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Filter for company:";
            // 
            // cmbTypeFilter
            // 
            this.cmbTypeFilter.FormattingEnabled = true;
            this.cmbTypeFilter.Location = new System.Drawing.Point(150, 57);
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            this.cmbTypeFilter.Size = new System.Drawing.Size(96, 21);
            this.cmbTypeFilter.Sorted = true;
            this.cmbTypeFilter.TabIndex = 2;
            this.cmbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTypeFilter_SelectedIndexChanged);
            // 
            // cmbDiscFilter
            // 
            this.cmbDiscFilter.FormattingEnabled = true;
            this.cmbDiscFilter.Location = new System.Drawing.Point(150, 30);
            this.cmbDiscFilter.Name = "cmbDiscFilter";
            this.cmbDiscFilter.Size = new System.Drawing.Size(96, 21);
            this.cmbDiscFilter.Sorted = true;
            this.cmbDiscFilter.TabIndex = 1;
            this.cmbDiscFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDiscFilter_SelectedIndexChanged);
            // 
            // cmbCoyFilter
            // 
            this.cmbCoyFilter.FormattingEnabled = true;
            this.cmbCoyFilter.Location = new System.Drawing.Point(150, 3);
            this.cmbCoyFilter.Name = "cmbCoyFilter";
            this.cmbCoyFilter.Size = new System.Drawing.Size(96, 21);
            this.cmbCoyFilter.Sorted = true;
            this.cmbCoyFilter.TabIndex = 0;
            this.cmbCoyFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCoyFilter_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFilterAge);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkStatusFilter);
            this.panel1.Controls.Add(this.cmbStatusFilter);
            this.panel1.Location = new System.Drawing.Point(3, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 63);
            this.panel1.TabIndex = 18;
            // 
            // txtFilterAge
            // 
            this.txtFilterAge.Location = new System.Drawing.Point(150, 34);
            this.txtFilterAge.Name = "txtFilterAge";
            this.txtFilterAge.Size = new System.Drawing.Size(54, 20);
            this.txtFilterAge.TabIndex = 3;
            this.txtFilterAge.TextChanged += new System.EventHandler(this.txtFilterAge_TextChanged);
            this.txtFilterAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterAge_KeyDown);
            this.txtFilterAge.Leave += new System.EventHandler(this.txtFilterAge_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "With status age greater than:";
            // 
            // chkStatusFilter
            // 
            this.chkStatusFilter.AutoSize = true;
            this.chkStatusFilter.Location = new System.Drawing.Point(3, 7);
            this.chkStatusFilter.Name = "chkStatusFilter";
            this.chkStatusFilter.Size = new System.Drawing.Size(110, 17);
            this.chkStatusFilter.TabIndex = 1;
            this.chkStatusFilter.Text = "Filter latest status:";
            this.chkStatusFilter.UseVisualStyleBackColor = true;
            this.chkStatusFilter.CheckedChanged += new System.EventHandler(this.chkStatusFilter_CheckedChanged);
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(124, 5);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusFilter.TabIndex = 0;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // radSortAge
            // 
            this.radSortAge.AutoSize = true;
            this.radSortAge.Location = new System.Drawing.Point(6, 220);
            this.radSortAge.Name = "radSortAge";
            this.radSortAge.Size = new System.Drawing.Size(129, 17);
            this.radSortAge.TabIndex = 17;
            this.radSortAge.Text = "Sort by document age";
            this.radSortAge.UseVisualStyleBackColor = true;
            this.radSortAge.CheckedChanged += new System.EventHandler(this.radSortAge_CheckedChanged);
            // 
            // radSortName
            // 
            this.radSortName.AutoSize = true;
            this.radSortName.Checked = true;
            this.radSortName.Location = new System.Drawing.Point(6, 196);
            this.radSortName.Name = "radSortName";
            this.radSortName.Size = new System.Drawing.Size(146, 17);
            this.radSortName.TabIndex = 16;
            this.radSortName.TabStop = true;
            this.radSortName.Text = "Sort by document number";
            this.radSortName.UseVisualStyleBackColor = true;
            this.radSortName.CheckedChanged += new System.EventHandler(this.radSortName_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show only: KIPP-XX1-XXXX-XX-XXXX-XXX";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter to Include:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter to Exclude:";
            // 
            // txtFilterInclude
            // 
            this.txtFilterInclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInclude.Location = new System.Drawing.Point(91, 13);
            this.txtFilterInclude.Name = "txtFilterInclude";
            this.txtFilterInclude.Size = new System.Drawing.Size(161, 20);
            this.txtFilterInclude.TabIndex = 10;
            this.txtFilterInclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFilterInclude.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtFilterExclude
            // 
            this.txtFilterExclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterExclude.Location = new System.Drawing.Point(91, 42);
            this.txtFilterExclude.Name = "txtFilterExclude";
            this.txtFilterExclude.Size = new System.Drawing.Size(161, 20);
            this.txtFilterExclude.TabIndex = 11;
            this.txtFilterExclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.txtFilterExclude.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(867, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort and Filter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(794, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Document List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDocList
            // 
            this.lstDocList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDocList.FormattingEnabled = true;
            this.lstDocList.HorizontalScrollbar = true;
            this.lstDocList.IntegralHeight = false;
            this.lstDocList.Location = new System.Drawing.Point(1, 29);
            this.lstDocList.Name = "lstDocList";
            this.lstDocList.Size = new System.Drawing.Size(860, 356);
            this.lstDocList.TabIndex = 6;
            this.lstDocList.Scroll += new DataSense.BetterListBox.BetterListBoxScrollDelegate(this.betterListBox1_Scroll);
            this.lstDocList.SelectedIndexChanged += new System.EventHandler(this.betterListBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1128, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status Colours";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analyzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCSVsToolStripMenuItem,
            this.clearDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCSVsToolStripMenuItem
            // 
            this.openCSVsToolStripMenuItem.Name = "openCSVsToolStripMenuItem";
            this.openCSVsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openCSVsToolStripMenuItem.Text = "Open CSVs";
            this.openCSVsToolStripMenuItem.Click += new System.EventHandler(this.openCSVsToolStripMenuItem_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clearDataToolStripMenuItem.Text = "Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.Enabled = false;
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            this.analyzeToolStripMenuItem.Click += new System.EventHandler(this.analyzeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 831);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DataSense";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panelADV.ResumeLayout(false);
            this.panelADV.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCSVsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterInclude;
        private System.Windows.Forms.TextBox txtFilterExclude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radSortAge;
        private System.Windows.Forms.RadioButton radSortName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilterAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Panel panelADV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTypeFilter;
        private System.Windows.Forms.ComboBox cmbDiscFilter;
        private System.Windows.Forms.ComboBox cmbCoyFilter;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
    }
}

