using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
namespace Ets_yessad.Forms
{
    public partial class FormBon : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm;
        SqlDataReader dr;
        string produit1 = "";
        string quantite1 = "";
        int prixparunite = 0;
        public FormBon()
        {
            InitializeComponent();
            loaduser();
            AddItemsToComboBox("SELECT * FROM produiteTable", produitecombobox);
            datelabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            totaldeargent();
            getnbonid();
        }

        public void loaduser()
        {
            string formattedNumber1 = "";
            int i = 0;
            bongridview.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM BonTable ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                if (i == 1) { produit1 = dr[0].ToString(); quantite1 = dr[1].ToString(); prixparunite = int.Parse(dr[2].ToString()); }
                bongridview.Rows.Add(dr[0].ToString(), dr[1].ToString(), string.Format("{0:N2}", Convert.ToDouble(dr[2].ToString())), string.Format("{0:N2}", Convert.ToDouble(dr[3].ToString())));
                ;
            }
            dr.Close();
            dbconnect.CloseCon();
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajouterbtnbon_Click(object sender, EventArgs e)
        {
             /*if(numerosclientbox.Text.Length < 10)
             {
                 MessageBox.Show("le numeros est invalid"); 
             }*/
             if(produitecombobox.Text == "" || quantitebonbox.Text == "" || typedeprixbonbox.Text == "" || prixunitebonbox.Text == "")
            {
                MessageBox.Show("enteré touts les information s'il vous plait");
            }
             else {
                if (int.Parse(quantitebonbox.Text) > int.Parse(quantitedeproduite("")))
                {
                    MessageBox.Show("il n'ya pas sous quantité dans le stock ");
                }
                else
                {


                    try
                    {

                        string insertQurey = "INSERT INTO BonTable (Produit,Quantite,Prix_unite,Total) VALUES (@produit,@quantite,@prixunite,@total)";

                        SqlCommand command = new SqlCommand(insertQurey, dbconnect.getCon());
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@produit", produitecombobox.Text);
                        command.Parameters.AddWithValue("@quantite", quantitebonbox.Text);
                        command.Parameters.AddWithValue("@prixunite", prixunitebonbox.Text);    
                        command.Parameters.AddWithValue("@total", totalbox.Text);

                        dbconnect.OpenCon();
                        command.CommandText = insertQurey;
                        command.ExecuteNonQuery();
                        MessageBox.Show("ajouter avec succès");
                        dbconnect.CloseCon();
                        loaduser();
                        modifier_la_quantite(0, "ajouter", "");
                        totaldeargent();
                        reste("nontouts");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        public void AddItemsToComboBox(string query, ComboBox comboBox)
        {
            var command = new SqlCommand(query, dbconnect.getCon());
            dbconnect.OpenCon();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox.Items.Add(reader.GetString(0));
                }
            }
            dbconnect.CloseCon();

        }

        private void typedeprixbonbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typedeprixbonbox.SelectedIndex == 0)
            {
                try
                {
                    dbconnect.OpenCon();
                    cm = new SqlCommand("SELECT Prix_gros FROM produiteTable WHERE Produit=@produit", dbconnect.getCon());
                    cm.Parameters.AddWithValue("@produit", produitecombobox.Text);

                    // Execute the SQL command and retrieve the value from the result set
                    object result = cm.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null)
                    {
                        // Convert the result to a string and set it to prixunitebonbox.Text
                        prixunitebonbox.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where no result was found
                        prixunitebonbox.Text = "N/A"; // or any appropriate default value
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dbconnect.CloseCon();
                }
            }
            if (typedeprixbonbox.SelectedIndex == 1)
            {
                try
                {
                    dbconnect.OpenCon();
                    cm = new SqlCommand("SELECT Prix_dettailles FROM produiteTable WHERE Produit=@produit", dbconnect.getCon());
                    cm.Parameters.AddWithValue("@produit", produitecombobox.Text);

                    // Execute the SQL command and retrieve the value from the result set
                    object result = cm.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null)
                    {
                        // Convert the result to a string and set it to prixunitebonbox.Text
                        prixunitebonbox.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where no result was found
                        prixunitebonbox.Text = "N/A"; // or any appropriate default value
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dbconnect.CloseCon();
                }
            }
        }

