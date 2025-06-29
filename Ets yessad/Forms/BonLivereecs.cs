using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ets_yessad.Forms
{
    public partial class BonLivereecs : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm;
        SqlDataReader dr;
        int i = 0;
        string produit1 = "";
        string quantite1 = "";
        public BonLivereecs()
        {
            InitializeComponent();
            loaduser();
            AddItemsToComboBox("SELECT * FROM produiteTable", produitecombobox);
            datelabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            getnbonid();
        }

        public void loaduser()
        {
            string formattedNumber1 = "";
           
            bongridview.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM BonLivere ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                if(i == 1) { produit1 = dr[0].ToString(); quantite1 = dr[1].ToString();  }
                bongridview.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            dbconnect.CloseCon();
        }

        private void ajouterbtnbon_Click(object sender, EventArgs e)
        {
            if (produitecombobox.Text == "" || quantitebonbox.Text == "" )
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

                        string insertQurey = "INSERT INTO BonLivere (Produit,Quantite) VALUES (@produit,@quantite)";

                        SqlCommand command = new SqlCommand(insertQurey, dbconnect.getCon());
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@produit", produitecombobox.Text);
                        command.Parameters.AddWithValue("@quantite", quantitebonbox.Text);

                        dbconnect.OpenCon();
                        command.CommandText = insertQurey;
                        command.ExecuteNonQuery();
                        MessageBox.Show("added Successfully");
                        dbconnect.CloseCon();
                        loaduser();
                        modifier_la_quantite(0, "ajouter", "");
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
        public string quantitedeproduite(string prod)
        {
            try
            {
                dbconnect.OpenCon();
                cm = new SqlCommand("SELECT Quantite FROM produiteTable WHERE Produit=@produit", dbconnect.getCon());
                if (prod == "")
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

        public void modifier_la_quantite(int quantiteajouter, string from, string prod)
        {
            try
            {

                string initialquantite = "";
                int noveauquan = 0;
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
            catch (Exception ex)
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
                            cm = new SqlCommand("DELETE FROM BonLivere WHERE Produit = @produit", dbconnect.getCon());
                            cm.Parameters.AddWithValue("@produit", prod);
                            cm.ExecuteNonQuery();
                            dbconnect.CloseCon();
                            MessageBox.Show("L’utilisateur a été supprimé avec succès!");
                            loaduser();
                            modifier_la_quantite(value, "delete", prod);
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
            graphics.DrawString("Chiffeur: " + chiffeurbox.Text, font, brush, new XPoint(20, 300));
            graphics.DrawString("Time : " + now.Hour.ToString("00") + ":" + now.Minute.ToString("00"), font, brush, new XPoint(450, 265));
            graphics.DrawString("Le: " + datetimepicker.Value.ToString("yyyy-MM-dd"), font, brush, new XPoint(450, 280));
            graphics.DrawString("Matricule: " + matriculebox.Text, font, brush, new XPoint(450, 300));
            graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, 320));
            graphics.DrawString("Quantité", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(35, 340));
            graphics.DrawString("Description", new XFont("Arial", 20, XFontStyle.Bold), brush, new XPoint(220, 340));
            graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, 360));
            cm = new SqlCommand("SELECT * FROM BonLivere ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            int row = 370;
            while (dr.Read())
            {
                graphics.DrawString(dr[1].ToString(), font, brush, new XPoint(45, row));
                graphics.DrawString(dr[0].ToString(), font, brush, new XPoint(200, row));
                graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------", font, brush, new XPoint(20, row + 10));
                row = row + 20;

            }
            row = 700;
            dr.Close();
            dbconnect.CloseCon();
            graphics.DrawString("Merci pour votre visite ", font, brush, new XPoint(270, row + 110));




            // ... Continue drawing the rest of the content using drawing commands ...

            // Save the PDF document to the specified file path
            document.Save(filePath);

            // Close the document
            document.Close();

            // Show a message to indicate successful saving
            MessageBox.Show("Fichier PDF enregistré avec succès sur : " + filePath);
        }

        private void voirbonbtn_Click(object sender, EventArgs e)
        {
            if (clientbonbox.Text == "" || chiffeurbox.Text == "" || matriculebox.Text == "" || destinationbox.Text == "")
            {
                MessageBox.Show("Si vous plait complete tous les information");
            }
            else
            {
               
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();    
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image logoImage = Image.FromFile(Application.StartupPath + @"\icons ets yessad\etslogo.png");
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
            e.Graphics.DrawString("N°bon: " + Nbonbox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 270));
            e.Graphics.DrawString("Client:  " + clientbonbox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString("Chiffeur:  " + chiffeurbox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 330));
            e.Graphics.DrawString("Le:  " + datetimepicker.Value.ToString("yyyy-MM-dd"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(620, 300));
            e.Graphics.DrawString("Matricule :  " + matriculebox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(620, 330));

            e.Graphics.DrawImage(logoImage, destinationRect);
            logoImage.Dispose();
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString("Quantité", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 370));
            e.Graphics.DrawString("DESCRIPTION", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 370));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 410));

            cm = new SqlCommand("SELECT * FROM BonLivere ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            int row = 430;
            while (dr.Read())
            {
                e.Graphics.DrawString(dr[1].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(40, row));
                e.Graphics.DrawString(dr[0].ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, row));
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, row + 20));
                row = row + 40;

            }
            dr.Close();
            dbconnect.CloseCon();
            e.Graphics.DrawString("Merci pour votre visite ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(330, 1070));
        }

        private void imprimeressavebtn_Click(object sender, EventArgs e)
        {
            if (clientbonbox.Text == "" || chiffeurbox.Text == "" || matriculebox.Text == "" || destinationbox.Text == "")
            {
                MessageBox.Show("Si vous plait complete tous les information");
            }
            else
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
                    MessageBox.Show("Fichier PDF enregistré et imprimé avec succès sur :" + filePath);
                    try
                    {
                        string insertQurey = "INSERT INTO BonStock (Nbon,Produite,Quantite,Prix_unite,Total,Client,Chiffeur,La_date) VALUES (@nbon,@produit,@quantite,@prix,@total,@client,@chiffeur,@la_date)";

                        SqlCommand command = new SqlCommand(insertQurey, dbconnect.getCon());
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@nbon", Nbonbox.Text);
                        command.Parameters.AddWithValue("@produit", produit1);
                        command.Parameters.AddWithValue("@quantite", quantite1);
                        command.Parameters.AddWithValue("@client", clientbonbox.Text);
                        command.Parameters.AddWithValue("@chiffeur", chiffeurbox.Text);
                        command.Parameters.AddWithValue("@la_date", datetimepicker.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@prix", 0);
                        command.Parameters.AddWithValue("@total", 0);

                        dbconnect.OpenCon();
                        command.CommandText = insertQurey;
                        command.ExecuteNonQuery();
                        dbconnect.CloseCon();
                        foreach (DataGridViewRow row in bongridview.Rows)
                        {
                            try
                            {
                                int profiteofprod = getprofite(row.Cells["Produit"].Value.ToString(), "Profites");
                                int totalofprod = getprofite(row.Cells["Produit"].Value.ToString(), "Prix_gros");
                                string insert = "INSERT INTO StatsTable (Nbon, Produit, Quantite, Total,Profite, La_date) " +
                                                     "VALUES (@nbon, @produit, @quantite, @total,@profite, @la_date)";
                                command = new SqlCommand(insert, dbconnect.getCon());
                                dbconnect.OpenCon();
                                command.CommandType = CommandType.Text;
                                command.Parameters.AddWithValue("@nbon", Nbonbox.Text);
                                command.Parameters.AddWithValue("@produit", row.Cells[0].Value.ToString());
                                command.Parameters.AddWithValue("@quantite", row.Cells[1].Value.ToString());
                                command.Parameters.AddWithValue("@total", totalofprod * int.Parse(row.Cells[1].Value.ToString()));
                                command.Parameters.AddWithValue("@la_date", datelabel.Text);
                                command.Parameters.AddWithValue("@profite", profiteofprod * int.Parse(row.Cells[1].Value.ToString()));
                                command.CommandText = insert;
                                command.ExecuteNonQuery();
                                dbconnect.CloseCon();
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }

                        bongridview.Rows.Clear();
                        getnbonid();
                        string deletequrey = "DELETE FROM BonLivere";
                        SqlCommand cmd = new SqlCommand(deletequrey, dbconnect.getCon());
                        dbconnect.OpenCon();
                        command.CommandText = deletequrey;
                        cmd.ExecuteNonQuery();
                        dbconnect.CloseCon();
                        

                        loaduser();
                        reste("touts");

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

        private void produitecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantitebonbox.Text = quantitedeproduite("");
        }
        private void getnbonid()
        {
            int id = 0;
            string lastIdQuery = "SELECT TOP 1 Nbon FROM BonStock WHERE Nbon LIKE 'BL%' ORDER BY Nbon DESC";
            SqlCommand lastIdCommand = new SqlCommand(lastIdQuery, dbconnect.getCon());
            dbconnect.OpenCon();
            object lastIdResult = lastIdCommand.ExecuteScalar();
            dbconnect.CloseCon();

            if (lastIdResult != null && !DBNull.Value.Equals(lastIdResult))
            {
                string lastIdString = lastIdResult.ToString();

                // Extract the numeric part and convert it to an integer
                string numericPart = lastIdString.Substring(2); // Skip the 'SB' prefix
                if (int.TryParse(numericPart, out id))
                {
                    id++; // Increment the ID by 1
                }
                else
                {
                    MessageBox.Show("Il y a une erreur dans la conversion.");
                }
            }
            Nbonbox.Text = "BL" + id.ToString(); // Format the ID with leading zeros
        }
        private void reste(string touts)
        {
            produitecombobox.Text = "";
            quantitebonbox.Text = "";
            if (touts == "touts")
            {
                clientbonbox.Text = "";
                chiffeurbox.Text = "";
            }

        }

        private int getprofite(string product , string name)
        {
            try
            {
                string getqurey = "SELECT " + name +" FROM produiteTable WHERE Produit =@produit";
                cm = new SqlCommand(getqurey, dbconnect.getCon());
                dbconnect.OpenCon();
                cm.Parameters.AddWithValue("@produit", product);
                object resault = cm.ExecuteScalar();
                dbconnect.CloseCon();
                if (resault != null)
                {
                    int count = Convert.ToInt32(resault);
                    return count;
                }
                else { return 0; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
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
    }
}
