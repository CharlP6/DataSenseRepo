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
        List<string[]> data = new List<string[]>();

        List<kDocument> Documents = new List<kDocument>();

        private void button1_Click(object sender, EventArgs e)
        {
            Headers.Clear();
            data.Clear();

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
                            listBox1.Items.Clear();
                            Headers.AddRange(fields);
                            listBox1.Items.AddRange(Headers.ToArray());
                        }
                        while (!parser.EndOfData)
                        {
                            fields = parser.ReadFields();
                            data.Add(fields);
                        }
                    }                    
                }
            }
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var gDoc = data.GroupBy(s => s[0]);

            List<DateTime> Dates = new List<DateTime>();
            List<string> Statusses = new List<string>();
            List<int> Ages = new List<int>();

            foreach (var Doc in gDoc)
            {
            Dates = new List<DateTime>();
            Statusses = new List<string>();
            Ages = new List<int>();

                DateTime d1;

                Doc.OrderBy(o => o[6]);

                string title = "";

                foreach (string[] entry in Doc)
                {
                    DateTime.TryParse(entry[6], out d1);

                    Statusses.Add(entry[5]);

                    if (Dates.Count != 0)
                    {
                        if (Dates.Last() == DateTime.Parse("0001/01/01"))
                        {
                            Ages.Add(0);
                        }
                        else
                        {
                            Ages.Add((d1 - Dates.Last()).Days);
                        }
                    }
                    Dates.Add(d1);
                    title = entry[2];
                }

                Ages.Add((DateTime.Today - Dates.Last()).Days);

                Documents.Add(new kDocument { DocName = Doc.Key, DocTitle=title, Ages = Ages, Dates = Dates, Statusses = Statusses });
                
            }

            listBox1.Items.AddRange(Documents.Where(d => d.DocName.Contains("-SC1-")).Select(s => s.ToString()).ToArray());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            paint = true;
            this.Invalidate();
            this.Refresh();
        }

        bool paint = false;

        void DrawLines(Graphics g, List<kDocument> Docs)
        {
            int i = 300;

            Random r = new Random();

            foreach (kDocument Doc in Docs)
            {

                int l = 0;

                for(int j = 0; j < Doc.Ages.Count; j++)
                {
                    if (Doc.Statusses[j].Contains("WP"))
                    {
                        using (Pen p = new Pen(Color.Yellow, 1))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if(Doc.Statusses[j].Contains("G5"))
                    {
                        using (Pen p = new Pen(Color.Red, 1))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if(Doc.Statusses[j].Contains("CGC"))
                    {
                        using (Pen p = new Pen(Color.Green, 1))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else if(Doc.Statusses[j].Contains(""))
                    {
                        using (Pen p = new Pen(Color.White, 1))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }
                    else
                    {
                        using (Pen p = new Pen(Color.Blue, 1))
                        {
                            g.DrawLine(p, l, i, l + Doc.Ages[j] * 2, i);
                        }
                    }

                    l += Doc.Ages[j]*2;
                }
                i += 1;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (paint)
            {
                e.Graphics.Clear(Color.White);
                DrawLines(e.Graphics, Documents.Where(d => d.DocName.Contains("-NM1-")).ToList());
            }

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
            return DocName + ", " + string.Join(", ", Ages.Select(s => s.ToString()).ToArray());
        }

    }

    public class kStatus
    {
        public string RevStatus;
        public string DocStatus;
        public DateTime StatusDate;
        public int StatusAge;
    }
}
