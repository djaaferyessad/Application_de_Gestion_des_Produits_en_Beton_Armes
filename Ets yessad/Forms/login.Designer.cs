namespace Ets_yessad.Forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.connecterbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.passwordbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connecterbtn
            // 
            this.connecterbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.connecterbtn.BorderRadius = 5;
            this.connecterbtn.BorderThickness = 2;
            this.connecterbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.connecterbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.connecterbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.connecterbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.connecterbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.connecterbtn.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connecterbtn.ForeColor = System.Drawing.Color.White;
            this.connecterbtn.Location = new System.Drawing.Point(15, 247);
            this.connecterbtn.Name = "connecterbtn";
            this.connecterbtn.Size = new System.Drawing.Size(313, 45);
            this.connecterbtn.TabIndex = 0;
            this.connecterbtn.Text = "Connecter";
            this.connecterbtn.Click += new System.EventHandler(this.connecterbtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.passwordbox);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.connecterbtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.guna2Panel1.Location = new System.Drawing.Point(226, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(340, 353);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.guna2Button1.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(15, 298);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(313, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Suivant";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.BorderRadius = 5;
            this.passwordbox.BorderThickness = 2;
            this.passwordbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordbox.DefaultText = "";
            this.passwordbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.passwordbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordbox.Location = new System.Drawing.Point(14, 136);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '●';
            this.passwordbox.PlaceholderText = "";
            this.passwordbox.SelectedText = "";
            this.passwordbox.Size = new System.Drawing.Size(313, 61);
            this.passwordbox.TabIndex = 2;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dosis ExtraBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(129, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button connecterbtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordbox;
        private System.Windows.Forms.Label label2;
    }
}