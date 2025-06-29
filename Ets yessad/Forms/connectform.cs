using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ets_yessad.Forms
{
    public partial class connectform : Form
    {
        public connectform()
        {
            InitializeComponent();
        }
        int startpoint = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            progressbar.Value = startpoint;
            if (progressbar.Value == 100)
            {
                timer1.Stop();
                progressbar.Value = 0;

                this.Hide();
                login f = new login() ;
                f.ShowDialog();
                Application.Exit();
               
            }
        }

        private void connectform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
