namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmProduits
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
            this.Picretournemenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcategorie = new System.Windows.Forms.TextBox();
            this.lstfournisseur = new System.Windows.Forms.ListBox();
            this.cmdvalider = new System.Windows.Forms.Button();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblcategorie = new System.Windows.Forms.Label();
            this.lblfournisseur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picretournemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Picretournemenu
            // 
            this.Picretournemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.Picretournemenu.Location = new System.Drawing.Point(2, 4);
            this.Picretournemenu.Name = "Picretournemenu";
            this.Picretournemenu.Size = new System.Drawing.Size(29, 28);
            this.Picretournemenu.TabIndex = 0;
            this.Picretournemenu.TabStop = false;
            this.Picretournemenu.Click += new System.EventHandler(this.Picretournemenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter un produit ";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(146, 77);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(150, 27);
            this.txtnom.TabIndex = 2;
            // 
            // txtcategorie
            // 
            this.txtcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategorie.Location = new System.Drawing.Point(146, 125);
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(150, 27);
            this.txtcategorie.TabIndex = 3;
            // 
            // lstfournisseur
            // 
            this.lstfournisseur.FormattingEnabled = true;
            this.lstfournisseur.Location = new System.Drawing.Point(146, 175);
            this.lstfournisseur.Name = "lstfournisseur";
            this.lstfournisseur.Size = new System.Drawing.Size(150, 173);
            this.lstfournisseur.TabIndex = 4;
            // 
            // cmdvalider
            // 
            this.cmdvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvalider.Location = new System.Drawing.Point(86, 378);
            this.cmdvalider.Name = "cmdvalider";
            this.cmdvalider.Size = new System.Drawing.Size(160, 35);
            this.cmdvalider.TabIndex = 5;
            this.cmdvalider.Text = "valider";
            this.cmdvalider.UseVisualStyleBackColor = true;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(24, 77);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(47, 22);
            this.lblnom.TabIndex = 6;
            this.lblnom.Text = "Nom";
            // 
            // lblcategorie
            // 
            this.lblcategorie.AutoSize = true;
            this.lblcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategorie.Location = new System.Drawing.Point(24, 125);
            this.lblcategorie.Name = "lblcategorie";
            this.lblcategorie.Size = new System.Drawing.Size(88, 22);
            this.lblcategorie.TabIndex = 7;
            this.lblcategorie.Text = "Catégorie";
            // 
            // lblfournisseur
            // 
            this.lblfournisseur.AutoSize = true;
            this.lblfournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfournisseur.Location = new System.Drawing.Point(24, 175);
            this.lblfournisseur.Name = "lblfournisseur";
            this.lblfournisseur.Size = new System.Drawing.Size(105, 22);
            this.lblfournisseur.TabIndex = 8;
            this.lblfournisseur.Text = "Fournisseur";
            // 
            // FrmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.lblfournisseur);
            this.Controls.Add(this.lblcategorie);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.cmdvalider);
            this.Controls.Add(this.lstfournisseur);
            this.Controls.Add(this.txtcategorie);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picretournemenu);
            this.Name = "FrmProduits";
            this.Text = "Produits";
            ((System.ComponentModel.ISupportInitialize)(this.Picretournemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picretournemenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcategorie;
        private System.Windows.Forms.ListBox lstfournisseur;
        private System.Windows.Forms.Button cmdvalider;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblcategorie;
        private System.Windows.Forms.Label lblfournisseur;
    }
}