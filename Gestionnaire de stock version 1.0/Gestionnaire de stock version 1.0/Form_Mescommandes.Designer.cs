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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblcommandes.Location = new System.Drawing.Point(243, 9);
            this.lblcommandes.Name = "lblcommandes";
            this.lblcommandes.Size = new System.Drawing.Size(335, 46);
            this.lblcommandes.TabIndex = 1;
            this.lblcommandes.Text = "Mes commandes ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmMescommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblcommandes);
            this.Controls.Add(this.picretournemenu);
            this.Name = "FrmMescommandes";
            this.Text = "Mes commandes";
            ((System.ComponentModel.ISupportInitialize)(this.picretournemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picretournemenu;
        private System.Windows.Forms.Label lblcommandes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}