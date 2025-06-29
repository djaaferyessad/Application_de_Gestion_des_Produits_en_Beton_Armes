namespace Ets_yessad.Forms
{
    partial class FormProduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduit));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.prixdettailesbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prixgrosbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantitebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.produitbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.profitesbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ajouterbtnproduite = new Guna.UI2.WinForms.Guna2Button();
            this.produiteTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Ets_yessad.DataSet1();
            this.ajouterproduitegridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prixgros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prixdetailles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.produiteTableTableAdapter = new Ets_yessad.DataSet1TableAdapters.produiteTableTableAdapter();
            this.dataSet11 = new Ets_yessad.DataSet1();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produiteTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouterproduitegridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
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
            this.guna2Panel1.Controls.Add(this.prixdettailesbox);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.prixgrosbox);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.quantitebox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.produitbox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(915, 43);
            this.guna2Panel1.TabIndex = 0;
            // 
            // prixdettailesbox
            // 
            this.prixdettailesbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prixdettailesbox.BorderColor = System.Drawing.Color.Black;
            this.prixdettailesbox.BorderRadius = 3;
            this.prixdettailesbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixdettailesbox.DefaultText = "";
            this.prixdettailesbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prixdettailesbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prixdettailesbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prixdettailesbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prixdettailesbox.FillColor = System.Drawing.SystemColors.Control;
            this.prixdettailesbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prixdettailesbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prixdettailesbox.ForeColor = System.Drawing.Color.Black;
            this.prixdettailesbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prixdettailesbox.Location = new System.Drawing.Point(721, 9);
            this.prixdettailesbox.Name = "prixdettailesbox";
            this.prixdettailesbox.PasswordChar = '\0';
            this.prixdettailesbox.PlaceholderText = "";
            this.prixdettailesbox.SelectedText = "";
            this.prixdettailesbox.Size = new System.Drawing.Size(139, 25);
            this.prixdettailesbox.TabIndex = 7;
            this.prixdettailesbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixdettailesbox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix Détaillés :";
            // 
            // prixgrosbox
            // 
            this.prixgrosbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prixgrosbox.BorderColor = System.Drawing.Color.Black;
            this.prixgrosbox.BorderRadius = 3;
            this.prixgrosbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prixgrosbox.DefaultText = "";
            this.prixgrosbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prixgrosbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prixgrosbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prixgrosbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prixgrosbox.FillColor = System.Drawing.SystemColors.Control;
            this.prixgrosbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prixgrosbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prixgrosbox.ForeColor = System.Drawing.Color.Black;
            this.prixgrosbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prixgrosbox.Location = new System.Drawing.Point(470, 9);
            this.prixgrosbox.Name = "prixgrosbox";
            this.prixgrosbox.PasswordChar = '\0';
            this.prixgrosbox.PlaceholderText = "";
            this.prixgrosbox.SelectedText = "";
            this.prixgrosbox.Size = new System.Drawing.Size(131, 25);
            this.prixgrosbox.TabIndex = 5;
            this.prixgrosbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixgrosbox_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix gros :";
            // 
            // quantitebox
            // 
            this.quantitebox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantitebox.BorderColor = System.Drawing.Color.Black;
            this.quantitebox.BorderRadius = 3;
            this.quantitebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantitebox.DefaultText = "";
            this.quantitebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantitebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantitebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantitebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantitebox.FillColor = System.Drawing.SystemColors.Control;
            this.quantitebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantitebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantitebox.ForeColor = System.Drawing.Color.Black;
            this.quantitebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantitebox.Location = new System.Drawing.Point(303, 9);
            this.quantitebox.Name = "quantitebox";
            this.quantitebox.PasswordChar = '\0';
            this.quantitebox.PlaceholderText = "";
            this.quantitebox.SelectedText = "";
            this.quantitebox.Size = new System.Drawing.Size(70, 25);
            this.quantitebox.TabIndex = 3;
            this.quantitebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitebox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité :";
            // 
            // produitbox
            // 
            this.produitbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.produitbox.BorderColor = System.Drawing.Color.Black;
            this.produitbox.BorderRadius = 3;
            this.produitbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.produitbox.DefaultText = "";
            this.produitbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.produitbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.produitbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.produitbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.produitbox.FillColor = System.Drawing.SystemColors.Control;
            this.produitbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.produitbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.produitbox.ForeColor = System.Drawing.Color.Black;
            this.produitbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.produitbox.Location = new System.Drawing.Point(74, 9);
            this.produitbox.Name = "produitbox";
            this.produitbox.PasswordChar = '\0';
            this.produitbox.PlaceholderText = "";
            this.produitbox.SelectedText = "";
            this.produitbox.Size = new System.Drawing.Size(134, 25);
            this.produitbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit :";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.profitesbox);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 51);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(915, 48);
            this.guna2Panel2.TabIndex = 1;
            // 
            // profitesbox
            // 
            this.profitesbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profitesbox.BorderColor = System.Drawing.Color.Black;
            this.profitesbox.BorderRadius = 3;
            this.profitesbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profitesbox.DefaultText = "";
            this.profitesbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.profitesbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.profitesbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profitesbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.profitesbox.FillColor = System.Drawing.SystemColors.Control;
            this.profitesbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profitesbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.profitesbox.ForeColor = System.Drawing.Color.Black;
            this.profitesbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.profitesbox.Location = new System.Drawing.Point(82, 9);
            this.profitesbox.Name = "profitesbox";
            this.profitesbox.PasswordChar = '\0';
            this.profitesbox.PlaceholderText = "";
            this.profitesbox.SelectedText = "";
            this.profitesbox.Size = new System.Drawing.Size(140, 25);
            this.profitesbox.TabIndex = 9;
            this.profitesbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.profitesbox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profites :";
            // 
            // ajouterbtnproduite
            // 
            this.ajouterbtnproduite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouterbtnproduite.BorderRadius = 5;
            this.ajouterbtnproduite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterbtnproduite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterbtnproduite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterbtnproduite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterbtnproduite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.ajouterbtnproduite.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterbtnproduite.ForeColor = System.Drawing.Color.White;
            this.ajouterbtnproduite.Location = new System.Drawing.Point(740, 105);
            this.ajouterbtnproduite.Name = "ajouterbtnproduite";
            this.ajouterbtnproduite.Size = new System.Drawing.Size(180, 40);
            this.ajouterbtnproduite.TabIndex = 13;
            this.ajouterbtnproduite.Text = "Ajouter au liste";
            this.ajouterbtnproduite.Click += new System.EventHandler(this.ajouterbtnproduite_Click);
            // 
            // produiteTableBindingSource
            // 
            this.produiteTableBindingSource.DataMember = "produiteTable";
            this.produiteTableBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ajouterproduitegridview
            // 
            this.ajouterproduitegridview.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ajouterproduitegridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ajouterproduitegridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouterproduitegridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ajouterproduitegridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ajouterproduitegridview.ColumnHeadersHeight = 20;
            this.ajouterproduitegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ajouterproduitegridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit,
            this.Quantité,
            this.Prixgros,
            this.Prixdetailles,
            this.profites,
            this.suprimer,
            this.modifier});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ajouterproduitegridview.DefaultCellStyle = dataGridViewCellStyle12;
            this.ajouterproduitegridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ajouterproduitegridview.Location = new System.Drawing.Point(5, 157);
            this.ajouterproduitegridview.Name = "ajouterproduitegridview";
            this.ajouterproduitegridview.RowHeadersVisible = false;
            this.ajouterproduitegridview.ShowCellToolTips = false;
            this.ajouterproduitegridview.ShowEditingIcon = false;
            this.ajouterproduitegridview.Size = new System.Drawing.Size(915, 523);
            this.ajouterproduitegridview.TabIndex = 3;
            this.ajouterproduitegridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ajouterproduitegridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ajouterproduitegridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ajouterproduitegridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ajouterproduitegridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ajouterproduitegridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ajouterproduitegridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ajouterproduitegridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.ajouterproduitegridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ajouterproduitegridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ajouterproduitegridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ajouterproduitegridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ajouterproduitegridview.ThemeStyle.HeaderStyle.Height = 20;
            this.ajouterproduitegridview.ThemeStyle.ReadOnly = false;
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.Height = 22;
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ajouterproduitegridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ajouterproduitegridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ajouterproduitegridview_CellContentClick);
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // Prixgros
            // 
            this.Prixgros.HeaderText = "Prix gros";
            this.Prixgros.Name = "Prixgros";
            // 
            // Prixdetailles
            // 
            this.Prixdetailles.HeaderText = "Prix Détailles";
            this.Prixdetailles.Name = "Prixdetailles";
            // 
            // profites
            // 
            this.profites.HeaderText = "Profites";
            this.profites.Name = "profites";
            // 
            // suprimer
            // 
            this.suprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.suprimer.HeaderText = "suprimer";
            this.suprimer.Image = ((System.Drawing.Image)(resources.GetObject("suprimer.Image")));
            this.suprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.suprimer.Name = "suprimer";
            this.suprimer.ReadOnly = true;
            this.suprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.suprimer.Width = 69;
            // 
            // modifier
            // 
            this.modifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.modifier.HeaderText = "modifier";
            this.modifier.Image = ((System.Drawing.Image)(resources.GetObject("modifier.Image")));
            this.modifier.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.modifier.Name = "modifier";
            this.modifier.Width = 47;
            // 
            // produiteTableTableAdapter
            // 
            this.produiteTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "modifier";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn2.HeaderText = "modifier";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 692);
            this.Controls.Add(this.ajouterbtnproduite);
            this.Controls.Add(this.ajouterproduitegridview);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.MinimumSize = new System.Drawing.Size(943, 731);
            this.Name = "FormProduit";
            this.Text = "Ajouter des produit";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produiteTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouterproduitegridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox produitbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox prixdettailesbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox prixgrosbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox quantitebox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox profitesbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button ajouterbtnproduite;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produiteTableBindingSource;
        private DataSet1TableAdapters.produiteTableTableAdapter produiteTableTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2DataGridView ajouterproduitegridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prixgros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prixdetailles;
        private System.Windows.Forms.DataGridViewTextBoxColumn profites;
        private System.Windows.Forms.DataGridViewImageColumn suprimer;
        private System.Windows.Forms.DataGridViewImageColumn modifier;
    }
}