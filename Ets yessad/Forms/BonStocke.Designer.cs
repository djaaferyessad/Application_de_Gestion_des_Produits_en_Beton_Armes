namespace Ets_yessad.Forms
{
    partial class BonStocke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonStocke));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ajouterbtnbon = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiononserviee = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioserviee = new System.Windows.Forms.RadioButton();
            this.radiopayee = new System.Windows.Forms.RadioButton();
            this.radiononpayee = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recherchebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.bongridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Nbon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numéros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chiffeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.La_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprime = new System.Windows.Forms.DataGridViewImageColumn();
            this.suprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bongridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.ajouterbtnbon);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.Controls.Add(this.datelabel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.recherchebox);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(904, 46);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // ajouterbtnbon
            // 
            this.ajouterbtnbon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouterbtnbon.BorderRadius = 5;
            this.ajouterbtnbon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterbtnbon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterbtnbon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterbtnbon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterbtnbon.FillColor = System.Drawing.Color.Transparent;
            this.ajouterbtnbon.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterbtnbon.ForeColor = System.Drawing.Color.White;
            this.ajouterbtnbon.Image = ((System.Drawing.Image)(resources.GetObject("ajouterbtnbon.Image")));
            this.ajouterbtnbon.ImageSize = new System.Drawing.Size(16, 16);
            this.ajouterbtnbon.Location = new System.Drawing.Point(863, 5);
            this.ajouterbtnbon.Name = "ajouterbtnbon";
            this.ajouterbtnbon.Size = new System.Drawing.Size(35, 31);
            this.ajouterbtnbon.TabIndex = 14;
            this.ajouterbtnbon.Click += new System.EventHandler(this.ajouterbtnbon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiononserviee);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioserviee);
            this.groupBox1.Controls.Add(this.radiopayee);
            this.groupBox1.Controls.Add(this.radiononpayee);
            this.groupBox1.Location = new System.Drawing.Point(295, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 31);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiononserviee
            // 
            this.radiononserviee.AutoSize = true;
            this.radiononserviee.Location = new System.Drawing.Point(307, 11);
            this.radiononserviee.Name = "radiononserviee";
            this.radiononserviee.Size = new System.Drawing.Size(82, 17);
            this.radiononserviee.TabIndex = 19;
            this.radiononserviee.Text = "non Serviée";
            this.radiononserviee.UseVisualStyleBackColor = true;
            this.radiononserviee.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Touts";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioserviee
            // 
            this.radioserviee.AutoSize = true;
            this.radioserviee.Location = new System.Drawing.Point(248, 11);
            this.radioserviee.Name = "radioserviee";
            this.radioserviee.Size = new System.Drawing.Size(61, 17);
            this.radioserviee.TabIndex = 18;
            this.radioserviee.Text = "Serviée";
            this.radioserviee.UseVisualStyleBackColor = true;
            this.radioserviee.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiopayee
            // 
            this.radiopayee.AutoSize = true;
            this.radiopayee.Location = new System.Drawing.Point(85, 11);
            this.radiopayee.Name = "radiopayee";
            this.radiopayee.Size = new System.Drawing.Size(55, 17);
            this.radiopayee.TabIndex = 16;
            this.radiopayee.Text = "Payée";
            this.radiopayee.UseVisualStyleBackColor = true;
            this.radiopayee.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiononpayee
            // 
            this.radiononpayee.AutoSize = true;
            this.radiononpayee.Location = new System.Drawing.Point(157, 11);
            this.radiononpayee.Name = "radiononpayee";
            this.radiononpayee.Size = new System.Drawing.Size(76, 17);
            this.radiononpayee.TabIndex = 17;
            this.radiononpayee.Text = "non Payée";
            this.radiononpayee.UseVisualStyleBackColor = true;
            this.radiononpayee.CheckedChanged += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(691, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 22);
            this.label14.TabIndex = 15;
            this.label14.Text = "La date :";
            // 
            // datelabel
            // 
            this.datelabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(762, 9);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(95, 22);
            this.datelabel.TabIndex = 14;
            this.datelabel.Text = "Current Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche :";
            // 
            // recherchebox
            // 
            this.recherchebox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recherchebox.BorderColor = System.Drawing.Color.Black;
            this.recherchebox.BorderRadius = 3;
            this.recherchebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recherchebox.DefaultText = "";
            this.recherchebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.recherchebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.recherchebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recherchebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recherchebox.FillColor = System.Drawing.SystemColors.Control;
            this.recherchebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recherchebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recherchebox.ForeColor = System.Drawing.Color.Black;
            this.recherchebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recherchebox.Location = new System.Drawing.Point(105, 7);
            this.recherchebox.Name = "recherchebox";
            this.recherchebox.PasswordChar = '\0';
            this.recherchebox.PlaceholderText = "";
            this.recherchebox.SelectedText = "";
            this.recherchebox.Size = new System.Drawing.Size(183, 25);
            this.recherchebox.TabIndex = 3;
            this.recherchebox.TextChanged += new System.EventHandler(this.recherchebox_TextChanged);
            // 
            // bongridview
            // 
            this.bongridview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.bongridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bongridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bongridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bongridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bongridview.ColumnHeadersHeight = 20;
            this.bongridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bongridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nbon,
            this.produit,
            this.quantite,
            this.prix,
            this.total,
            this.Client,
            this.numéros,
            this.Chiffeur,
            this.Payee,
            this.Serviee,
            this.La_date,
            this.imprime,
            this.suprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bongridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.bongridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bongridview.Location = new System.Drawing.Point(12, 56);
            this.bongridview.Name = "bongridview";
            this.bongridview.RowHeadersVisible = false;
            this.bongridview.Size = new System.Drawing.Size(904, 614);
            this.bongridview.TabIndex = 12;
            this.bongridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.bongridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.bongridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.bongridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.bongridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.bongridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.bongridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bongridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.bongridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bongridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bongridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bongridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bongridview.ThemeStyle.HeaderStyle.Height = 20;
            this.bongridview.ThemeStyle.ReadOnly = false;
            this.bongridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bongridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bongridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bongridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.bongridview.ThemeStyle.RowsStyle.Height = 22;
            this.bongridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bongridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.bongridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bongridview_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Nbon
            // 
            this.Nbon.HeaderText = "N°bon";
            this.Nbon.Name = "Nbon";
            // 
            // produit
            // 
            this.produit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produit.HeaderText = "Produit";
            this.produit.Name = "produit";
            // 
            // quantite
            // 
            this.quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            this.quantite.Width = 79;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix ";
            this.prix.Name = "prix";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // numéros
            // 
            this.numéros.HeaderText = "N°Client";
            this.numéros.Name = "numéros";
            // 
            // Chiffeur
            // 
            this.Chiffeur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chiffeur.HeaderText = "Chiffeur";
            this.Chiffeur.Name = "Chiffeur";
            // 
            // Payee
            // 
            this.Payee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Payee.HeaderText = "Payée";
            this.Payee.Name = "Payee";
            this.Payee.Width = 70;
            // 
            // Serviee
            // 
            this.Serviee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Serviee.HeaderText = "Serviée";
            this.Serviee.Name = "Serviee";
            this.Serviee.Width = 77;
            // 
            // La_date
            // 
            this.La_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.La_date.HeaderText = "La Date";
            this.La_date.Name = "La_date";
            this.La_date.Width = 77;
            // 
            // imprime
            // 
            this.imprime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.imprime.HeaderText = "Imprimé";
            this.imprime.Image = ((System.Drawing.Image)(resources.GetObject("imprime.Image")));
            this.imprime.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imprime.Name = "imprime";
            this.imprime.Width = 59;
            // 
            // suprimer
            // 
            this.suprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.suprimer.HeaderText = "suprimer";
            this.suprimer.Image = ((System.Drawing.Image)(resources.GetObject("suprimer.Image")));
            this.suprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.suprimer.Name = "suprimer";
            this.suprimer.Width = 63;
            // 
            // BonStocke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 692);
            this.Controls.Add(this.bongridview);
            this.Controls.Add(this.guna2Panel1);
            this.MinimumSize = new System.Drawing.Size(943, 731);
            this.Name = "BonStocke";
            this.Text = "BonStocke";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bongridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox recherchebox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label datelabel;
        private Guna.UI2.WinForms.Guna2DataGridView bongridview;
        private System.Windows.Forms.RadioButton radiononpayee;
        private System.Windows.Forms.RadioButton radiopayee;
        private System.Windows.Forms.RadioButton radiononserviee;
        private System.Windows.Forms.RadioButton radioserviee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button ajouterbtnbon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nbon;
        private System.Windows.Forms.DataGridViewTextBoxColumn produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn numéros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chiffeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serviee;
        private System.Windows.Forms.DataGridViewTextBoxColumn La_date;
        private System.Windows.Forms.DataGridViewImageColumn imprime;
        private System.Windows.Forms.DataGridViewImageColumn suprimer;
    }
}