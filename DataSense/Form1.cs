using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
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

        List<ColourStatus> StatusColours = new List<ColourStatus>();

        private void button1_Click(object sender, EventArgs e)
        {
            Headers.Clear();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = new FileStream(OFD.FileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (TextFieldParser parser = new TextFieldParser(fs))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");

                        string[] fields = parser.ReadFields();

                        if (chHasHeaders.Checked)
                        {
                            betterListBox1.Items.Clear();
                            Headers.AddRange(fields);
                            betterListBox1.Items.AddRange(Headers.ToArray());
                        }
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

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            betterListBox1.Items.Clear();

            var GroupedDocs = DocEntries.GroupBy(g => g.DocNumber); //Group document list by doc number
                        
            foreach (var Doc in GroupedDocs) //Loop through each group
            {
                DateTime dTemp = DateTime.Parse("0001/01/01"); //Temp Variable for loop logic

                sDocument ConsolidatedDoc = new sDocument(); //Class containing all document revision info
                sStatus ConsolidatedStatus = new sStatus(); //Helper to contain revision lists

                foreach (DocEntry item in Doc.OrderBy(o => o.ActionDate)) //Loop through each entry in current group
                {
                    if (dTemp != DateTime.Parse("0001/01/01")) //If date is valid
                    {
                        ConsolidatedStatus.Age = (item.ActionDate - dTemp).Days; //Subtract previous date from current entry date
                    }
                    else
                    {
                        ConsolidatedStatus.Age = 0;
                    }

                    dTemp = item.ActionDate; //Set temp date to current date

                    ConsolidatedStatus.DocStatus = item.DocStatus;
                    ConsolidatedStatus.RevisionNum = item.RevisionNum;
                    ConsolidatedStatus.RevStatus = item.RevStatus; //set status helper status

                    if (item.Action == "")
                    {
                        ConsolidatedStatus.Action = item.RevStatus;
                    }
                    else
                    {
                        ConsolidatedStatus.Action = item.Action;
                    }

                    ConsolidatedStatus.Date = dTemp; //set status helper date

                    ConsolidatedDoc.DocTitle = item.DocTitle;
                }

                if (dTemp != DateTime.Parse("0001/01/01") && dTemp <= DateTime.Today) //Subtract last date from today
                {
                    ConsolidatedStatus.Age = (DateTime.Today - dTemp).Days;
                }
                else
                {
                    ConsolidatedStatus.Age = 0;
                }
                ConsolidatedDoc.Status.Add(ConsolidatedStatus);
                ConsolidatedDoc.DocNumber = Doc.Key;

                ConDocs.Add(ConsolidatedDoc);
            }


            StatusColours.Clear();

            string[] Stats = { "CGC", "G5", "WP", "FOR REVIEW" };
            Color[] Cols = {Color.Green, Color.Blue, Color.Red, Color.Cyan };

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

        private void BindColourList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = StatusColours.Select(s => s.Status).ToList();
            listBox1.SelectedItems.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            this.Invalidate();
            this.Refresh();
        }

        void DrawLines(Graphics g, List<sDocument> Docs, int skip, int width, int DayLength)
        {
            
        }

        private void betterListBox1_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void betterListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            betterListBox1.TopIndex = betterListBox1.SelectedIndex;
            this.Invalidate();
            this.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count > 0)
            {
                if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach(int i in listBox1.SelectedIndices)
                    {
                        StatusColours[i].Colour = colorDialog1.Color;
                    }
                    BindColourList();
                }
            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            e.DrawBackground();

            using (Brush myBrush = new SolidBrush(StatusColours[e.Index].Colour))
            {

                int y = (e.Index - listBox1.TopIndex) * listBox1.ItemHeight+6;

                int x = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(),e.Font).Width;

                e.Graphics.DrawLine(new Pen(myBrush,5), x, y, listBox1.Width, y);

            }
            using (Brush p = new SolidBrush(listBox1.ForeColor))
            {
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                e.Font, p, e.Bounds, StringFormat.GenericDefault);
            }
            
            e.DrawFocusRectangle();
        }
    }

    public class sDocument
    {
        public string DocNumber;
        public string DocTitle;

        public List<sStatus> Status = new List<sStatus>();
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
        public string Status;
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
