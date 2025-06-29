using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ets_yessad.Forms
{
    public partial class FormSonBon : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm;
        SqlDataReader dr;
        public FormSonBon()
        {
            InitializeComponent();
            loaduser();
            getnbonid();
            AddItemsToComboBox("SELECT * FROM produiteTable", produitecombosonbonbox);
            datelabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            totaldeargent();
        }
        public void loaduser()
        {
            int i = 0;
            Sonbongridview.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM SonBonTable ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                Sonbongridview.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), string.Format("{0:N2}", Convert.ToDouble(dr[4].ToString())), string.Format("{0:N2}", Convert.ToDouble(dr[5].ToString())), dr[6].ToString());
            }
            dr.Close();
            dbconnect.CloseCon();
        }



        private void ajouterbtnbon_Click(object sender, EventArgs e)
        { try
            {
                if(clientsonbonbox.Text == "" || quantitesonbonbox.Text == "" || produitecombosonbonbox.Text == "" || prixunitesonbonbox.Text == "")
                {
                    MessageBox.Show("enteré touts les information s'il vous plait");
                }
                else { 
                if (int.Parse(quantitesonbonbox.Text) > int.Parse(quantitedeproduite("")))
                {
                    MessageBox.Show("il ny a pas ce quantite dans le stock ");
                }
                else
                {
                    try
                    {

                        string insertQurey = "INSERT INTO SonBonTable (Nbon,Client,Produite,Quantite,Prix_unite,Total,La_date) VALUES (@nbon,@client,@produite,@quantite,@prixunite,@total,@ladate)";

                        SqlCommand command = new SqlCommand(insertQurey, dbconnect.getCon());
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@nbon", Nbonbox.Text);
                        command.Parameters.AddWithValue("@client", clientsonbonbox.Text);
                        command.Parameters.AddWithValue("@produite", produitecombosonbonbox.Text);
                        command.Parameters.AddWithValue("@quantite", quantitesonbonbox.Text);
                        command.Parameters.AddWithValue("@prixunite", prixunitesonbonbox.Text);
                        float total = float.Parse(prixunitesonbonbox.Text.ToString()) * float.Parse(quantitesonbonbox.Text.ToString());
                        command.Parameters.AddWithValue("@total", total);
                        command.Parameters.AddWithValue("@ladate", datelabel.Text);
                        dbconnect.OpenCon();
                        command.CommandText = insertQurey;
                        command.ExecuteNonQuery();
                        MessageBox.Show("added Successfully");
                        dbconnect.CloseCon();
                        loaduser();
                        getnbonid();
                        modifier_la_quantite(0, "ajouter", "");
                        totaldeargent();
                        reste("nontouts");
                        //  modifier_la_quantite(0, "ajouter", "");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void getnbonid()
        {

            int id = 00000000;
            if (Sonbongridview.Rows.Count > 0)
            {
                string lastIdQuery = "SELECT TOP 1 Nbon FROM SonBonTable ORDER BY Nbon DESC";
                SqlCommand lastIdCommand = new SqlCommand(lastIdQuery, dbconnect.getCon());
                dbconnect.OpenCon();
                object lastIdResult = lastIdCommand.ExecuteScalar();
                dbconnect.CloseCon();

                if (lastIdResult != null && !DBNull.Value.Equals(lastIdResult))
                {
                    string lastIdString = lastIdResult.ToString();

                    // Extract the numeric part and convert it to an integer
                    string numericPart = new string(lastIdString.Where(char.IsDigit).ToArray());
                    if (int.TryParse(numericPart, out id))
                    {
                        id++; // Increment the ID by 1
                    }
                    else
                    {
                        MessageBox.Show("il ya error dans la converter");
                    }
                }
                Nbonbox.Text = "SB" + id.ToString();

            }
            else
            {
                string lastIdQuery = "SELECT TOP 1 Nbon FROM BonStock WHERE Nbon LIKE 'SB%' ORDER BY Nbon DESC";
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
                Nbonbox.Text = "SB" + id.ToString();
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

        public void modifier_la_quantite(int quantiteajouter, string from, string prod)
        {
            try
            {

                string initialquantite = "";
                int noveauquan = 0;
                if (from == "ajouter")
                {
                    initialquantite = quantitedeproduite("");
                    noveauquan = int.Parse(initialquantite) - int.Parse(quantitesonbonbox.Text);
                }
                if (from == "delete")
                {
                    initialquantite = quantitedeproduite(prod);
                    noveauquan = int.Parse(initialquantite) + quantiteajouter;
                }
                SqlCommand command = new SqlCommand("UPDATE produiteTable SET Quantite=@quantite WHERE Produit=@prod", dbconnect.getCon());
                if (from == "ajouter")
                    command.Parameters.AddWithValue("@prod", produitecombosonbonbox.Text);
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

        public string quantitedeproduite(string prod)
        {
            try
            {
                dbconnect.OpenCon();
                cm = new SqlCommand("SELECT Quantite FROM produiteTable WHERE Produit=@produit", dbconnect.getCon());
                if (prod == "")
                    cm.Parameters.AddWithValue("@produit", produitecombosonbonbox.Text);
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

        private void Sonbongridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = Sonbongridview.Columns[e.ColumnIndex].Name;
            if (colName == "suprimer")
            {
                try
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string valueStr = Sonbongridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                        if (int.TryParse(valueStr, out int value))
                        {
                            string prod = Sonbongridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                            string nbon = Sonbongridview.Rows[e.RowIndex].Cells[0].Value.ToString();

                            dbconnect.OpenCon();
                            cm = new SqlCommand("DELETE FROM SonBonTable WHERE Nbon = @nbon", dbconnect.getCon());
                            cm.Parameters.AddWithValue("@nbon", nbon);
                            cm.ExecuteNonQuery();
                            dbconnect.CloseCon();
                            MessageBox.Show("L’utilisateur a été supprimé avec succès!");
                            loaduser();
                            modifier_la_quantite(value, "delete", prod);
                            totaldeargent();
                            getnbonid();

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

        private void produitecombosonbonbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantitesonbonbox.Text = quantitedeproduite("");
            try
            {
                dbconnect.OpenCon();
                cm = new SqlCommand("SELECT Prix_dettailles FROM produiteTable WHERE Produit=@produit", dbconnect.getCon());
                cm.Parameters.AddWithValue("@produit", produitecombosonbonbox.Text);

                // Execute the SQL command and retrieve the value from the result set
                object result = cm.ExecuteScalar();

                // Check if the result is not null
                if (result != null)
                {
                    // Convert the result to a string and set it to prixunitebonbox.Text
                    prixunitesonbonbox.Text = result.ToString();
                }
                else
                {
                    // Handle the case where no result was found
                    prixunitesonbonbox.Text = "N/A"; // or any appropriate default value
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

        private void totaldeargent()
        {
            decimal totalSum = 0; // Use decimal to handle decimal values

            foreach (DataGridViewRow row in Sonbongridview.Rows)
            {
                // Check if the row is not a header row and the "Total" column exists
                if (!row.IsNewRow && row.Cells["Total"].Value != null)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString().Replace(",", "").Replace(".00", ""), out cellValue))
                    {
                        totalSum += cellValue;
                    }
                }
            }

            totalsonbonlabel.Text = string.Format("{0:N2}", totalSum);
        }

        private void savegarderbtn_Click(object sender, EventArgs e)
        {
            if (Sonbongridview.RowCount == 0)
            {
                MessageBox.Show("il nya pas des donné pour savegarder");
            }
            else { 
            foreach (DataGridViewRow row in Sonbongridview.Rows)
            {
                string cellValue = row.Cells[0].Value.ToString();
                string insertQurey = "INSERT INTO BonStock (Nbon,Produite,Quantite,Prix_unite,Total,Client,La_date) VALUES (@nbon,@produit,@quantite,@prix,@total,@client,@la_date)";

                SqlCommand command = new SqlCommand(insertQurey, dbconnect.getCon());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@nbon", row.Cells[0].Value.ToString());
                command.Parameters.AddWithValue("@produit", row.Cells[2].Value.ToString());
                command.Parameters.AddWithValue("@quantite", row.Cells[3].Value.ToString());
                command.Parameters.AddWithValue("@client", row.Cells[1].Value.ToString());
                command.Parameters.AddWithValue("@la_date", row.Cells[6].Value.ToString());
                command.Parameters.AddWithValue("@prix", row.Cells[4].Value.ToString());
                command.Parameters.AddWithValue("@total", row.Cells[5].Value.ToString());
                dbconnect.OpenCon();
                command.CommandText = insertQurey;
                command.ExecuteNonQuery();
            }
            dbconnect.CloseCon();
                foreach (DataGridViewRow row in Sonbongridview.Rows)
                {
                    try
                    {
                        int profiteofprod = getprofite(row.Cells[2].Value.ToString());
                        string insert = "INSERT INTO StatsTable (Nbon, Produit, Quantite, Total,Profite, La_date) " +
                                             "VALUES (@nbon, @produit, @quantite, @total,@profite, @la_date)";
                        SqlCommand command = new SqlCommand(insert, dbconnect.getCon());
                        dbconnect.OpenCon();
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@nbon", row.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@produit", row.Cells[2].Value.ToString());
                        command.Parameters.AddWithValue("@quantite", row.Cells[3].Value.ToString());
                        command.Parameters.AddWithValue("@total", row.Cells[5].Value.ToString().Replace(",","").Replace(".00",""));
                        command.Parameters.AddWithValue("@la_date", row.Cells[6].Value.ToString());
                        command.Parameters.AddWithValue("@profite", profiteofprod * int.Parse(row.Cells[3].Value.ToString()));
                        command.CommandText = insert;
                        command.ExecuteNonQuery();
                        dbconnect.CloseCon();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                string deletequrey = "DELETE FROM SonBonTable";
            SqlCommand cmd = new SqlCommand(@deletequrey, dbconnect.getCon());
            dbconnect.OpenCon();
            cmd.CommandText = deletequrey;
            cmd.ExecuteNonQuery();
            dbconnect.CloseCon();
            loaduser();
            getnbonid();
                reste("touts");
            MessageBox.Show("l'operation est bien effectue ");
        }
        }

        private void reste(string touts)
        {
            prixunitesonbonbox.Text = "";
            produitecombosonbonbox.Text = "";
            quantitesonbonbox.Text = "";
            if (touts == "touts")
                clientsonbonbox.Text = "";

        }
        private int getprofite(string product)
        {
            try
            {
                string getqurey = "SELECT Profites FROM produiteTable WHERE Produit =@produit";
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

        private void quantitesonbonbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void prixunitesonbonbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }
    }
}
