namespace Ets_yessad.Forms
{
    partial class connectform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dosis ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(244, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "ETS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dosis ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yessad";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(341, 186);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(61, 65);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressbar
            // 
            this.progressbar.BorderRadius = 5;
            this.progressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.progressbar.ForeColor = System.Drawing.Color.Coral;
            this.progressbar.Location = new System.Drawing.Point(0, 475);
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.progressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.progressbar.Size = new System.Drawing.Size(802, 10);
            this.progressbar.TabIndex = 4;
            this.progressbar.Text = "guna2ProgressBar1";
            this.progressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // connectform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "connectform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "connectform";
            this.Load += new System.EventHandler(this.connectform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressbar;
    }
}