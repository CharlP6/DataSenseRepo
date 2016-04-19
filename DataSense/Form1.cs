﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

using ExtensionMethods;

namespace DataSense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Headers = new List<string>();

        List<DocEntry> DocEntries = new List<DocEntry>();

        List<sDocument> ConDocs = new List<sDocument>();

        List<sDocument> FilteredDocs = new List<sDocument>();

        List<ColourStatus> StatusColours = new List<ColourStatus>();

        List<sStatus> SelectedStatus = new List<sStatus>();

        private void LoadCSV()
        {
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in OFD.FileNames)
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite))
                    {
                        using (TextFieldParser parser = new TextFieldParser(fs))
                        {
                            parser.TextFieldType = FieldType.Delimited;
                            parser.SetDelimiters(",");

                            string[] fields = parser.ReadFields();

                            while (!parser.EndOfData)
                            {
                                fields = parser.ReadFields();

                                DateTime ActDate;

                                DateTime.TryParse(fields[6], out ActDate);
                                DocEntry DE = new DocEntry
                                {
                                    DocNumber = fields[0],
                                    DocTitle = fields[1],
                                    RevisionNum = fields[2],
                                    VersionNum = fields[3],
                                    DocStatus = fields[4],
                                    RevStatus = fields[5],
                                    ActionDate = ActDate,
                                    Action = fields[7]
                                };

                                DocEntries.Add(DE);
                            }
                        }
                    }
                }
            }
        }


        void AnalyzeDocs()
        {
            var GroupedDocs = DocEntries.GroupBy(g => g.DocNumber); //Group document list by doc number

            foreach (var Doc in GroupedDocs) //Loop through each group
            {
                DateTime dTemp = DateTime.Parse("0001/01/01"); //Temp Variable for loop logic

                sDocument ConsolidatedDoc = new sDocument(); //Class containing all document revision info
                sStatus ConsolidatedStatus = new sStatus(); //Helper to contain revision lists

                int sAge = 0;
                string act = "";

                foreach (DocEntry item in Doc.OrderBy(o => o.ActionDate)) //Loop through each entry in current group
                {
                    if (dTemp != DateTime.Parse("0001/01/01")) //If date is valid
                    {
                        sAge = (item.ActionDate - dTemp).Days; //Subtract previous date from current entry date
                    }
                    else
                    {
                        sAge = 0;
                    }

                    dTemp = item.ActionDate; //Set temp date to current date
                    
                    if (item.Action == "")
                    {
                        act = item.RevStatus;
                    }
                    else
                    {
                        act = item.Action;
                    }

                    ConsolidatedStatus.Date = dTemp; //set status helper date

                    ConsolidatedDoc.Status.Add(new sStatus
                    {
                        Age = sAge,
                        RevStatus = item.RevStatus,
                        RevisionNum = item.RevisionNum,
                        Action = act,
                        DocStatus = item.DocStatus,
                        Date = item.ActionDate
                    });

                    ConsolidatedDoc.DocTitle = item.DocTitle;
                }

                if (dTemp != DateTime.Parse("0001/01/01") && dTemp <= DateTime.Today) //Subtract last date from today
                {
                    sAge = (DateTime.Today - dTemp).Days;
                }
                else
                {
                    sAge = 0;
                }

                ConsolidatedStatus.Age = sAge;
                ConsolidatedStatus.Action = act;

                ConsolidatedDoc.Status.Add(ConsolidatedStatus);
                ConsolidatedDoc.DocNumber = Doc.Key;

                ConDocs.Add(ConsolidatedDoc);
            }

            FilteredDocs = ConDocs.OrderBy(o => o.DocNumber).ToList();

            SetColours();

            BindDocList();
        }

        void SetColours()
        {
            StatusColours.Clear();

            string[] Stats = { "CGC", "G5", "WP", "FOR REVIEW", "PLANNED" };
            Color[] Cols = { Color.Green, Color.Blue, Color.Red, Color.Cyan, Color.White };

            List<string> uniqueStatus = DocEntries.Select(d => d.RevStatus).Distinct().ToList();

            for (int i = 0; i < Stats.Count(); i++)
            {
                StatusColours.AddRange(uniqueStatus.Where(w => w.ToUpper().Contains(Stats[i])).Select(s => new ColourStatus(s, Cols[i])));
            }

            StatusColours.AddRange(uniqueStatus.Where(w => !(w.ToUpper().ContainsAny(Stats))).Select(s => new ColourStatus(s, Color.Silver)));

            StatusColours.Add(new ColourStatus { Status = "TRA", Colour = Color.Yellow });

            StatusColours = StatusColours.OrderBy(o => o.Status).ToList();

            BindColourList();
        }

        #region Bind Listbox Data

        private void BindColourList()
        {
            lstStatus.DataSource = null;
            lstStatus.DataSource = StatusColours.ToList();
            lstStatus.DisplayMember = "Status";
            lstStatus.SelectedItems.Clear();
        }

        private void BindDocList()
        {
            lstGraph.DataSource = null;
            lstGraph.DataSource = FilteredDocs.ToList();
            lstGraph.SelectedItems.Clear();

            lstDocList.DataSource = null;
            lstDocList.DataSource = FilteredDocs.ToList();//.Select(s => s.DocNumber + ": " + string.Join(", ", s.Status.Select(ss => ss.Action))).ToList();
            lstDocList.DisplayMember = "StatusList";
            lstDocList.SelectedItems.Clear();

        }

        private void BindStatusListBox()
        {
            lstDocStats.HorizontalExtent = 0;
            lstDocStats.DataSource = null;
            lstDocStats.DataSource = SelectedStatus.Select(s => s.Age + " days\t" + s.Date.ToShortDateString() + "\t" + s.Action + "\t" + s.RevStatus + "\t" + s.RevisionNum + " - " + s.DocStatus).ToList();
        }

        #endregion

        private void betterListBox1_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void betterListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDocList.TopIndex = lstDocList.SelectedIndex;
            lstGraph.SelectedIndex = lstDocList.SelectedIndex;
            if (lstDocList.SelectedIndex >= 0)
            {
                lblSelectedDocNum.Text = FilteredDocs[lstDocList.SelectedIndex].DocNumber + " - Total days in circulation: " + SelectedStatus.Sum(u => u.Age);
                BindStatusListBox();
            }

        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            if (lstStatus.SelectedIndices.Count > 0)
            {
                if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (int i in lstStatus.SelectedIndices)
                    {
                        StatusColours[i].Colour = colorDialog1.Color;
                    }
                    BindColourList();
                    lstDocStats.Refresh();
                    lstGraph.Refresh();
                }
            }

        }

        private void lstStatus_DrawItem(object sender, DrawItemEventArgs e)
        {

            e.DrawBackground();

            using (Brush myBrush = new SolidBrush(StatusColours[e.Index].Colour))
            {

                int y = (e.Index - lstStatus.TopIndex) * lstStatus.ItemHeight;

                int x = (int)e.Graphics.MeasureString(lstStatus.Items[e.Index].ToString(), e.Font).Width;

                e.Graphics.FillRectangle(myBrush, lstStatus.Width - e.Bounds.Height - 20, y + 1, e.Bounds.Height - 2, e.Bounds.Height - 2);

            }
            using (Brush p = new SolidBrush(lstStatus.ForeColor))
            {
                e.Graphics.DrawString((lstStatus.Items[e.Index] as ColourStatus).Status,
                e.Font, p, e.Bounds, StringFormat.GenericDefault);
            }

            e.DrawFocusRectangle();
        }

        private void lstGraph_DrawItem(object sender, DrawItemEventArgs e)
        {

            int width = 4;

            e.DrawBackground();

            using (Brush p = new SolidBrush(lstStatus.ForeColor))
            {
                int x = 0;
                int y = (e.Index - lstGraph.TopIndex) * lstGraph.ItemHeight + (lstGraph.ItemHeight / 2);

                foreach (sStatus stat in (lstGraph.Items[e.Index] as sDocument).Status)
                {
                    foreach (ColourStatus SC in StatusColours)
                    {
                        if (stat.Action.ToUpper() == (SC.Status.ToUpper()))
                        {
                            e.Graphics.DrawLine(new Pen(SC.Colour, lstGraph.ItemHeight - 3), x, y, x + stat.Age * width, y);
                            break;
                        }
                        else if (stat.Action.ToUpper().Contains("TRA") && SC.Status == "TRA")
                        {
                            e.Graphics.DrawLine(new Pen(SC.Colour, lstGraph.ItemHeight - 3), x, y, x + stat.Age * width, y);
                            break;
                        }
                    }
                    x += stat.Age * width;
                }
            }
            lstGraph.HorizontalExtent = lstGraph.Items.Cast<sDocument>().Max(m => m.Status.Sum(u => u.Age)) * width + 10;
            e.DrawFocusRectangle();
        }



        private void lstGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDocList.Items.Count > 0 && lstGraph.SelectedIndex >= 0)
            {
                SelectedStatus = (lstGraph.SelectedItem as sDocument).Status;
                lstDocList.SelectedIndex = lstGraph.SelectedIndex;
            }


        }


        private void listBox1_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            int width = 4;

            int y = (e.Index - lstDocStats.TopIndex) * lstDocStats.ItemHeight;

            string act = SelectedStatus[e.Index].Action;

            Color bColour;

            
            if (StatusColours.Count > 0)
            {

                if (act != "")
                {
                    bColour = StatusColours.Skip(1).Where(w => act.ToUpper().Contains(w.Status.ToUpper())
                    ).Select(s => s.Colour).First();
                }
                else
                {
                    bColour = StatusColours.Where(w => act.ToUpper().Contains(w.Status.ToUpper())
                    ).Select(s => s.Colour).First();
                }


                using (Brush p = new SolidBrush(bColour))
                {
                    if (SelectedStatus[e.Index].Age > 0)
                    {
                        e.Graphics.FillRectangle(p, 0, y, SelectedStatus[e.Index].Age * width, lstDocStats.ItemHeight);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(p, 0, y, width, lstDocStats.ItemHeight);
                    }
                }

                using (Brush p = new SolidBrush(lstDocStats.ForeColor))
                {

                    float t1 = SelectedStatus.Max(m => e.Graphics.MeasureString(m.Age + " Days", lstDocStats.Font).Width);
                    float t2 = SelectedStatus.Max(m => e.Graphics.MeasureString(m.Date.ToShortDateString(), lstDocStats.Font).Width);
                    float t3 = SelectedStatus.Max(m => e.Graphics.MeasureString(m.Action, lstDocStats.Font).Width);
                    float t4 = SelectedStatus.Max(m => e.Graphics.MeasureString(m.RevStatus, lstDocStats.Font).Width);

                    float tab = 25;

                    float[] tabs = { t1 + tab, t2 + tab, t3 + tab, t4 + tab, tab, tab, tab, tab, tab, tab, tab };

                    StringFormat sf = new StringFormat();

                    sf.SetTabStops(0, tabs);

                    e.Graphics.DrawString(lstDocStats.Items[e.Index].ToString(),
                    e.Font, p, e.Bounds, sf);

                    float textLength = e.Graphics.MeasureString(lstDocStats.Items[e.Index].ToString(), e.Font, 0, sf).Width;

                    if (lstDocStats.HorizontalExtent < textLength )
                    {
                        lstDocStats.HorizontalExtent = (int)textLength+5;
                    }
                }
            }
            if (lstDocStats.HorizontalExtent < SelectedStatus.Max(m => m.Age*width))
            {
                lstDocStats.HorizontalExtent = SelectedStatus.Max(m => m.Age * width)+5;
            }
        }

        #region Filter Docs

        private void textBox1_Leave(object sender, EventArgs e)
        {
            filterDocs();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            filterDocs();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filterDocs();
        }

        private void radSortName_CheckedChanged(object sender, EventArgs e)
        {
            filterDocs();
        }

        private void radSortAge_CheckedChanged(object sender, EventArgs e)
        {
            filterDocs();
        }

        void filterDocs()
        {

            Regex rgxFormat;

            if (checkBox1.Checked)
            {
                rgxFormat = new Regex(@"KIPP-\w{3}-\w{4}-\w{2}-\w{3}-");
            }
            else
            {
                rgxFormat = new Regex("");
            }

            try
            {
                if (textBox2.Text != "")
                {
                    Regex rgx = new Regex("(?i)" + textBox1.Text);
                    Regex rgx2 = new Regex("(?i)" + textBox2.Text);
                    if (radSortName.Checked)
                    {
                        FilteredDocs = ConDocs.Where(w => rgx.IsMatch(w.DocNumber) && !rgx2.IsMatch(w.DocNumber) && rgxFormat.IsMatch(w.DocNumber)).OrderBy(o => o.DocNumber).ToList();
                    }
                    else
                    {
                        FilteredDocs = ConDocs.Where(w => rgx.IsMatch(w.DocNumber) && !rgx2.IsMatch(w.DocNumber) && rgxFormat.IsMatch(w.DocNumber)).OrderBy(o => o.Status.Sum(u => u.Age)).ToList();
                    }

                    BindDocList();
                }
                else
                {
                    Regex rgx = new Regex("(?i)" + textBox1.Text);
                    if (radSortName.Checked)
                    {
                        FilteredDocs = ConDocs.Where(w => rgx.IsMatch(w.DocNumber) && rgxFormat.IsMatch(w.DocNumber)).OrderBy(o => o.DocNumber).ToList();
                    }
                    else
                    {
                        FilteredDocs = ConDocs.Where(w => rgx.IsMatch(w.DocNumber) && rgxFormat.IsMatch(w.DocNumber)).OrderBy(o => o.Status.Sum(u => u.Age)).ToList();
                    }

                    BindDocList();
                }
            }
            catch
            {
                try
                {
                    if (radSortName.Checked)
                    {
                        FilteredDocs = ConDocs.Where(w => rgxFormat.IsMatch(w.DocNumber)).OrderBy(o => o.DocNumber).ToList();
                    }
                    else
                    {
                        FilteredDocs = ConDocs.Where(w => rgxFormat.IsMatch(w.DocNumber)).OrderBy(o => o.Status.Sum(u => u.Age)).ToList();
                    }

                }
                catch
                {
                    MessageBox.Show("Filter Error, no filter applied.");
                }
            }
        }

        #endregion



        private void openCSVsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCSV();
            analyzeToolStripMenuItem.Enabled = true;
        }

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyzeDocs();
            analyzeToolStripMenuItem.Enabled = false;
        }




    }

    public class sDocument
    {
        public string DocNumber;
        public string DocTitle;

        public List<sStatus> Status = new List<sStatus>();

        public string StatusList
        {
            get
            {
                return DocNumber + " - " + DocTitle + " - Age: " + Status.Sum(u => u.Age) + " days";
            }
        }
    }

    public class sStatus
    {
        public string DocStatus;
        public string RevisionNum;
        public string RevStatus;
        public string Action;
        public DateTime Date;
        public int Age;
    }
    
    public class DocEntry
    {
        public string DocNumber;
        public string DocTitle;
        public string DocStatus;
        public string RevStatus;
        public DateTime ActionDate;
        public string RevisionNum;
        public string VersionNum;
        public string Action;

        public string toString()
        {
            return DocNumber + " || " + DocTitle + ": "
                + DocStatus + ", "
                + RevStatus + ", "
                + ActionDate.ToShortDateString() + ", "
                + RevisionNum + ", "
                + VersionNum + ", "
                + Action;
        }
    }

    public class ColourStatus
    {
        public string Status
        { 
            get;

            set;
        }
        public Color Colour;

        public ColourStatus(string status, Color colour)
        {
            Status = status;
            Colour = colour;
        }

        public ColourStatus()
        {

        }

    }

    public class BetterListBox : ListBox
    {
        // Event declaration
        public delegate void BetterListBoxScrollDelegate(object Sender, BetterListBoxScrollArgs e);
        public event BetterListBoxScrollDelegate Scroll;
        // WM_VSCROLL message constants
        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBTRACK = 5;
        private const int SB_ENDSCROLL = 8;

        protected override void WndProc(ref Message m)
        {
            // Trap the WM_VSCROLL message to generate the Scroll event
            base.WndProc(ref m);
            if (m.Msg == WM_VSCROLL)
            {
                int nfy = m.WParam.ToInt32() & 0xFFFF;
                if (Scroll != null && (nfy == SB_THUMBTRACK || nfy == SB_ENDSCROLL))
                    Scroll(this, new BetterListBoxScrollArgs(this.TopIndex, nfy == SB_THUMBTRACK));
            }
        }

        public class BetterListBoxScrollArgs
        {
            // Scroll event argument
            private int mTop;
            private bool mTracking;
            public BetterListBoxScrollArgs(int top, bool tracking)
            {
                mTop = top;
                mTracking = tracking;
            }
            public int Top
            {
                get { return mTop; }
            }
            public bool Tracking
            {
                get { return mTracking; }
            }
        }
    }

    [System.ComponentModel.DesignerCategory("Code")]
    public class CustomPanel : Panel
    {
        public CustomPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BorderColour))
            e.Graphics.DrawRectangle(new Pen(brush), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        }

        public Color BorderColour
        {
            get;
            set;
        }

    }

}

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static bool ContainsAny(this String str, string[] CompareArray)
        {
            bool b = false;
            foreach (string s in CompareArray)
            {
                b |= str.Contains(s);
            }
            return b;
        }
    }
}
