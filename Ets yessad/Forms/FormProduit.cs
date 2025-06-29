using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ets_yessad.Forms
{
    public partial class FormProduit : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm;
        SqlDataReader dr;
        string account;
        public FormProduit(string acc)
        {
            InitializeComponent();
            account = acc;
            loaduser();
        }

        public void loaduser()
        {
            int i = 0;
            ajouterproduitegridview.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM produiteTable ", dbconnect.getCon());
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                if(account == "guest")
                    ajouterproduitegridview.Rows.Add(dr[0].ToString(), dr[1].ToString(), string.Format("{0:N2}", Convert.ToDouble(dr[2].ToString())), string.Format("{0:N2}", Convert.ToDouble(dr[3].ToString())));
                else
                    ajouterproduitegridview.Rows.Add(dr[0].ToString(), dr[1].ToString(), string.Format("{0:N2}", Convert.ToDouble(dr[2].ToString())), string.Format("{0:N2}", Convert.ToDouble(dr[3].ToString())), string.Format("{0:N2}", Convert.ToDouble(dr[4].ToString())));
            }
            dr.Close();
            dbconnect.CloseCon();
        }

        private void ajouterbtnproduite_Click(object sender, EventArgs e)
        {
            if(produitbox.Text == "" || quantitebox.Text == "" || prixgrosbox.Text == "" || prixdettailesbox.Text == "" || profitesbox.Text == "")
            {
                MessageBox.Show("Si l vous plait enter  touts les information ");
            }
            else
            { 
            try
            {

                string insertQurey = "INSERT INTO produiteTable (Produit,Quantite,Prix_gros,Prix_dettailles,Profites) VALUES (@produit,@quantite,@prixgros,@prixdettailles,@profites)";

                SqlCommand command = new SqlCommand(insertQurey, dbconnect.getCon());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@produit", produitbox.Text);
                command.Parameters.AddWithValue("@quantite", quantitebox.Text);
                command.Parameters.AddWithValue("@prixgros", prixgrosbox.Text);
                command.Parameters.AddWithValue("@prixdettailles", prixdettailesbox.Text);
                command.Parameters.AddWithValue("@profites", profitesbox.Text);  
                dbconnect.OpenCon();
                command.CommandText = insertQurey;
                command.ExecuteNonQuery();
                MessageBox.Show("added Successfully");
                dbconnect.CloseCon();
                loaduser();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            }
        }

        private void ajouterproduitegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = ajouterproduitegridview.Columns[e.ColumnIndex].Name;
            if (colName == "modifier")
            {
               
                modifierproduite edit = new modifierproduite(ajouterproduitegridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                edit.produitboxmodifier.Text = ajouterproduitegridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                edit.quantitebox.Text = ajouterproduitegridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                edit.prixgrosbox.Text = ajouterproduitegridview.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(",", "").Replace(".00", "");
                edit.prixdettailesmodifierbox.Text = ajouterproduitegridview.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(",","").Replace(".00","") ;
                if(account != "guest")
                edit.profitesmodifierbox.Text = ajouterproduitegridview.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(",", "").Replace(".00", "");
                edit.ShowDialog();
                loaduser();

            }
            if (colName == "suprimer")
            {
                try
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbconnect.OpenCon();
                        cm = new SqlCommand("DELETE FROM produiteTable WHERE Produit = @produit", dbconnect.getCon());
                        cm.Parameters.AddWithValue("@produit", ajouterproduitegridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                        cm.ExecuteNonQuery();
                        dbconnect.CloseCon();
                        MessageBox.Show("L’utilisateur a été supprimé avec succès!");
                        loaduser();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);               }
            }
        }

        private void quantitebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void prixgrosbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void prixdettailesbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void profitesbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the keypress event to prevent the character from being entered
                e.Handled = true;
            }
        }
    }
}
