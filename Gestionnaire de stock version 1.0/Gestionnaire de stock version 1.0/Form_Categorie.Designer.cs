namespace Gestionnaire_de_stock_version_1._0
{
    partial class frmCategorie
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
            this.txtcategorie = new System.Windows.Forms.TextBox();
            this.lblcategorie = new System.Windows.Forms.Label();
            this.lblTitreCategorie = new System.Windows.Forms.Label();
            this.cmdVallider = new System.Windows.Forms.Button();
            this.picReturne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcategorie
            // 
            this.txtcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategorie.Location = new System.Drawing.Point(159, 91);
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(161, 26);
            this.txtcategorie.TabIndex = 0;
            // 
            // lblcategorie
            // 
            this.lblcategorie.AutoSize = true;
            this.lblcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategorie.Location = new System.Drawing.Point(12, 97);
            this.lblcategorie.Name = "lblcategorie";
            this.lblcategorie.Size = new System.Drawing.Size(126, 17);
            this.lblcategorie.TabIndex = 1;
            this.lblcategorie.Text = "Nouvelle catégorie";
            // 
            // lblTitreCategorie
            // 
            this.lblTitreCategorie.AutoSize = true;
            this.lblTitreCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCategorie.Location = new System.Drawing.Point(61, 9);
            this.lblTitreCategorie.Name = "lblTitreCategorie";
            this.lblTitreCategorie.Size = new System.Drawing.Size(227, 40);
            this.lblTitreCategorie.TabIndex = 2;
            this.lblTitreCategorie.Text = "Ajouter une nouvelle catégorie \r\n            pour les produits ";
            // 
            // cmdVallider
            // 
            this.cmdVallider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVallider.Location = new System.Drawing.Point(103, 150);
            this.cmdVallider.Name = "cmdVallider";
            this.cmdVallider.Size = new System.Drawing.Size(110, 30);
            this.cmdVallider.TabIndex = 3;
            this.cmdVallider.Text = "Vallider ";
            this.cmdVallider.UseVisualStyleBackColor = true;
            this.cmdVallider.Click += new System.EventHandler(this.cmdVallider_Click);
            // 
            // picReturne
            // 
            this.picReturne.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picReturne.Location = new System.Drawing.Point(12, 9);
            this.picReturne.Name = "picReturne";
            this.picReturne.Size = new System.Drawing.Size(27, 26);
            this.picReturne.TabIndex = 4;
            this.picReturne.TabStop = false;
            this.picReturne.Click += new System.EventHandler(this.picReturne_Click);
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 203);
            this.Controls.Add(this.picReturne);
            this.Controls.Add(this.cmdVallider);
            this.Controls.Add(this.lblTitreCategorie);
            this.Controls.Add(this.lblcategorie);
            this.Controls.Add(this.txtcategorie);
            this.Name = "frmCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorie ";
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcategorie;
        private System.Windows.Forms.Label lblcategorie;
        private System.Windows.Forms.Label lblTitreCategorie;
        private System.Windows.Forms.Button cmdVallider;
        private System.Windows.Forms.PictureBox picReturne;
    }
}