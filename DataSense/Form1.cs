using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace DataSense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Headers = new List<string>();

        List<kDocument> Documents = new List<kDocument>();

        List<DocEntry> DocEntries = new List<DocEntry>();

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

                            DocEntries.Add(new DocEntry
                            {
                                DocNumber = fields[0],
                                DocTitle = fields[1],
                                RevisionNum = fields[2],
                                VersionNum = fields[3],
                                DocStatus = fields[4],
                                RevStatus = fields[5],
                                ActionDate = ActDate,
                                Action = fields[7]
                            });
                        }
                    }
                }
            }
        }

       

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            //betterListBox1.Items.AddRange(DocEntries.OrderBy(d => d.ActionDate).Select(s => s.toString()).ToArray());
            var GroupedDocs = DocEntries.GroupBy(g => g.DocNumber);

            List<string> ConsolidatedDocs = new List<string>();

            foreach (var Doc in GroupedDocs)
            {
                string Dates = string.Join(", ", Doc.OrderBy(o => o.ActionDate).Select(s => s.ActionDate.ToShortDateString()));
                ConsolidatedDocs.Add(Doc.Key + ": " + Dates);
            }

            betterListBox1.Items.AddRange(ConsolidatedDocs.ToArray());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            paint = true;
            this.Invalidate();
            this.Refresh();
        }

        bool paint = false;

        void DrawLines(Graphics g, List<kDocument> Docs, int skip)
        {
            int i = 300;

            Random r = new Random();

            foreach (kDocument Doc in Docs.Skip(skip))
            {

                int l = 0;

                int w = 2;

                for (int j = 0; j < Doc.Ages.Count; j++)
                {
                    if (Doc.Statusses[j].Contains("For Review"))
                    {
                        using (Pen p = new Pen(Color.Cyan, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if (Doc.Statusses[j].Contains("TRA"))
                    {
                        using (Pen p = new Pen(Color.Yellow, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if (Doc.Statusses[j].Contains("WP"))
                    {
                        using (Pen p = new Pen(Color.Red, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if (Doc.Statusses[j].Contains("WP"))
                    {
                        using (Pen p = new Pen(Color.Red, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if (Doc.Statusses[j].Contains("G5"))
                    {
                        using (Pen p = new Pen(Color.Blue, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if (Doc.Statusses[j].Contains("CGC"))
                    {
                        using (Pen p = new Pen(Color.DarkOrange, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if (Doc.Statusses[j] == "")
                    {
                        using (Pen p = new Pen(Color.White, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else
                    {
                        using (Pen p = new Pen(Color.White, w))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }

                    l += Doc.Ages[j] * 2;
                }
                i += w;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (paint)
            {
                e.Graphics.Clear(Color.Black);
                DrawLines(e.Graphics, Documents.Where(d => (System.Text.RegularExpressions.Regex.Match(d.DocName, "^\\w{4}-\\w{3}-\\w{4}-\\w{2}-\\w{3}-\\w{4}-\\w{3}").Length > 0) && d.Ages.Sum() < 10000 && d.DocName.Contains("PID")).OrderBy(f => f.DocName.Split('-')[1]).ToList(), betterListBox1.TopIndex);
            }

        }

        private void betterListBox1_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (paint && e.Y > 300)
            {
                betterListBox1.SelectedIndex = (e.Y - 300) / 2 + betterListBox1.TopIndex;
            }
        }

        private void betterListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            betterListBox1.TopIndex = betterListBox1.SelectedIndex;
            this.Invalidate();
            this.Refresh();
        }

    }

    public class kDocument
    {
        public string DocName;
        public string DocTitle;

        public List<DateTime> Dates;
        public List<string> Statusses;
        public List<int> Ages;

        public string ToString()
        {
            return DocName + ", " + string.Join(", ", Dates.Select(d => d.ToShortDateString()).ToArray());
        }

    }

    public class kStatus
    {
        public string RevStatus;
        public string DocStatus;
        public DateTime StatusDate;
        public int StatusAge;
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
