namespace Ets_yessad.Forms
{
    partial class quantiteform
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.datetimepickerend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickerstart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bongridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bongridview)).BeginInit();
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
            this.guna2Button1.Location = new System.Drawing.Point(519, 12);
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
            this.datetimepickerend.Location = new System.Drawing.Point(355, 12);
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
            this.label2.Location = new System.Drawing.Point(275, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "jusqu\'à :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
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
            this.datepickerstart.Location = new System.Drawing.Point(118, 12);
            this.datepickerstart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepickerstart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepickerstart.Name = "datepickerstart";
            this.datepickerstart.Size = new System.Drawing.Size(144, 36);
            this.datepickerstart.TabIndex = 5;
            this.datepickerstart.Value = new System.DateTime(2023, 9, 16, 14, 31, 36, 134);
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
            this.produit,
            this.quantite,
            this.total,
            this.profite});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bongridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.bongridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bongridview.Location = new System.Drawing.Point(12, 63);
            this.bongridview.Name = "bongridview";
            this.bongridview.RowHeadersVisible = false;
            this.bongridview.Size = new System.Drawing.Size(628, 375);
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
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // profite
            // 
            this.profite.HeaderText = "Profite";
            this.profite.Name = "profite";
            // 
            // quantiteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.bongridview);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.datetimepickerend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepickerstart);
            this.Name = "quantiteform";
            this.Text = "quantiteform";
            ((System.ComponentModel.ISupportInitialize)(this.bongridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepickerend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerstart;
        private Guna.UI2.WinForms.Guna2DataGridView bongridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn profite;
    }
}