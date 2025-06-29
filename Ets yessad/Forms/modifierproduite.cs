using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ets_yessad.Forms
{
    public partial class modifierproduite : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        string prod = "";
        public modifierproduite(string produite)
        {
          prod = produite;
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifierproduite_Load(object sender, EventArgs e)
        {

        }

        private void modifierbtnproduite_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (MessageBox.Show("Voulez-vous vraiment mettre à jour cet utilisateur ", "Update Record ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("UPDATE produiteTable SET Produit=@produit,Quantite=@quantite,Prix_gros=@prix_gros,Prix_dettailles=@prix_dettailles,Profites=@profites WHERE Produit=@prod", dbconnect.getCon());
                    command.Parameters.AddWithValue("@prod", prod);
                    command.Parameters.AddWithValue("@produit", produitboxmodifier.Text);
                    command.Parameters.AddWithValue("@quantite", quantitebox.Text);
                    command.Parameters.AddWithValue("@prix_gros", prixgrosbox.Text.Replace(",", "").Replace(".00", ""));
                    command.Parameters.AddWithValue("@prix_dettailles", prixdettailesmodifierbox.Text.Replace(",", "").Replace(".00", ""));
                    command.Parameters.AddWithValue("@profites", profitesmodifierbox.Text.Replace(",", "").Replace(".00", ""));

                    dbconnect.OpenCon();
                    command.ExecuteNonQuery();
                    dbconnect.CloseCon();
                    MessageBox.Show("modifier correctement");
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
