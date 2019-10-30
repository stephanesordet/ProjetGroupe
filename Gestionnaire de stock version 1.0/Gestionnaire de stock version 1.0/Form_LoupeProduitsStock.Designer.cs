namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmLoupeProduitStcok
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
            this.cboProduits = new System.Windows.Forms.ListBox();
            this.cmdValidder = new System.Windows.Forms.Button();
            this.picReturne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProduits
            // 
            this.cboProduits.FormattingEnabled = true;
            this.cboProduits.Location = new System.Drawing.Point(47, 69);
            this.cboProduits.Name = "cboProduits";
            this.cboProduits.Size = new System.Drawing.Size(186, 277);
            this.cboProduits.TabIndex = 0;
            // 
            // cmdValidder
            // 
            this.cmdValidder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdValidder.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdValidder.Location = new System.Drawing.Point(47, 362);
            this.cmdValidder.Name = "cmdValidder";
            this.cmdValidder.Size = new System.Drawing.Size(186, 34);
            this.cmdValidder.TabIndex = 1;
            this.cmdValidder.Text = "Valider";
            this.cmdValidder.UseVisualStyleBackColor = false;
            this.cmdValidder.Click += new System.EventHandler(this.cmdValidder_Click);
            // 
            // picReturne
            // 
            this.picReturne.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picReturne.Location = new System.Drawing.Point(13, 13);
            this.picReturne.Name = "picReturne";
            this.picReturne.Size = new System.Drawing.Size(32, 34);
            this.picReturne.TabIndex = 2;
            this.picReturne.TabStop = false;
            this.picReturne.Click += new System.EventHandler(this.picReturne_Click);
            // 
            // FrmLoupeProduitStcok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 424);
            this.Controls.Add(this.picReturne);
            this.Controls.Add(this.cmdValidder);
            this.Controls.Add(this.cboProduits);
            this.Name = "FrmLoupeProduitStcok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_LoupeProduitsStock";
            this.Load += new System.EventHandler(this.FrmLoupeProduitStcok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReturne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cboProduits;
        private System.Windows.Forms.Button cmdValidder;
        private System.Windows.Forms.PictureBox picReturne;
    }
}