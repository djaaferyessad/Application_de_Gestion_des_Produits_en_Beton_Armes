namespace Ets_yessad.Forms
{
    partial class BonLivereecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonLivereecs));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.Nbonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.destinationbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matriculebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chiffeurbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clientbonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.produitecombobox = new Guna.UI.WinForms.GunaComboBox();
            this.quantitebonbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ajouterbtnbon = new Guna.UI2.WinForms.Guna2Button();
            this.bongridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.imprimeressavebtn = new Guna.UI2.WinForms.Guna2Button();
            this.voirbonbtn = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.datetimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bongridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.datetimepicker);
            this.guna2Panel3.Controls.Add(this.label14);
            this.guna2Panel3.Controls.Add(this.datelabel);
            this.guna2Panel3.Controls.Add(this.Nbonbox);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Location = new System.Drawing.Point(5, 3);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.guna2Panel3.Size = new System.Drawing.Size(915, 48);
            this.guna2Panel3.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(723, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "La date :";
            // 
            // datelabel
            // 
            this.datelabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(794, 13);
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
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.destinationbox);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.matriculebox);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.chiffeurbox);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.clientbonbox);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 55);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(915, 48);
            this.guna2Panel2.TabIndex = 12;
            // 
            // destinationbox
            // 
            this.destinationbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.destinationbox.BorderColor = System.Drawing.Color.Black;
            this.destinationbox.BorderRadius = 3;
            this.destinationbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationbox.DefaultText = "";
            this.destinationbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.destinationbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.destinationbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationbox.FillColor = System.Drawing.SystemColors.Control;
            this.destinationbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destinationbox.ForeColor = System.Drawing.Color.Black;
            this.destinationbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationbox.Location = new System.Drawing.Point(764, 9);
            this.destinationbox.Name = "destinationbox";
            this.destinationbox.PasswordChar = '\0';
            this.destinationbox.PlaceholderText = "";
            this.destinationbox.SelectedText = "";
            this.destinationbox.Size = new System.Drawing.Size(146, 25);
            this.destinationbox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destination :";
            // 
            // matriculebox
            // 
            this.matriculebox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.matriculebox.BorderColor = System.Drawing.Color.Black;
            this.matriculebox.BorderRadius = 3;
            this.matriculebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matriculebox.DefaultText = "";
            this.matriculebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.matriculebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.matriculebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matriculebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matriculebox.FillColor = System.Drawing.SystemColors.Control;
            this.matriculebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matriculebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.matriculebox.ForeColor = System.Drawing.Color.Black;
            this.matriculebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matriculebox.Location = new System.Drawing.Point(527, 9);
            this.matriculebox.Name = "matriculebox";
            this.matriculebox.PasswordChar = '\0';
            this.matriculebox.PlaceholderText = "";
            this.matriculebox.SelectedText = "";
            this.matriculebox.Size = new System.Drawing.Size(130, 25);
            this.matriculebox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Matricule :";
            // 
            // chiffeurbox
            // 
            this.chiffeurbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chiffeurbox.BorderColor = System.Drawing.Color.Black;
            this.chiffeurbox.BorderRadius = 3;
            this.chiffeurbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chiffeurbox.DefaultText = "";
            this.chiffeurbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chiffeurbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chiffeurbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chiffeurbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chiffeurbox.FillColor = System.Drawing.SystemColors.Control;
            this.chiffeurbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chiffeurbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chiffeurbox.ForeColor = System.Drawing.Color.Black;
            this.chiffeurbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chiffeurbox.Location = new System.Drawing.Point(289, 9);
            this.chiffeurbox.Name = "chiffeurbox";
            this.chiffeurbox.PasswordChar = '\0';
            this.chiffeurbox.PlaceholderText = "";
            this.chiffeurbox.SelectedText = "";
            this.chiffeurbox.Size = new System.Drawing.Size(148, 25);
            this.chiffeurbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Chiffeur :";
            // 
            // clientbonbox
            // 
            this.clientbonbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientbonbox.BorderColor = System.Drawing.Color.Black;
            this.clientbonbox.BorderRadius = 3;
            this.clientbonbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientbonbox.DefaultText = "";
            this.clientbonbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientbonbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientbonbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientbonbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientbonbox.FillColor = System.Drawing.SystemColors.Control;
            this.clientbonbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientbonbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientbonbox.ForeColor = System.Drawing.Color.Black;
            this.clientbonbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientbonbox.Location = new System.Drawing.Point(68, 9);
            this.clientbonbox.Name = "clientbonbox";
            this.clientbonbox.PasswordChar = '\0';
            this.clientbonbox.PlaceholderText = "";
            this.clientbonbox.SelectedText = "";
            this.clientbonbox.Size = new System.Drawing.Size(140, 25);
            this.clientbonbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.produitecombobox);
            this.guna2Panel1.Controls.Add(this.quantitebonbox);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 107);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(915, 43);
            this.guna2Panel1.TabIndex = 13;
            // 
            // produitecombobox
            // 
            this.produitecombobox.BackColor = System.Drawing.Color.Transparent;
            this.produitecombobox.BaseColor = System.Drawing.SystemColors.Control;
            this.produitecombobox.BorderColor = System.Drawing.Color.Black;
            this.produitecombobox.BorderSize = 1;
            this.produitecombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.produitecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produitecombobox.FocusedColor = System.Drawing.Color.Empty;
            this.produitecombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.produitecombobox.ForeColor = System.Drawing.Color.Black;
            this.produitecombobox.FormattingEnabled = true;
            this.produitecombobox.Location = new System.Drawing.Point(78, 8);
            this.produitecombobox.Name = "produitecombobox";
            this.produitecombobox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.produitecombobox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.produitecombobox.Radius = 3;
            this.produitecombobox.Size = new System.Drawing.Size(205, 26);
            this.produitecombobox.TabIndex = 9;
            this.produitecombobox.SelectedIndexChanged += new System.EventHandler(this.produitecombobox_SelectedIndexChanged);
            // 
            // quantitebonbox
            // 
            this.quantitebonbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantitebonbox.BorderColor = System.Drawing.Color.Black;
            this.quantitebonbox.BorderRadius = 3;
            this.quantitebonbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantitebonbox.DefaultText = "";
            this.quantitebonbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantitebonbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantitebonbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantitebonbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantitebonbox.FillColor = System.Drawing.SystemColors.Control;
            this.quantitebonbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantitebonbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantitebonbox.ForeColor = System.Drawing.Color.Black;
            this.quantitebonbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantitebonbox.Location = new System.Drawing.Point(368, 9);
            this.quantitebonbox.Name = "quantitebonbox";
            this.quantitebonbox.PasswordChar = '\0';
            this.quantitebonbox.PlaceholderText = "";
            this.quantitebonbox.SelectedText = "";
            this.quantitebonbox.Size = new System.Drawing.Size(81, 25);
            this.quantitebonbox.TabIndex = 3;
            this.quantitebonbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitebonbox_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantité :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Produit :";
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
            this.ajouterbtnbon.Location = new System.Drawing.Point(740, 156);
            this.ajouterbtnbon.Name = "ajouterbtnbon";
            this.ajouterbtnbon.Size = new System.Drawing.Size(180, 40);
            this.ajouterbtnbon.TabIndex = 14;
            this.ajouterbtnbon.Text = "Ajouter au liste";
            this.ajouterbtnbon.Click += new System.EventHandler(this.ajouterbtnbon_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bongridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bongridview.ColumnHeadersHeight = 20;
            this.bongridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bongridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produit,
            this.quantite,
            this.suprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bongridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.bongridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bongridview.Location = new System.Drawing.Point(5, 156);
            this.bongridview.Name = "bongridview";
            this.bongridview.RowHeadersVisible = false;
            this.bongridview.Size = new System.Drawing.Size(576, 524);
            this.bongridview.TabIndex = 15;
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
            // produit
            // 
            this.produit.HeaderText = "Produit";
            this.produit.Name = "produit";
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
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
            // imprimeressavebtn
            // 
            this.imprimeressavebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimeressavebtn.BorderRadius = 5;
            this.imprimeressavebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.imprimeressavebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.imprimeressavebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.imprimeressavebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.imprimeressavebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.imprimeressavebtn.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimeressavebtn.ForeColor = System.Drawing.Color.White;
            this.imprimeressavebtn.Location = new System.Drawing.Point(603, 638);
            this.imprimeressavebtn.Name = "imprimeressavebtn";
            this.imprimeressavebtn.Size = new System.Drawing.Size(317, 40);
            this.imprimeressavebtn.TabIndex = 23;
            this.imprimeressavebtn.Text = "Imprimer et sauvegarder";
            this.imprimeressavebtn.Click += new System.EventHandler(this.imprimeressavebtn_Click);
            // 
            // voirbonbtn
            // 
            this.voirbonbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voirbonbtn.BorderRadius = 5;
            this.voirbonbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.voirbonbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.voirbonbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.voirbonbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.voirbonbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(207)))));
            this.voirbonbtn.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voirbonbtn.ForeColor = System.Drawing.Color.White;
            this.voirbonbtn.Location = new System.Drawing.Point(603, 592);
            this.voirbonbtn.Name = "voirbonbtn";
            this.voirbonbtn.Size = new System.Drawing.Size(317, 40);
            this.voirbonbtn.TabIndex = 22;
            this.voirbonbtn.Text = "Voir le Bon";
            this.voirbonbtn.Click += new System.EventHandler(this.voirbonbtn_Click);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "suprimer";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // datetimepicker
            // 
            this.datetimepicker.Checked = true;
            this.datetimepicker.FillColor = System.Drawing.SystemColors.Control;
            this.datetimepicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepicker.Location = new System.Drawing.Point(237, 7);
            this.datetimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(181, 32);
            this.datetimepicker.TabIndex = 10;
            this.datetimepicker.Value = new System.DateTime(2023, 9, 24, 11, 42, 49, 99);
            // 
            // BonLivereecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 692);
            this.Controls.Add(this.imprimeressavebtn);
            this.Controls.Add(this.voirbonbtn);
            this.Controls.Add(this.bongridview);
            this.Controls.Add(this.ajouterbtnbon);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.MinimumSize = new System.Drawing.Size(943, 731);
            this.Name = "BonLivereecs";
            this.Text = "Bon Liverée";
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bongridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label datelabel;
        private Guna.UI2.WinForms.Guna2TextBox Nbonbox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox matriculebox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox chiffeurbox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox clientbonbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox destinationbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaComboBox produitecombobox;
        private Guna.UI2.WinForms.Guna2TextBox quantitebonbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button ajouterbtnbon;
        private Guna.UI2.WinForms.Guna2DataGridView bongridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewImageColumn suprimer;
        private Guna.UI2.WinForms.Guna2Button imprimeressavebtn;
        private Guna.UI2.WinForms.Guna2Button voirbonbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker;
    }
}