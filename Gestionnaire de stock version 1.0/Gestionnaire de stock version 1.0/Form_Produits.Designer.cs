﻿namespace Gestionnaire_de_stock_version_1._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lstfournisseur = new System.Windows.Forms.ListBox();
            this.cmdvalider = new System.Windows.Forms.Button();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblcategorie = new System.Windows.Forms.Label();
            this.lblfournisseur = new System.Windows.Forms.Label();
            this.Picretournemenu = new System.Windows.Forms.PictureBox();
            this.cmbcategories = new System.Windows.Forms.ComboBox();
            this.lstid = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picretournemenu)).BeginInit();
            this.SuspendLayout();
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
            // lstfournisseur
            // 
            this.lstfournisseur.AllowDrop = true;
            this.lstfournisseur.FormattingEnabled = true;
            this.lstfournisseur.Location = new System.Drawing.Point(146, 175);
            this.lstfournisseur.Name = "lstfournisseur";
            this.lstfournisseur.ScrollAlwaysVisible = true;
            this.lstfournisseur.Size = new System.Drawing.Size(150, 173);
            this.lstfournisseur.TabIndex = 4;
            // 
            // cmdvalider
            // 
            this.cmdvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvalider.Location = new System.Drawing.Point(92, 389);
            this.cmdvalider.Name = "cmdvalider";
            this.cmdvalider.Size = new System.Drawing.Size(160, 35);
            this.cmdvalider.TabIndex = 5;
            this.cmdvalider.Text = "valider";
            this.cmdvalider.UseVisualStyleBackColor = true;
            this.cmdvalider.Click += new System.EventHandler(this.cmdvalider_Click);
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
            // cmbcategories
            // 
            this.cmbcategories.FormattingEnabled = true;
            this.cmbcategories.Location = new System.Drawing.Point(146, 125);
            this.cmbcategories.Name = "cmbcategories";
            this.cmbcategories.Size = new System.Drawing.Size(150, 21);
            this.cmbcategories.TabIndex = 9;
            // 
            // lstid
            // 
            this.lstid.FormattingEnabled = true;
            this.lstid.Location = new System.Drawing.Point(20, 200);
            this.lstid.Name = "lstid";
            this.lstid.Size = new System.Drawing.Size(120, 95);
            this.lstid.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 302);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 82);
            this.listBox1.TabIndex = 11;
            // 
            // FrmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstid);
            this.Controls.Add(this.cmbcategories);
            this.Controls.Add(this.lblfournisseur);
            this.Controls.Add(this.lblcategorie);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.cmdvalider);
            this.Controls.Add(this.lstfournisseur);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picretournemenu);
            this.Name = "FrmProduits";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.FrmProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picretournemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picretournemenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.ListBox lstfournisseur;
        private System.Windows.Forms.Button cmdvalider;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblcategorie;
        private System.Windows.Forms.Label lblfournisseur;
        private System.Windows.Forms.ComboBox cmbcategories;
        private System.Windows.Forms.ListBox lstid;
        private System.Windows.Forms.ListBox listBox1;
    }
}