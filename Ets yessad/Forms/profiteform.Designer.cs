namespace Ets_yessad.Forms
{
    partial class profiteform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profiteform));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.datetimepickerend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickerstart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profitelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(525, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(121, 36);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Affichier";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // datetimepickerend
            // 
            this.datetimepickerend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.datetimepickerend.BorderRadius = 5;
            this.datetimepickerend.BorderThickness = 1;
            this.datetimepickerend.Checked = true;
            this.datetimepickerend.FillColor = System.Drawing.Color.LightGray;
            this.datetimepickerend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.datetimepickerend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerend.Location = new System.Drawing.Point(361, 12);
            this.datetimepickerend.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepickerend.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepickerend.Name = "datetimepickerend";
            this.datetimepickerend.Size = new System.Drawing.Size(144, 36);
            this.datetimepickerend.TabIndex = 8;
            this.datetimepickerend.Value = new System.DateTime(2023, 9, 16, 14, 31, 36, 134);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "jusqu\'à :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "A partir de :";
            // 
            // datepickerstart
            // 
            this.datepickerstart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.datepickerstart.BorderRadius = 5;
            this.datepickerstart.BorderThickness = 1;
            this.datepickerstart.Checked = true;
            this.datepickerstart.FillColor = System.Drawing.Color.LightGray;
            this.datepickerstart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.datepickerstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerstart.Location = new System.Drawing.Point(124, 12);
            this.datepickerstart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepickerstart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepickerstart.Name = "datepickerstart";
            this.datepickerstart.Size = new System.Drawing.Size(144, 36);
            this.datepickerstart.TabIndex = 5;
            this.datepickerstart.Value = new System.DateTime(2023, 9, 16, 14, 31, 36, 134);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.profitelabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.guna2ImageButton2);
            this.panel2.Location = new System.Drawing.Point(198, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 155);
            this.panel2.TabIndex = 10;
            // 
            // profitelabel
            // 
            this.profitelabel.AutoSize = true;
            this.profitelabel.Font = new System.Drawing.Font("Dosis", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitelabel.Location = new System.Drawing.Point(87, 45);
            this.profitelabel.Name = "profitelabel";
            this.profitelabel.Size = new System.Drawing.Size(53, 29);
            this.profitelabel.TabIndex = 2;
            this.profitelabel.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Profite";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(3, 36);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(78, 77);
            this.guna2ImageButton2.TabIndex = 0;
            // 
            // profiteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 313);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.datetimepickerend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepickerstart);
            this.MaximumSize = new System.Drawing.Size(677, 352);
            this.MinimumSize = new System.Drawing.Size(677, 352);
            this.Name = "profiteform";
            this.Text = "profiteform";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepickerend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerstart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label profitelabel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
    }
}