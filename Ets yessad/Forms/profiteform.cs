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

namespace Ets_yessad.Forms
{
    public partial class profiteform : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm;
        SqlDataReader dr;
        public profiteform()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string startDate = datepickerstart.Value.ToString("yyyy-MM-dd");
                string endDate = datetimepickerend.Value.ToString("yyyy-MM-dd");
                string query = "SELECT Profite FROM StatsTable WHERE La_date BETWEEN @StartDate AND @EndDate";
                cm = new SqlCommand(query, dbconnect.getCon());
                dbconnect.OpenCon();
                cm.Parameters.AddWithValue("@StartDate", startDate);
                cm.Parameters.AddWithValue("@EndDate", endDate);

                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += int.Parse(dr[0].ToString());
                }
                dbconnect.CloseCon();
                profitelabel.Text = string.Format("{0:N2}",Convert.ToDouble(count.ToString()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
