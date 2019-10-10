namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmMescommandes
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
            this.picretournemenu = new System.Windows.Forms.PictureBox();
            this.lblcommandes = new System.Windows.Forms.Label();
            this.dgvCommandeEnCours = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etatcommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datecommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeEnCours)).BeginInit();
            this.SuspendLayout();
            // 
            // picretournemenu
            // 
            this.picretournemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picretournemenu.Location = new System.Drawing.Point(13, 13);
            this.picretournemenu.Name = "picretournemenu";
            this.picretournemenu.Size = new System.Drawing.Size(42, 27);
            this.picretournemenu.TabIndex = 0;
            this.picretournemenu.TabStop = false;
            this.picretournemenu.Click += new System.EventHandler(this.picretournemenu_Click);
            // 
            // lblcommandes
            // 
            this.lblcommandes.AutoSize = true;
            this.lblcommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcommandes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblcommandes.Location = new System.Drawing.Point(207, 24);
            this.lblcommandes.Name = "lblcommandes";
            this.lblcommandes.Size = new System.Drawing.Size(335, 46);
            this.lblcommandes.TabIndex = 1;
            this.lblcommandes.Text = "Mes commandes ";
            // 
            // dgvCommandeEnCours
            // 
            this.dgvCommandeEnCours.AllowUserToAddRows = false;
            this.dgvCommandeEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandeEnCours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Produit,
            this.Quantite,
            this.Unite,
            this.Etatcommande,
            this.Datecommande});
            this.dgvCommandeEnCours.Location = new System.Drawing.Point(13, 108);
            this.dgvCommandeEnCours.Name = "dgvCommandeEnCours";
            this.dgvCommandeEnCours.Size = new System.Drawing.Size(689, 474);
            this.dgvCommandeEnCours.TabIndex = 2;
            this.dgvCommandeEnCours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommandeEnCours_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            this.Produit.Width = 150;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité demandé ";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Unite
            // 
            this.Unite.HeaderText = "Unité";
            this.Unite.Name = "Unite";
            this.Unite.ReadOnly = true;
            // 
            // Etatcommande
            // 
            this.Etatcommande.HeaderText = "Etat de la commande ";
            this.Etatcommande.Name = "Etatcommande";
            this.Etatcommande.ReadOnly = true;
            this.Etatcommande.Width = 125;
            // 
            // Datecommande
            // 
            this.Datecommande.HeaderText = "Date commande ";
            this.Datecommande.Name = "Datecommande";
            this.Datecommande.ReadOnly = true;
            // 
            // FrmMescommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 594);
            this.Controls.Add(this.dgvCommandeEnCours);
            this.Controls.Add(this.lblcommandes);
            this.Controls.Add(this.picretournemenu);
            this.Name = "FrmMescommandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes commandes";
            this.Load += new System.EventHandler(this.FrmMescommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeEnCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picretournemenu;
        private System.Windows.Forms.Label lblcommandes;
        private System.Windows.Forms.DataGridView dgvCommandeEnCours;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etatcommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datecommande;
    }
}