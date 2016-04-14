﻿namespace DataSense
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
            this.betterListBox1 = new DataSense.BetterListBox();
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.chHasHeaders = new System.Windows.Forms.CheckBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.betterListBox1);
            this.groupBox1.Location = new System.Drawing.Point(140, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Headers";
            // 
            // betterListBox1
            // 
            this.betterListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betterListBox1.FormattingEnabled = true;
            this.betterListBox1.Location = new System.Drawing.Point(6, 19);
            this.betterListBox1.Name = "betterListBox1";
            this.betterListBox1.Size = new System.Drawing.Size(336, 212);
            this.betterListBox1.TabIndex = 6;
            this.betterListBox1.Scroll += new DataSense.BetterListBox.BetterListBoxScrollDelegate(this.betterListBox1_Scroll);
            this.betterListBox1.SelectedIndexChanged += new System.EventHandler(this.betterListBox1_SelectedIndexChanged);
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
            this.btnAnalyse.Location = new System.Drawing.Point(12, 64);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 4;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.chHasHeaders);
            this.Controls.Add(this.btnLoadCSV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.CheckBox chHasHeaders;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button button1;
        private BetterListBox betterListBox1;
    }
}
