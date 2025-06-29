namespace Ets_yessad.Forms
{
    partial class FormSonBon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSonBon));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.Nbonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.produitecombosonbonbox = new Guna.UI.WinForms.GunaComboBox();
            this.clientsonbonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prixunitesonbonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitesonbonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouterbtnbon = new Guna.UI2.WinForms.Guna2Button();
            this.Sonbongridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nbon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.la_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalsonbonlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.savegarderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sonbongridview)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.datelabel);
            this.guna2Panel3.Controls.Add(this.Nbonbox);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Location = new System.Drawing.Point(7, 4);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.guna2Panel3.Size = new System.Drawing.Size(915, 48);
            this.guna2Panel3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "La date :";
            // 
            // datelabel
            // 
            this.datelabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(774, 12);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(95, 22);
            this.datelabel.TabIndex = 10;
            this.datelabel.Text = "Current Date";
            // 
            // Nbonbox
            // 
            this.Nbonbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nbonbox.BorderColor = System.Drawing.Color.Black;
            this.Nbonbox.BorderRadius = 3;
            this.Nbonbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nbonbox.DefaultText = "";
            this.Nbonbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nbonbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nbonbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nbonbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nbonbox.FillColor = System.Drawing.SystemColors.Control;
            this.Nbonbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nbonbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nbonbox.ForeColor = System.Drawing.Color.Black;
            this.Nbonbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nbonbox.Location = new System.Drawing.Point(70, 9);
            this.Nbonbox.Name = "Nbonbox";
            this.Nbonbox.PasswordChar = '\0';
            this.Nbonbox.PlaceholderText = "";
            this.Nbonbox.SelectedText = "";
            this.Nbonbox.Size = new System.Drawing.Size(138, 25);
            this.Nbonbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "N°Bon :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.produitecombosonbonbox);
            this.guna2Panel1.Controls.Add(this.clientsonbonbox);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.prixunitesonbonbox);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.quantitesonbonbox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(7, 55);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(915, 43);
            this.guna2Panel1.TabIndex = 12;
            // 
            // produitecombosonbonbox
            // 
            this.produitecombosonbonbox.BackColor = System.Drawing.Color.Transparent;
            this.produitecombosonbonbox.BaseColor = System.Drawing.SystemColors.Control;
            this.produitecombosonbonbox.BorderColor = System.Drawing.Color.Black;
            this.produitecombosonbonbox.BorderSize = 1;
            this.produitecombosonbonbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.produitecombosonbonbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produitecombosonbonbox.FocusedColor = System.Drawing.Color.Empty;
            this.produitecombosonbonbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.produitecombosonbonbox.ForeColor = System.Drawing.Color.Black;
            this.produitecombosonbonbox.FormattingEnabled = true;
            this.produitecombosonbonbox.Location = new System.Drawing.Point(282, 9);
            this.produitecombosonbonbox.Name = "produitecombosonbonbox";
            this.produitecombosonbonbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.produitecombosonbonbox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.produitecombosonbonbox.Radius = 3;
            this.produitecombosonbonbox.Size = new System.Drawing.Size(205, 26);
            this.produitecombosonbonbox.TabIndex = 10;
            this.produitecombosonbonbox.SelectedIndexChanged += new System.EventHandler(this.produitecombosonbonbox_SelectedIndexChanged);
            // 
            // clientsonbonbox
            // 
            this.clientsonbonbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientsonbonbox.BorderColor = System.Drawing.Color.Black;
            this.clientsonbonbox.BorderRadius = 3;
            this.clientsonbonbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientsonbonbox.DefaultText = "";
            this.clientsonbonbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientsonbonbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientsonbonbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientsonbonbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientsonbonbox.FillColor = System.Drawing.SystemColors.Control;
            this.clientsonbonbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientsonbonbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientsonbonbox.ForeColor = System.Drawing.Color.Black;
            this.clientsonbonbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientsonbonbox.Location = new System.Drawing.Point(70, 10);
            this.clientsonbonbox.Name = "clientsonbonbox";
            this.clientsonbonbox.PasswordChar = '\0';
            this.clientsonbonbox.PlaceholderText = "";
            this.clientsonbonbox.SelectedText = "";
            this.clientsonbonbox.Size = new System.Drawing.Size(134, 25);
            this.clientsonbonbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client :";
            // 
            // prixunitesonbonbox
            // 
            this.prixunitesonbonbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prixunitesonbonbox.BorderColor = System.Drawing.Color.Black;
            this.prixunitesonbonbox.BorderRadius = 3;
            this.prixunitesonbonbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixunitesonbonbox.DefaultText = "";
            this.prixunitesonbonbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prixunitesonbonbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prixunitesonbonbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prixunitesonbonbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prixunitesonbonbox.FillColor = System.Drawing.SystemColors.Control;
            this.prixunitesonbonbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prixunitesonbonbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prixunitesonbonbox.ForeColor = System.Drawing.Color.Black;
            this.prixunitesonbonbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prixunitesonbonbox.Location = new System.Drawing.Point(757, 10);
            this.prixunitesonbonbox.Name = "prixunitesonbonbox";
            this.prixunitesonbonbox.PasswordChar = '\0';
            this.prixunitesonbonbox.PlaceholderText = "";
            this.prixunitesonbonbox.SelectedText = "";
            this.prixunitesonbonbox.Size = new System.Drawing.Size(139, 25);
            this.prixunitesonbonbox.TabIndex = 7;
            this.prixunitesonbonbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixunitesonbonbox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix Unité :";
            // 
            // quantitesonbonbox
            // 
            this.quantitesonbonbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantitesonbonbox.BorderColor = System.Drawing.Color.Black;
            this.quantitesonbonbox.BorderRadius = 3;
            this.quantitesonbonbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantitesonbonbox.DefaultText = "";
            this.quantitesonbonbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantitesonbonbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantitesonbonbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantitesonbonbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantitesonbonbox.FillColor = System.Drawing.SystemColors.Control;
            this.quantitesonbonbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantitesonbonbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantitesonbonbox.ForeColor = System.Drawing.Color.Black;
            this.quantitesonbonbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantitesonbonbox.Location = new System.Drawing.Point(581, 10);
            this.quantitesonbonbox.Name = "quantitesonbonbox";
            this.quantitesonbonbox.PasswordChar = '\0';
            this.quantitesonbonbox.PlaceholderText = "";
            this.quantitesonbonbox.SelectedText = "";
            this.quantitesonbonbox.Size = new System.Drawing.Size(70, 25);
            this.quantitesonbonbox.TabIndex = 3;
            this.quantitesonbonbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitesonbonbox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit :";
            // 
            // ajouterbtnbon
            // 
            this.ajouterbtnbon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouterbtnbon.BorderRadius = 5;
            this.ajouterbtnbon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterbtnbon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterbtnbon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterbtnbon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterbtnbon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.ajouterbtnbon.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterbtnbon.ForeColor = System.Drawing.Color.White;
            this.ajouterbtnbon.Location = new System.Drawing.Point(742, 104);
            this.ajouterbtnbon.Name = "ajouterbtnbon";
            this.ajouterbtnbon.Size = new System.Drawing.Size(180, 40);
            this.ajouterbtnbon.TabIndex = 13;
            this.ajouterbtnbon.Text = "Ajouter au liste";
            this.ajouterbtnbon.Click += new System.EventHandler(this.ajouterbtnbon_Click);
            // 
            // Sonbongridview
            // 
            this.Sonbongridview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Sonbongridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Sonbongridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sonbongridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sonbongridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Sonbongridview.ColumnHeadersHeight = 20;
            this.Sonbongridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Sonbongridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nbon,
            this.client,
            this.produit,
            this.quantite,
            this.prix,
            this.total,
            this.la_date,
            this.suprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sonbongridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sonbongridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Sonbongridview.Location = new System.Drawing.Point(7, 160);
            this.Sonbongridview.Name = "Sonbongridview";
            this.Sonbongridview.RowHeadersVisible = false;
            this.Sonbongridview.Size = new System.Drawing.Size(619, 520);
            this.Sonbongridview.TabIndex = 14;
            this.Sonbongridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Sonbongridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Sonbongridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Sonbongridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Sonbongridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Sonbongridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Sonbongridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Sonbongridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.Sonbongridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Sonbongridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonbongridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Sonbongridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Sonbongridview.ThemeStyle.HeaderStyle.Height = 20;
            this.Sonbongridview.ThemeStyle.ReadOnly = false;
            this.Sonbongridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Sonbongridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Sonbongridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonbongridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Sonbongridview.ThemeStyle.RowsStyle.Height = 22;
            this.Sonbongridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Sonbongridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Sonbongridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sonbongridview_CellContentClick);
            // 
            // nbon
            // 
            this.nbon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nbon.HeaderText = "N°Bon";
            this.nbon.Name = "nbon";
            this.nbon.Width = 77;
            // 
            // client
            // 
            this.client.HeaderText = "Client";
            this.client.Name = "client";
            // 
            // produit
            // 
            this.produit.HeaderText = "Produite";
            this.produit.Name = "produit";
            // 
            // quantite
            // 
            this.quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            this.quantite.Width = 93;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // la_date
            // 
            this.la_date.HeaderText = "La Date";
            this.la_date.Name = "la_date";
            // 
            // suprimer
            // 
            this.suprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.suprimer.HeaderText = "suprimer";
            this.suprimer.Image = ((System.Drawing.Image)(resources.GetObject("suprimer.Image")));
            this.suprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.suprimer.Name = "suprimer";
            this.suprimer.Width = 74;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.totalsonbonlabel);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.FillColor = System.Drawing.Color.Black;
            this.guna2Panel4.ForeColor = System.Drawing.Color.Cyan;
            this.guna2Panel4.Location = new System.Drawing.Point(632, 160);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(290, 170);
            this.guna2Panel4.TabIndex = 15;
            // 
            // totalsonbonlabel
            // 
            this.totalsonbonlabel.AutoSize = true;
            this.totalsonbonlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalsonbonlabel.Font = new System.Drawing.Font("Dosis", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsonbonlabel.ForeColor = System.Drawing.Color.White;
            this.totalsonbonlabel.Location = new System.Drawing.Point(56, 63);
            this.totalsonbonlabel.Name = "totalsonbonlabel";
            this.totalsonbonlabel.Size = new System.Drawing.Size(59, 33);
            this.totalsonbonlabel.TabIndex = 1;
            this.totalsonbonlabel.Text = "0,00";
            this.totalsonbonlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total :";
            // 
            // savegarderbtn
            // 
            this.savegarderbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savegarderbtn.BorderRadius = 5;
            this.savegarderbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savegarderbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savegarderbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savegarderbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savegarderbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.savegarderbtn.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savegarderbtn.ForeColor = System.Drawing.Color.White;
            this.savegarderbtn.Location = new System.Drawing.Point(632, 637);
            this.savegarderbtn.Name = "savegarderbtn";
            this.savegarderbtn.Size = new System.Drawing.Size(290, 40);
            this.savegarderbtn.TabIndex = 24;
            this.savegarderbtn.Text = "suprimer et savegarder";
            this.savegarderbtn.Click += new System.EventHandler(this.savegarderbtn_Click);
            // 
            // FormSonBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 692);
            this.Controls.Add(this.savegarderbtn);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.Sonbongridview);
            this.Controls.Add(this.ajouterbtnbon);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.MinimumSize = new System.Drawing.Size(943, 731);
            this.Name = "FormSonBon";
            this.Text = "Son Bon";
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sonbongridview)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label datelabel;
        private Guna.UI2.WinForms.Guna2TextBox Nbonbox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox prixunitesonbonbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox quantitesonbonbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox clientsonbonbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button ajouterbtnbon;
        private Guna.UI2.WinForms.Guna2DataGridView Sonbongridview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label totalsonbonlabel;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button savegarderbtn;
        private Guna.UI.WinForms.GunaComboBox produitecombosonbonbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbon;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn la_date;
        private System.Windows.Forms.DataGridViewImageColumn suprimer;
    }
}