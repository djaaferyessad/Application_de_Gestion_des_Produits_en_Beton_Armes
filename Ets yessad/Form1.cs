using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ets_yessad
{
    public partial class Form1 : Form
    {

        private Guna2Button currentbtn;
        private Form activeform;
        string acc = "";
        

        public Form1(string account)
        {

            InitializeComponent();
            acc = account;
            if(account == "guest") 
            {
            statbtn.Visible = false;
            }
        }

        
        //methodes 
        private Color Selectthemcolor()
        {
            string color = Themecolor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void Activatebutton(object btnsender)
        {
            if(btnsender!= null) 
            {
            if(currentbtn != (Guna2Button)btnsender)
                {
                    DesactivateButton();
                    Color color = Selectthemcolor();
                    currentbtn = (Guna2Button)btnsender;
                    currentbtn.BackColor = color;
                    currentbtn.ForeColor = Color.White;
                    currentbtn.Font = new System.Drawing.Font("Dosis", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            
            }
        }
        private void DesactivateButton()
        {
        foreach(Control prevbutton in mainpanal.Controls)    
          {
            if(prevbutton.GetType() == typeof(Guna2Button))
             {
                    prevbutton.BackColor = Color.FromArgb(39, 39, 39);
                    prevbutton.ForeColor = Color.Gainsboro;
                    prevbutton.Font = new System.Drawing.Font("Dosis", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

             }
            
            
          }
        
        
        }
        private void openchildform(Form childform,object btnsender)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            Activatebutton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;    
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            titlelabel.Text = childform.Text;

        }




        // button clicked 

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormProduit(acc), sender);
        }

        private void btnBon_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormBon(),sender);
        }

        private void btnSonBon_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.FormSonBon(),sender);
        }

       

        private void statbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.LesStatistics(),sender);    
        }

        private void bonlivbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.BonLivereecs(), sender);
        }

        private void stockbonbtn_Click(object sender, EventArgs e)
        {
           openchildform(new Forms.BonStocke(), sender);
        }
    }
}
