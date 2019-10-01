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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picretournemenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(362, 9);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(122, 46);
            this.lblstock.TabIndex = 0;
            this.lblstock.Text = "Stock";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.worker_loading_boxes;
            this.pictureBox3.Location = new System.Drawing.Point(81, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Gererlestock;
            this.pictureBox2.Location = new System.Drawing.Point(246, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestionnaire_de_stock_version_1._0.Properties.Resources.Ajouterunproduit;
            this.pictureBox1.Location = new System.Drawing.Point(246, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picretournemenu);
            this.Controls.Add(this.lblstock);
            this.Name = "FrmStock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.PictureBox picretournemenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}