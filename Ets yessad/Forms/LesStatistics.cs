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

namespace Ets_yessad.Forms
{
    public partial class LesStatistics : Form
    {

        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cmd;
        SqlDataReader dr;
        public LesStatistics()
        {
            InitializeComponent();
            clientnumber();
            bonnumber();
            quantitedestock();
            quantitevendu();
            profiteettotal();
        }
        private void clientnumber()
        {
            try
            {
                string qurey = "SELECT COUNT(DISTINCT Client) FROM BonStock";
                cmd = new SqlCommand(qurey, dbconnect.getCon());
                dbconnect.OpenCon();
                object resault = cmd.ExecuteScalar();
                if (resault != null)
                {
                    int count = Convert.ToInt32(resault);
                    clientlabel.Text = count.ToString();
                }
                dbconnect.CloseCon();

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }

        }

        private void bonnumber()
        {
            try
            {
                string qurey = "SELECT COUNT(Nbon) FROM BonStock";
                cmd = new SqlCommand(qurey, dbconnect.getCon());
                dbconnect.OpenCon();
                object resault = cmd.ExecuteScalar();
                if (resault != null)
                {
                    int count = Convert.ToInt32(resault);
                    bon.Text = count.ToString();
                }
                dbconnect.CloseCon();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void quantitedestock()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM produiteTable", dbconnect.getCon());
                dbconnect.OpenCon();
                dr = cmd.ExecuteReader();
                int count = 0;

                while (dr.Read())
                {
                    count += int.Parse(dr["Quantite"].ToString());
                }

                stocklabel.Text = count.ToString();
                dbconnect.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quantitevendu()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM BonStock", dbconnect.getCon());
                dbconnect.OpenCon();
                dr = cmd.ExecuteReader();
                int count = 0;

                while (dr.Read())
                {
                    count += int.Parse(dr["Quantite"].ToString());
                }

                quantvendulabel.Text = count.ToString();
                dbconnect.CloseCon();

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void profiteettotal()
        {
            try
            {
                string profite = "SELECT * FROM StatsTable";
                cmd = new SqlCommand(profite, dbconnect.getCon());
                dbconnect.OpenCon();
                dr = cmd.ExecuteReader();
                int countprof = 0;
                int counttotal = 0;

                while (dr.Read())
                {
                    countprof += int.Parse(dr[4].ToString());
                    counttotal += int.Parse(dr[3].ToString());
                }
                dbconnect.CloseCon();
                profitelabel.Text = string.Format("{0:N2}",Convert.ToDouble(countprof.ToString())); 
                totallabel.Text = string.Format("{0:N2}", Convert.ToDouble(counttotal.ToString()));

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            totalfrom f = new totalfrom();
            f.Show();   
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            profiteform f = new profiteform();
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            quantiteform f = new quantiteform();
            f.Show();
        }
    }
}
   

