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
using static System.Net.Mime.MediaTypeNames;

namespace Ets_yessad.Forms
{
    public partial class login : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1("guest");
            this.Hide();
            f.ShowDialog();
        }

        private void connecterbtn_Click(object sender, EventArgs e)
        {
            string password = passwordbox.Text;
            string selectQurey1 = "SELECT * FROM login WHERE password = @password";
            cm = new SqlCommand(selectQurey1, dbconnect.getCon());
            cm.Parameters.AddWithValue("@password", password);
            dbconnect.OpenCon();
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                Form1 f = new Form1("admin");
                this.Hide();
                f.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("mot de passe incorrect ", "Warning Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dbconnect.CloseCon();
        }
    }
}

