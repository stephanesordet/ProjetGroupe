namespace Gestionnaire_de_stock_version_1._0
{
    partial class FrmStock
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
            this.lblstock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picAjouterproduit = new System.Windows.Forms.PictureBox();
            this.picretournemenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjouterproduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(244, 20);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(105, 39);
            this.lblstock.TabIndex = 0;
            this.lblstock.Text = "Stock";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.gererstock32;
            this.pictureBox2.Location = new System.Drawing.Point(110, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picAjouterproduit
            // 
            this.picAjouterproduit.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.ajouteproduit22;
            this.picAjouterproduit.Location = new System.Drawing.Point(110, 120);
            this.picAjouterproduit.Name = "picAjouterproduit";
            this.picAjouterproduit.Size = new System.Drawing.Size(392, 128);
            this.picAjouterproduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAjouterproduit.TabIndex = 2;
            this.picAjouterproduit.TabStop = false;
            this.picAjouterproduit.Click += new System.EventHandler(this.PicAjouterproduit_Click);
            // 
            // picretournemenu
            // 
            this.picretournemenu.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.left_arrow;
            this.picretournemenu.Location = new System.Drawing.Point(13, 9);
            this.picretournemenu.Name = "picretournemenu";
            this.picretournemenu.Size = new System.Drawing.Size(35, 27);
            this.picretournemenu.TabIndex = 1;
            this.picretournemenu.TabStop = false;
            this.picretournemenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picAjouterproduit);
            this.Controls.Add(this.picretournemenu);
            this.Controls.Add(this.lblstock);
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjouterproduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.PictureBox picretournemenu;
        private System.Windows.Forms.PictureBox picAjouterproduit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}