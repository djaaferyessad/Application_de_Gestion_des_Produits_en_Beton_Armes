using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Ets_yessad.Forms
{
    public partial class BonStocke : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlDataReader dr;
        SqlCommand cm;
        string nbongrid = "";
        string clientgrid = "";
        public BonStocke()
        {
            InitializeComponent();
            datelabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            loaduser();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loaduser()
        {
            string formattedNumber1 = "";
            int i = 0;
            bongridview.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM BonStock ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                bongridview.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), string.Format("{0:N2}", Convert.ToDouble(dr[3].ToString())), string.Format("{0:N2}", Convert.ToDouble(dr[4].ToString())), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());

            }
            dr.Close();
            dbconnect.CloseCon();
        }

        private void recherchebox_TextChanged(object sender, EventArgs e)
        {


            string searchQuery = recherchebox.Text.ToLower(); // Convert the search query to lowercase for case-insensitive search

            // Iterate through the rows and hide those that don't match the search query
            foreach (DataGridViewRow row in bongridview.Rows)
            {
                if (row.Cells["Client"].Value.ToString().ToLower().Contains(searchQuery) ||
                    row.Cells["Chiffeur"].Value.ToString().ToLower().Contains(searchQuery))
                {
                    row.Visible = true; // Show the row if it matches the search query
                }
                else
                {
                    row.Visible = false; // Hide the row if it doesn't match the search query
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (sender is RadioButton selectedRadioButton && selectedRadioButton.Checked)
            {
                string filterCriteria = selectedRadioButton.Text.ToLower();

                foreach (DataGridViewRow row in bongridview.Rows)
                {
                    string payeeValue = row.Cells["Payee"].Value?.ToString()?.ToLower() ?? "";
                    string servieeValue = row.Cells["Serviee"].Value?.ToString()?.ToLower() ?? "";

                    bool showRow = false;

                    if (filterCriteria == "touts")
                    {
                        showRow = true;
                    }
                    else if (filterCriteria == "payée" && payeeValue == "payée")
                    {
                        showRow = true;
                    }
                    else if (filterCriteria == "non payée" && payeeValue == "non payée")
                    {
                        showRow = true;
                    }
                    else if (filterCriteria == "serviée" && servieeValue == "oui")
                    {
                        showRow = true;
                    }
                    else if (filterCriteria == "non serviée" && servieeValue == "non")
                    {
                        showRow = true;
                    }

                    row.Visible = showRow;
                }
            }
        }

        private void bongridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = bongridview.Columns[e.ColumnIndex].Name;
            if (colName == "suprimer")
            {
                try
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string prod = bongridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                        dbconnect.OpenCon();
                        cm = new SqlCommand("DELETE FROM BonStock WHERE Nbon = @nbon", dbconnect.getCon());
                        cm.Parameters.AddWithValue("@nbon", prod);
                        cm.ExecuteNonQuery();
                        dbconnect.CloseCon();
                        cm = new SqlCommand("DELETE FROM StatsTable WHERE Nbon = @nbon", dbconnect.getCon());
                        dbconnect.OpenCon();
                        cm.Parameters.AddWithValue("@nbon", prod);
                        cm.ExecuteNonQuery();
                        dbconnect.CloseCon();

                        MessageBox.Show("L’utilisateur a été supprimé avec succès!");
                        loaduser();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (colName == "imprime")
            {

                string cellValue = bongridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (cellValue.StartsWith("SB"))
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {

                    // Get the PDF file name from the DataGridView cell
                    string pdfFileName = bongridview.Rows[e.RowIndex].Cells[0].Value.ToString() + ".pdf";

                    // Combine the file path with your application path and "Les Bon Stock"
                    string pdfFilePath = Path.Combine(Application.StartupPath, "Les Bon Stock", pdfFileName);

                    // Check if the file exists
                    if (File.Exists(pdfFilePath))
                    {
                        // Open the PDF file using the default PDF viewer
                        Process.Start(pdfFilePath);
                    }
                    else
                    {
                        // Handle the case where the file doesn't exist
                        MessageBox.Show("PDF file does not exist.");


                    }

                }
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach (DataGridViewRow row in bongridview.SelectedRows)
            {
                clientgrid = row.Cells["Client"].Value.ToString();
                nbongrid = row.Cells["Nbon"].Value.ToString();
                    }
                string imagePath = Path.Combine(Application.StartupPath, "icons ets yessad", "etslogo.png");
            Image logoImage = Image.FromFile(imagePath);
            Rectangle destinationRect = new Rectangle(20, 20, 150, 150);
            e.Graphics.DrawString("ETS YESSAD", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 10));
            e.Graphics.DrawString("Fabrication produit Béton Armé", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(330, 50));
            e.Graphics.DrawString("RN74 Beni Ourtilane Sétif", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 70));
            e.Graphics.DrawString("TEL :  +213 770 95 89 88", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 100));
            e.Graphics.DrawString("          +213 554 57 10 23", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 120));
            e.Graphics.DrawString("          +213 669 27 91 30", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 140));
            e.Graphics.DrawString("          +213 779 24 32 90", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 160));
            e.Graphics.DrawString("fabricationproduitbeton@gmail.com", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, 180));
            e.Graphics.DrawString("facebook :ETS yessad F.P Béton ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("Map : ETS Yessad Beni Ourtilane ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, 220));
            e.Graphics.DrawString("BON", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(370, 180));
            e.Graphics.DrawString("N°bon: " + nbongrid, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 270));
            e.Graphics.DrawString("Client:  " + clientgrid, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString("Le:  " + datelabel.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(620, 300));
            e.Graphics.DrawImage(logoImage, destinationRect);
            logoImage.Dispose();
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString("N", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("DESCRIPTION", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 370));
            e.Graphics.DrawString("P.U", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(550, 370));
            e.Graphics.DrawString("PRIX", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(700, 370));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 410));
            int rows = 430;
            int totaltouts = 0;
            foreach (DataGridViewRow row in bongridview.SelectedRows)
            {
                // Access the data in each selected row
                string produit = row.Cells["Produit"].Value.ToString();
                string quantite = row.Cells["Quantite"].Value.ToString();
                string prixUnite = row.Cells["Prix"].Value.ToString();
                string total = row.Cells["Total"].Value.ToString();
                string cleanedString = total.Replace(",", "").Replace(".", "");
                if (int.TryParse(cleanedString, out int result))
                {
                    totaltouts += result;
                }
                
                string laDate = row.Cells["La_date"].Value.ToString();
                e.Graphics.DrawString(quantite, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(40, rows));
                e.Graphics.DrawString(produit, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(190, rows));
                e.Graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(prixUnite)), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, rows));
                e.Graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(total)), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(690, rows));
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, rows + 20));
                rows = rows + 40;

                // Do something with the data, e.g., display it or process it
            }
            dr.Close();
            dbconnect.CloseCon();
            e.Graphics.DrawString("-----------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(590, 880));
            e.Graphics.DrawString("TOTAL =  " + string.Format("{0:N2}",Convert.ToDouble(totaltouts/100)), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, 900));
            e.Graphics.DrawString("-----------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(590,920));
            e.Graphics.DrawString("Merci pour votre visite ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 1070));

        }
        private void SaveAsPDF(string filePath)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Add a page to the document
            PdfPage page = document.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);

            // Load and draw the image
            string imagePath = Path.Combine(Application.StartupPath, "icons ets yessad", "etslogo.png");
            XImage logoImage = XImage.FromFile(imagePath);
            graphics.DrawImage(logoImage, 20, 20, 150, 150);

            // Define the font and other formatting options
            XFont font = new XFont("Arial", 12);
            XBrush brush = XBrushes.Black;
            DateTime now = DateTime.Now;
            // Draw text and other elements
            graphics.DrawString("ETS YESSAD", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(250, 20));
            graphics.DrawString("Fabrication produit Béton Armé", font, brush, new XPoint(235, 35));
            graphics.DrawString("RN74 Beni Ourtilane Sétif", font, brush, new XPoint(250, 50));
            graphics.DrawString("TEL :  +213 770 95 89 88", font, brush, new XPoint(400, 100));
            graphics.DrawString("          +213 554 57 10 23", font, brush, new XPoint(400, 115));
            graphics.DrawString("          +213 669 27 91 30", font, brush, new XPoint(400, 130));
            graphics.DrawString("          +213 779 24 32 90", font, brush, new XPoint(400, 145));
            graphics.DrawString("fabricationproduitbeton@gmail.com", font, brush, new XPoint(400, 160));
            graphics.DrawString("facebook :ETS yessad F.P Béton", font, brush, new XPoint(400, 175));
            graphics.DrawString("Map : ETS Yessad Beni Ourtilane", font, brush, new XPoint(400, 190));
            graphics.DrawString("BON", new XFont("Arial", 30, XFontStyle.Bold), brush, new XPoint(270, 180));
            graphics.DrawString("N°bon: " + nbongrid, font, brush, new XPoint(20, 270));
            graphics.DrawString("Client: " + clientgrid, font, brush, new XPoint(20, 285));
            graphics.DrawString("Time : " + now.Hour.ToString("00") + ":" + now.Minute.ToString("00"), font, brush, new XPoint(450, 265));
            graphics.DrawString("Le: " + datelabel.Text, font, brush, new XPoint(450, 280));
            graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, 320));
            graphics.DrawString("Quantité", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(35, 340));
            graphics.DrawString("Description", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(200, 340));
            graphics.DrawString("P.U", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(440, 340));
            graphics.DrawString("Prix", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(520, 340));
            graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, 360));
            int totaltouts = 0;
            int rows = 370;
            foreach (DataGridViewRow row in bongridview.SelectedRows)
            {
                // Access the data in each selected row
                string produit = row.Cells["Produit"].Value.ToString();
                string quantite = row.Cells["Quantite"].Value.ToString();
                string prixUnite = row.Cells["Prix"].Value.ToString();
                string total = row.Cells["Total"].Value.ToString();
                string cleanedString = total.Replace(",", "").Replace(".", "");
                if (int.TryParse(cleanedString, out int result))
                {
                    totaltouts += result;
                }

                string laDate = row.Cells["La_date"].Value.ToString();
                graphics.DrawString(quantite, font, brush, new XPoint(45, rows));
                graphics.DrawString(produit, font, brush, new XPoint(190, rows));
                graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(prixUnite)), font, brush, new XPoint(440, rows));
                graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(total)), font, brush, new XPoint(520, rows));
                graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------", font,brush, new XPoint(10, rows + 10));
                rows = rows + 20;

                // Do something with the data, e.g., display it or process it
            }
            rows = 700;
            dr.Close();
            dbconnect.CloseCon();
            graphics.DrawString("Merci pour votre visite ", font, brush, new XPoint(270, rows + 110));




            // ... Continue drawing the rest of the content using drawing commands ...

            // Save the PDF document to the specified file path
            document.Save(filePath);

            // Close the document
            document.Close();

            // Show a message to indicate successful saving
            MessageBox.Show("Fichier PDF enregistré avec succès sur : " + filePath);
        }

        private void ajouterbtnbon_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            string subfolderPath = Path.Combine(Application.StartupPath, "Les Bon Stock");
            Directory.CreateDirectory(subfolderPath); // Ensure the subfolder exists
            string filePath = Path.Combine(subfolderPath, nbongrid + ".pdf"); // Replace with your directory
           SaveAsPDF(filePath);
        }
    }
}

