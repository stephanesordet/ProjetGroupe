namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmNouvellecommande
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
            this.lblcommande = new System.Windows.Forms.Label();
            this.picretourcommander = new System.Windows.Forms.PictureBox();
            this.cboFournisseur = new System.Windows.Forms.ComboBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblproduit = new System.Windows.Forms.Label();
            this.lblunite = new System.Windows.Forms.Label();
            this.lblquantite = new System.Windows.Forms.Label();
            this.lblfournisseur = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmdValider = new System.Windows.Forms.Button();
            this.cboProduit = new System.Windows.Forms.ComboBox();
            this.cboUnite = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Produits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdFinierCommande = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picretourcommander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcommande
            // 
            this.lblcommande.AutoSize = true;
            this.lblcommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcommande.Location = new System.Drawing.Point(221, 9);
            this.lblcommande.Name = "lblcommande";
            this.lblcommande.Size = new System.Drawing.Size(153, 31);
            this.lblcommande.TabIndex = 0;
            this.lblcommande.Text = "Commande";
            // 
            // picretourcommander
            // 
            this.picretourcommander.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picretourcommander.Location = new System.Drawing.Point(13, 13);
            this.picretourcommander.Name = "picretourcommander";
            this.picretourcommander.Size = new System.Drawing.Size(34, 33);
            this.picretourcommander.TabIndex = 1;
            this.picretourcommander.TabStop = false;
            this.picretourcommander.Click += new System.EventHandler(this.picretourcommander_Click);
            // 
            // cboFournisseur
            // 
            this.cboFournisseur.FormattingEnabled = true;
            this.cboFournisseur.Location = new System.Drawing.Point(143, 99);
            this.cboFournisseur.Name = "cboFournisseur";
            this.cboFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cboFournisseur.TabIndex = 3;
            this.cboFournisseur.SelectedIndexChanged += new System.EventHandler(this.cboFournisseur_SelectedIndexChanged);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(143, 138);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(121, 20);
            this.txtQuantite.TabIndex = 5;
            // 
            // lblproduit
            // 
            this.lblproduit.AutoSize = true;
            this.lblproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduit.Location = new System.Drawing.Point(306, 100);
            this.lblproduit.Name = "lblproduit";
            this.lblproduit.Size = new System.Drawing.Size(63, 20);
            this.lblproduit.TabIndex = 6;
            this.lblproduit.Text = "Produit ";
            // 
            // lblunite
            // 
            this.lblunite.AutoSize = true;
            this.lblunite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunite.Location = new System.Drawing.Point(306, 138);
            this.lblunite.Name = "lblunite";
            this.lblunite.Size = new System.Drawing.Size(47, 20);
            this.lblunite.TabIndex = 7;
            this.lblunite.Text = "Unité";
            // 
            // lblquantite
            // 
            this.lblquantite.AutoSize = true;
            this.lblquantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantite.Location = new System.Drawing.Point(27, 138);
            this.lblquantite.Name = "lblquantite";
            this.lblquantite.Size = new System.Drawing.Size(70, 20);
            this.lblquantite.TabIndex = 8;
            this.lblquantite.Text = "Quantité";
            // 
            // lblfournisseur
            // 
            this.lblfournisseur.AutoSize = true;
            this.lblfournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfournisseur.Location = new System.Drawing.Point(27, 100);
            this.lblfournisseur.Name = "lblfournisseur";
            this.lblfournisseur.Size = new System.Drawing.Size(93, 20);
            this.lblfournisseur.TabIndex = 9;
            this.lblfournisseur.Text = "Fournisseur";
            // 
            // cmdValider
            // 
            this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValider.Location = new System.Drawing.Point(227, 195);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(126, 31);
            this.cmdValider.TabIndex = 10;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // cboProduit
            // 
            this.cboProduit.FormattingEnabled = true;
            this.cboProduit.Location = new System.Drawing.Point(408, 99);
            this.cboProduit.Name = "cboProduit";
            this.cboProduit.Size = new System.Drawing.Size(121, 21);
            this.cboProduit.TabIndex = 3;
            // 
            // cboUnite
            // 
            this.cboUnite.FormattingEnabled = true;
            this.cboUnite.Location = new System.Drawing.Point(408, 137);
            this.cboUnite.Name = "cboUnite";
            this.cboUnite.Size = new System.Drawing.Size(121, 21);
            this.cboUnite.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produits,
            this.Quantites,
            this.Unites,
            this.Supprimer});
            this.dataGridView1.Location = new System.Drawing.Point(66, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(447, 177);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Produits
            // 
            this.Produits.HeaderText = "Produit";
            this.Produits.Name = "Produits";
            // 
            // Quantites
            // 
            this.Quantites.HeaderText = "Quantité";
            this.Quantites.Name = "Quantites";
            // 
            // Unites
            // 
            this.Unites.HeaderText = "Unité";
            this.Unites.Name = "Unites";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            // 
            // cmdFinierCommande
            // 
            this.cmdFinierCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinierCommande.Location = new System.Drawing.Point(121, 710);
            this.cmdFinierCommande.Name = "cmdFinierCommande";
            this.cmdFinierCommande.Size = new System.Drawing.Size(300, 30);
            this.cmdFinierCommande.TabIndex = 13;
            this.cmdFinierCommande.Text = "Finir la commande et envoyer ";
            this.cmdFinierCommande.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(66, 457);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 225);
            this.listBox1.TabIndex = 14;
            // 
            // FrmNouvellecommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 766);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdFinierCommande);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.lblfournisseur);
            this.Controls.Add(this.lblquantite);
            this.Controls.Add(this.lblunite);
            this.Controls.Add(this.lblproduit);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cboUnite);
            this.Controls.Add(this.cboProduit);
            this.Controls.Add(this.cboFournisseur);
            this.Controls.Add(this.picretourcommander);
            this.Controls.Add(this.lblcommande);
            this.Name = "FrmNouvellecommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvellecommande";
            this.Load += new System.EventHandler(this.FrmNouvellecommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picretourcommander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcommande;
        private System.Windows.Forms.PictureBox picretourcommander;
        private System.Windows.Forms.ComboBox cboFournisseur;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblproduit;
        private System.Windows.Forms.Label lblunite;
        private System.Windows.Forms.Label lblquantite;
        private System.Windows.Forms.Label lblfournisseur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.ComboBox cboProduit;
        private System.Windows.Forms.ComboBox cboUnite;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantites;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unites;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supprimer;
        private System.Windows.Forms.Button cmdFinierCommande;
        private System.Windows.Forms.ListBox listBox1;
    }
}