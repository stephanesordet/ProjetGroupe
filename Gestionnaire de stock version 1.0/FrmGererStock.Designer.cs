namespace Gestionnaire_de_stock_version_1._0
{
    partial class frmGererStock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStock = new System.Windows.Forms.Label();
            this.picReturne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Produit,
            this.Categorie,
            this.Quantite,
            this.Unities,
            this.Date});
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(23, 92);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(829, 430);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStock_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            this.Produit.Width = 150;
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Catégorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            this.Categorie.Width = 150;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Unities
            // 
            this.Unities.HeaderText = "Unité";
            this.Unities.Name = "Unities";
            this.Unities.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date de Péremption ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.Location = new System.Drawing.Point(347, 21);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(157, 46);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "STOCK";
            // 
            // picReturne
            // 
            this.picReturne.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picReturne.Location = new System.Drawing.Point(12, 12);
            this.picReturne.Name = "picReturne";
            this.picReturne.Size = new System.Drawing.Size(31, 29);
            this.picReturne.TabIndex = 2;
            this.picReturne.TabStop = false;
            this.picReturne.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmGererStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 534);
            this.Controls.Add(this.picReturne);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dgvStock);
            this.Name = "FrmGererStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GererStock";
            this.Load += new System.EventHandler(this.FrmGererStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox picReturne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}