        private void produitecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantitebonbox.Text = quantitedeproduite("");
        }
        public string quantitedeproduite(string prod)
        {
            try
            {
                dbconnect.OpenCon();
                cm = new SqlCommand("SELECT Quantite FROM produiteTable WHERE Produit=@produit", dbconnect.getCon());
                if(prod == "")
                cm.Parameters.AddWithValue("@produit", produitecombobox.Text);
                else
                cm.Parameters.AddWithValue("@produit", prod);

                // Execute the SQL command and retrieve the value from the result set
                object result = cm.ExecuteScalar();

                // Check if the result is not null
                if (result != null)
                {
                    // Convert the result to a string and set it to prixunitebonbox.Text
                    return result.ToString();
                   
                }
                else
                {
                    return "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "N/A";
            }
        }
        public void modifier_la_quantite(int quantiteajouter,string from, string prod)
        {
            try
            {
               
                string initialquantite ="";
                int noveauquan=0;
                if (from == "ajouter")
                {
                    initialquantite = quantitedeproduite("");
                    noveauquan = int.Parse(initialquantite) - int.Parse(quantitebonbox.Text);
                }
                if (from == "delete")
                {
                    initialquantite = quantitedeproduite(prod);
                    noveauquan = int.Parse(initialquantite) + quantiteajouter;
                }
                SqlCommand command = new SqlCommand("UPDATE produiteTable SET Quantite=@quantite WHERE Produit=@prod", dbconnect.getCon());
                if (from == "ajouter")
                    command.Parameters.AddWithValue("@prod", produitecombobox.Text);
                else
                command.Parameters.AddWithValue("@prod", prod);
                command.Parameters.AddWithValue("@quantite", noveauquan);


                command.ExecuteNonQuery();
                dbconnect.CloseCon();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        string valueStr = bongridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                        if (int.TryParse(valueStr, out int value))
                        {
                            string prod = bongridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                            dbconnect.OpenCon();
                            cm = new SqlCommand("DELETE FROM BonTable WHERE Produit = @produit", dbconnect.getCon());
                            cm.Parameters.AddWithValue("@produit", prod);
                            cm.ExecuteNonQuery();
                            dbconnect.CloseCon();
                            MessageBox.Show("L’utilisateur a été supprimé avec succès!");
                            loaduser();
                            modifier_la_quantite(value, "delete", prod);
                            totaldeargent();
                        }
                        else
                        {
                            MessageBox.Show("La valeur n'est pas un nombre valide.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void totaldeargent()
        {
            decimal totalSum = 0; // Use decimal to handle decimal values

            foreach (DataGridViewRow row in bongridview.Rows)
            {
                // Check if the row is not a header row and the "Total" column exists
                if (!row.IsNewRow && row.Cells["Total"].Value != null)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString().Replace(",", ""), out cellValue))
                    {
                        totalSum += cellValue;
                    }
                }
            }

            totallabel.Text = string.Format("{0:N2}", totalSum);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
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
            e.Graphics.DrawString("N°bon: "+Nbonbox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 270));
            e.Graphics.DrawString("Client:  " + clientbonbox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString("Le:  " + datelabel.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(620, 300));
            e.Graphics.DrawImage(logoImage, destinationRect);
            logoImage.Dispose();
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString("N", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("DESCRIPTION", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 370));
            e.Graphics.DrawString("P.U", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(550, 370));
            e.Graphics.DrawString("PRIX", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(700, 370));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 410));

            cm = new SqlCommand("SELECT * FROM BonTable ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            int row = 430;
            while (dr.Read())
            {
                e.Graphics.DrawString(dr[1].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(40, row));
                e.Graphics.DrawString(dr[0].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(190, row));
                e.Graphics.DrawString(string.Format("{0:N2}",Convert.ToDouble(dr[2].ToString())), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row));
                e.Graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(dr[3].ToString())), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(690, row));
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, row + 20));
                row = row + 40;

            }
            row = 900;
            dr.Close();
            dbconnect.CloseCon();
            int totalavectrans = 0;
            if (transportBox.Text != "")
                totalavectrans = int.Parse(totallabel.Text.Replace(",","").Replace(".00",""))+ int.Parse(transportBox.Text);
            else
                totalavectrans = int.Parse(totallabel.Text.Replace(",", "").Replace(".00", "")) ;

            e.Graphics.DrawString("TOTAL =  "+ string.Format("{0:N2}", Convert.ToDouble(totalavectrans.ToString())), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row));
            e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+20));
            e.Graphics.DrawString("STATUS :  " + statuscombobox.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+40));
            e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+60)); 
            e.Graphics.DrawString("RESTE :  " + restebox.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+80));
            e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+100));
            e.Graphics.DrawString("SERVIÉE :  " + servieebox.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+120));
            e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+140));
            if (transportBox.Text != "")
            {
                e.Graphics.DrawString("Fee de Transport :  " + string.Format("{0:N2}", Convert.ToDouble(transportBox.Text)), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+160));
                e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(540, row+180));
            }
            e.Graphics.DrawString("Merci pour votre visite ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 1120));



        }

        private void imprimebonbtn_Click(object sender, EventArgs e)
        {
            if (clientbonbox.Text == "" || numerosclientbox.Text == "" || statuscombobox.Text == "" || servieebox.Text == "")
            {
                MessageBox.Show("Si vous plait complete tous les information");
            }
            else
            {
                if (statuscombobox.SelectedIndex == 1 && versebox.Text == "")
                {
                    MessageBox.Show("Si vous plait ecrire combien il Versé");
                }
                else
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
            }
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
            graphics.DrawString("N°bon: " + Nbonbox.Text, font, brush, new XPoint(20, 270));
            graphics.DrawString("Client: " + clientbonbox.Text, font, brush, new XPoint(20, 285));
            graphics.DrawString("Time : " + now.Hour.ToString("00") + ":" + now.Minute.ToString("00"), font , brush , new XPoint(450, 265));
            graphics.DrawString("Le: " + datelabel.Text, font, brush, new XPoint(450, 280));
            graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, 320));
            graphics.DrawString("Quantité", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(35, 340));
            graphics.DrawString("Description", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(200, 340));
            graphics.DrawString("P.U", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(440, 340));
            graphics.DrawString("Prix", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(520, 340));
            graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, 360));
            cm = new SqlCommand("SELECT * FROM BonTable ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            int row = 370;
            while (dr.Read())
            {
                graphics.DrawString(dr[1].ToString(), font, brush, new XPoint(45, row));
                graphics.DrawString(dr[0].ToString(), font, brush, new XPoint(200, row));
                graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(dr[2].ToString())), font, brush, new XPoint(440, row));
                graphics.DrawString(string.Format("{0:N2}", Convert.ToDouble(dr[3].ToString())), font, brush, new XPoint(520, row));
                graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, row+10));
                row = row + 20;

            }
            row = 700;
            dr.Close();
            dbconnect.CloseCon();
            int totalavectrans = 0;
            if (transportBox.Text != "")
                totalavectrans = int.Parse(totallabel.Text.Replace(",", "").Replace(".00", "")) + int.Parse(transportBox.Text);
            else
                totalavectrans = int.Parse(totallabel.Text.Replace(",", "").Replace(".00", ""));
            graphics.DrawString("TOTAL =  " + string.Format("{0:N2}", Convert.ToDouble(totalavectrans.ToString())), font, brush, new XPoint(420, row));
            graphics.DrawString("-------------------------------------------------", font, brush, new XPoint(420, row + 10));
            graphics.DrawString("STATUS :  " + statuscombobox.Text, font, brush, new XPoint(420, row + 20));
            graphics.DrawString("-------------------------------------------------", font, brush, new XPoint(420, row + 30));
            graphics.DrawString("RESTE :  " + restebox.Text, font, brush, new XPoint(420, row + 40));
            graphics.DrawString("-------------------------------------------------", font, brush, new XPoint(420, row + 50));
            graphics.DrawString("SERVIÉE :  " + servieebox.Text, font, brush, new XPoint(420, row + 60));
            graphics.DrawString("-------------------------------------------------", font, brush, new XPoint(420, row + 70));
            if (transportBox.Text != "")
            {
                graphics.DrawString("Fee de Transport :  " + string.Format("{0:N2}", Convert.ToDouble(transportBox.Text)), font, brush, new XPoint(420, row + 80));
                graphics.DrawString("-------------------------------------------------", font, brush, new XPoint(420, row + 90));
            }
            graphics.DrawString("Merci pour votre visite ", font, brush, new XPoint(270, row + 110));




            // ... Continue drawing the rest of the content using drawing commands ...

            // Save the PDF document to the specified file path
            document.Save(filePath);

            // Close the document
            document.Close();

            // Show a message to indicate successful saving
            MessageBox.Show("Fichier PDF enregistré avec succès sur : " + filePath);
        }

        private void imprimeressavebtn_Click(object sender, EventArgs e)
        {
            if (clientbonbox.Text == "" || numerosclientbox.Text == "" || statuscombobox.Text == "" || servieebox.Text == "" )
            {
                MessageBox.Show("Si vous plait complete tous les informations");
            }
            else
            {
                if (statuscombobox.SelectedIndex == 1 && versebox.Text == "")
                {
                    MessageBox.Show("Si vous plait ecrire combien il Versé");
                }
                else if (MessageBox.Show("Voulez-vous vraiment imprimer et sauvegarder cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Specify the file path with the suggested name and directory
                   

                    // Now you can save and print the document to the specified file path
                    try
                    {

                        string subfolderPath = Path.Combine(Application.StartupPath, "Les Bon Stock");
                        Directory.CreateDirectory(subfolderPath); // Ensure the subfolder exists
                        string filePath = Path.Combine(subfolderPath, Nbonbox.Text + ".pdf"); // Replace with your directory

                        // Call the SaveAsPDF method to create and save the PDF
                        SaveAsPDF(filePath);

                        // Perform your database insert here if needed
                        try
                        {
                            string insertQuery = "INSERT INTO BonStock (Nbon, Produite, Quantite, Prix_unite, Total, Client,Numeros_Client,Payee,Serviee, La_date) " +
                                                 "VALUES (@nbon, @produit, @quantite, @prix, @total, @client,@numeros,@payee,@serviee, @la_date)";
                            SqlCommand command = new SqlCommand(insertQuery, dbconnect.getCon());
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@nbon", Nbonbox.Text);
                            command.Parameters.AddWithValue("@produit", produit1);
                            command.Parameters.AddWithValue("@quantite", quantite1);
                            command.Parameters.AddWithValue("@client", clientbonbox.Text);
                            command.Parameters.AddWithValue("@la_date", datelabel.Text);
                            command.Parameters.AddWithValue("@prix", string.Format("{0:N2}", prixparunite));
                            int total = prixparunite * int.Parse(quantite1);
                            command.Parameters.AddWithValue("@total", string.Format("{0:N2}", total));
                            command.Parameters.AddWithValue("@payee",statuscombobox.Text);
                            command.Parameters.AddWithValue("@serviee",servieebox.Text);
                            command.Parameters.AddWithValue("@numeros", numerosclientbox.Text);
                            dbconnect.OpenCon();
                            command.CommandText = insertQuery;
                            command.ExecuteNonQuery();
                            dbconnect.CloseCon();

                            string deletequrey = "DELETE FROM BonTable";
                            SqlCommand cmd = new SqlCommand(deletequrey, dbconnect.getCon());
                            dbconnect.OpenCon();
                            command.CommandText = deletequrey;
                            cmd.ExecuteNonQuery();
                            dbconnect.CloseCon();
                            

                            foreach (DataGridViewRow row in bongridview.Rows)
                            {
                                try
                                {
                                    int profiteofprod = getprofite(row.Cells["Produit"].Value.ToString());
                                    string insert = "INSERT INTO StatsTable (Nbon, Produit, Quantite, Total,Profite, La_date) " +
                                                         "VALUES (@nbon, @produit, @quantite, @total,@profite, @la_date)";
                                    command = new SqlCommand(insertQuery, dbconnect.getCon());
                                    dbconnect.OpenCon();
                                    command.CommandType = CommandType.Text;
                                    command.Parameters.AddWithValue("@nbon", Nbonbox.Text);
                                    command.Parameters.AddWithValue("@produit", row.Cells[0].Value.ToString());
                                    command.Parameters.AddWithValue("@quantite", row.Cells[1].Value.ToString());
                                    command.Parameters.AddWithValue("@total", row.Cells[3].Value.ToString().Replace(",", "").Replace(".00", ""));
                                    command.Parameters.AddWithValue("@la_date", datelabel.Text);
                                    command.Parameters.AddWithValue("@profite", profiteofprod * int.Parse(row.Cells[1].Value.ToString()));
                                    command.CommandText = insert;
                                    command.ExecuteNonQuery();
                                    
                                }
                                catch(Exception ex) { MessageBox.Show(ex.Message); }
                            }
                            dbconnect.CloseCon();



                            loaduser();
                            reste("touts");
                            getnbonid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error insert: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void versebox_TextChanged(object sender, EventArgs e)
        {
            decimal verse, total, reste;

            // Attempt to parse verse as a decimal
            if (decimal.TryParse(versebox.Text, out verse))
            {
                // Remove thousands separators from totallabel.Text and parse it as a decimal
                if (decimal.TryParse(totallabel.Text.Replace(",", ""), out total))
                {
                    reste = total - verse;
                    restebox.Text = string.Format("{0:N2}", reste);
                }
                else
                {
                    MessageBox.Show("Invalid total value in totallabel");
                }
            }
            else
            {
                MessageBox.Show("Invalid verse value in versebox");
            }
        }

        private void getnbonid()
        {
            int id = 0;
            string lastIdQuery = "SELECT TOP 1 Nbon FROM BonStock WHERE Nbon LIKE 'B%' AND Nbon NOT LIKE 'BL%' ORDER BY CAST(SUBSTRING(Nbon, 2, LEN(Nbon) - 1) AS INT) DESC";
            SqlCommand lastIdCommand = new SqlCommand(lastIdQuery, dbconnect.getCon());
            dbconnect.OpenCon();
            object lastIdResult = lastIdCommand.ExecuteScalar();
            dbconnect.CloseCon();

            if (lastIdResult != null && !DBNull.Value.Equals(lastIdResult))
            {
                string lastIdString = lastIdResult.ToString();
                if (int.TryParse(lastIdString.Substring(1), out id))
                {
                    id++;
                }
                else
                {
                    MessageBox.Show("Il y a une erreur dans la conversion.");
                }
            }
            Nbonbox.Text = "B" + id.ToString();
        }


        private void versebox_Enter(object sender, EventArgs e)
        {
           
        }
        private void reste(string touts)
        {
            produitecombobox.Text = "";
            quantitebonbox.Text = "";
            prixunitebonbox.Text = "";
            typedeprixbonbox.Text = "";
            totalbox.Text = "";
            if(touts == "touts")
            {
                clientbonbox.Text = "";
                numerosclientbox.Text = "";
            }

        }
        private int getprofite(string product)
        {
            try
            {
                string getqurey = "SELECT Profites FROM produiteTable WHERE Produit =@produit";
                cm = new SqlCommand(getqurey,dbconnect.getCon()) ;
                dbconnect.OpenCon() ;
                cm.Parameters.AddWithValue("@produit", product);
                object resault = cm.ExecuteScalar();
                dbconnect.CloseCon() ;
                if(resault != null)
                {
                    int count = Convert.ToInt32(resault);
                    return count;
                }
                else { return 0; }

            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);
                return 0;
            }



        }

        private void transportBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void quantitebonbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void prixunitebonbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void totalbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void prixunitebonbox_TextChanged(object sender, EventArgs e)
        {
            if (prixunitebonbox.Text != "" && quantitebonbox.Text != "")
            {
                float total = float.Parse(prixunitebonbox.Text.ToString()) * float.Parse(quantitebonbox.Text.ToString());
                totalbox.Text = total.ToString();
            }
        }

        private void quantitebonbox_TextChanged(object sender, EventArgs e)
        {
            if (prixunitebonbox.Text != "" && quantitebonbox.Text != "")
            {
                float total = float.Parse(prixunitebonbox.Text.ToString()) * float.Parse(quantitebonbox.Text.ToString());
                totalbox.Text = total.ToString();
            }
        }
    }
}
