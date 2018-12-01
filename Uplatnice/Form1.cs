using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Uplatnice
{
    public partial class Form1 : Form
    {
        private Library library;

        public Form1()
        {
            InitializeComponent();
            library = new Library();
            library.ReadSettings();

            avansTB.Text = Library.avans;
            brojRataTB.Text = Library.brojRata;
            odgodaTB.Text = Library.odgoda;
            rokTB.Text = Library.rok;

            date1.Value = DateTime.Now.AddDays(-1);
        }

        RootObject instance;

        private void buttonDohvatiPodatke_Click(object sender, EventArgs e)
        {
            dohvatiPodatke();
        }

        private void dohvatiPodatke()
        {
            DateTime datum1 = date1.Value;
            DateTime datum2 = date2.Value;
            string d1 = datum1.Year.ToString("0000") + datum1.Month.ToString("00") + datum1.Day.ToString("00");
            string d2 = datum2.Year.ToString("0000") + datum2.Month.ToString("00") + datum2.Day.ToString("00");
            string link = "https://new.nikal-travel.si/getR/?from=" + d1 + "&to=" + d2 + "&status=2&md5=9876543210";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            instance = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(content);
            grid.AutoGenerateColumns = false;
            grid.DataSource = instance.data;
        }

        public class data
        {
            public string id { get; set; }
            public string status { get; set; }
            public string taxtype { get; set; }
            public string company { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string address { get; set; }
            public string zip { get; set; }
            public string city { get; set; }
            public decimal selling { get; set; }
            public decimal paid { get; set; }
            public decimal remaining { get; set; }
            public DateTime createdate { get; set; }
            public DateTime startdate { get; set; }
            public DateTime enddate { get; set; }
        }

        public class RootObject
        {
            public List<data> data { get; set; }
        }

        private void buttonIspis_Click(object sender, EventArgs e)
        {
            ispis();
        }

        protected void ispis()
        {
            Document doc = new Document(new iTextSharp.text.Rectangle(10.5f, 6.5f), 0.5f, 0.5f, 0, 0);

            try
            {

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(
                  Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf", FileMode.Create));
                doc.Open();

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if ((string)grid.Rows[i].Cells[0].Value == "True")
                    {
                        if (i != 0)
                            doc.NewPage();
                        string ime = (string)grid.Rows[i].Cells[3].Value;
                        string adresa = (string)grid.Rows[i].Cells[4].Value;
                        string content = ime;
                        iTextSharp.text.pdf.PdfContentByte cb = writer.DirectContent;
                        iTextSharp.text.pdf.BarcodeQRCode Qr = new BarcodeQRCode(content, 50, 5, null);
                        iTextSharp.text.Image img = Qr.GetImage();
                        cb.SetTextMatrix(-2.0f, 0.0f);
                        img.ScaleToFit(60, 5);
                        img.SetAbsolutePosition(0f, 0.5f);
                        cb.AddImage(img);

                        PdfContentByte cb1 = writer.DirectContent;
                        BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLDITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb1.SetFontAndSize(bf, 0.5f);
                        cb1.BeginText();
                        cb1.SetTextMatrix(0.2f, 5.1f);
                        cb1.ShowText(ime);
                        cb1.EndText();

                        PdfContentByte id = writer.DirectContent;
                        BaseFont bf1 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        id.SetFontAndSize(bf1, 0.4f);
                        id.BeginText();
                        id.SetTextMatrix(0.2f, 0.6f);
                        id.ShowText(adresa);
                        id.EndText();
                    }
                }
                // if you want to print it un comment the following two line

                //PdfAction act = new PdfAction(PdfAction.PRINTDIALOG);
                //writer.SetOpenAction(act);

                doc.Close();

                System.Diagnostics.Process.Start(Environment.GetFolderPath(
                           Environment.SpecialFolder.Desktop) + "/codes.pdf");

            }
            catch
            {
            }
            finally
            {
                doc.Close();
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[0].Value = checkBox1.Checked;
            }
        }
    }
}
