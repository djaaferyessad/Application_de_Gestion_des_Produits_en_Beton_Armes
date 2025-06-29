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
    public partial class quantiteform : Form
    {
        Dbconnect1 dbconnect = new Dbconnect1();
        SqlCommand cm;
        SqlDataReader dr;
        public quantiteform()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string startDate = datetimepickerend.Value.ToString("yyyy-MM-dd");
                string endDate = datepickerstart.Value.ToString("yyyy-MM-dd");
                string query = @"
                    SELECT 
                        Produit, 
                        SUM(Quantite) AS TotalQuantity, 
                        SUM(Profite) AS TotalProfite, 
                        SUM(Total) AS GrandTotal
                    FROM StatsTable
                    WHERE La_date BETWEEN @StartDate AND @EndDate
                    GROUP BY Produit";
                cm = new SqlCommand(query,dbconnect.getCon());
                dbconnect.OpenCon();
                cm.Parameters.AddWithValue("StartDate",startDate );
                cm.Parameters.AddWithValue("EndDate", startDate);

                dr = cm.ExecuteReader();
                bongridview.Rows.Clear();
                while (dr.Read()) 
                {
                    string productName = dr["Produit"].ToString();
                    int totalQuantity = Convert.ToInt32(dr["TotalQuantity"]);
                    float totalProfite = Convert.ToSingle(dr["TotalProfite"]);
                    float grandTotal = Convert.ToSingle(dr["GrandTotal"]);
                    bongridview.Rows.Add(productName, totalQuantity, string.Format("{0:N2}",Convert.ToDouble(grandTotal)), string.Format("{0:N2}", Convert.ToDouble(totalProfite)));
                }
                dbconnect.CloseCon();

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
