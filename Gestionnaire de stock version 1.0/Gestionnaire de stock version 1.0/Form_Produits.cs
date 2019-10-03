using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_stock_version_1._0
{
    public partial class FrmProduits : Form
    {
        ConnectionDB MysqlConn = new ConnectionDB();
        int[] idfournisseur = new int[200];
        int[] idcategorie = new int[200];
      

        public FrmProduits()
        {
            InitializeComponent();
        }

        private void Picretournemenu_Click(object sender, EventArgs e)
        {
            FrmMenu form1 = new FrmMenu();
            form1.Show();
            this.Hide();
        }

        private void cmdvalider_Click(object sender, EventArgs e)
        {

            if (txtnom.Text != " ")
            {
                MysqlConn.OpenDB();
                if (cmbcategories.SelectedItem != null)
                {
                    string nomcategorie = cmbcategories.SelectedItem.ToString();
                    List<string> listcategories = MysqlConn.Readcategoriesid(nomcategorie);
                    foreach (string value in listcategories)
                    {
                        int id = Int32.Parse(value);
                        long derneierid = MysqlConn.InsertProduit(txtnom.Text, id);
                    }
                    MysqlConn.CloseDB();
                    

                }
                else
                {
                    MessageBox.Show("Entrer un nom de produit");
                }
                MysqlConn.CloseDB();
            }

            else
            {
                MessageBox.Show("Entrer un nom de produit");
            }



            /* foreach (string value in listBox1.Items)
              {

                  if (listBox1.SelectedItem != null)
                  {

                      //recuperer le nom
                      avantlespace = value.Substring(0, value.IndexOf(" "));
                      //Recuperer le prenom
                      apreslespace = value.Substring(value.IndexOf(" ")+1);
                      //Recuperer l'entrepise 
                      apresletire = value.Substring(value.IndexOf("-") + 1);
                      lstid.Items.Add(avantlespace);
                      lstid.Items.Add(apreslespace);
                      lstid.Items.Add(apresletire);



                  }
                  else
                  {

                  }

              }*/

            /*int i = 0;
            for (i = 0; i <= lstfournisseur.SelectedIndices.Count -1; i++)
            {

                string Fournisseur = lstfournisseur;
                //recuperer le nom
                avantlespace = Fournisseur.Substring(0, Fournisseur.IndexOf(" "));
                //Recuperer le prenom
                apreslespace = Fournisseur.Substring(Fournisseur.IndexOf(" ") + 1);
                //Recuperer l'entrepise 
                apresletire = Fournisseur.Substring(Fournisseur.IndexOf("-") + 1);
                lstid.Items.Add(avantlespace);
                lstid.Items.Add(apreslespace);
                lstid.Items.Add(apresletire);


                //MysqlConn.InsertProductsSuppliers(derneierid, idfournisseur[i]);

            }
            MysqlConn.CloseDB();*/

        }



        private void FrmProduits_Load(object sender, EventArgs e)
        {
            lstfournisseur.SelectionMode=SelectionMode.MultiSimple;
            string avantlepoint;
            string apreslespoint;
            MysqlConn.OpenDB();
      
            List<string> listvaluesRead = MysqlConn.ReadFournisseur();
            foreach(string value in listvaluesRead)
            {
                //recuperer le nom
                avantlepoint = value.Substring(0,value.IndexOf("."));
                //Recuperer le prenom
                apreslespoint = value.Substring(value.IndexOf(".")+1);
                //Passe le id dans un tableau*/
                lstfournisseur.Items.Add(apreslespoint);
                listBox1.Items.Add(avantlepoint);
                idfournisseur[lstfournisseur.Items.Count-1] = Int32.Parse(avantlepoint);
               
            }
            MysqlConn.CloseDB();
            MysqlConn.OpenDB();
            List<string> listcategories = MysqlConn.Readcategories();
            foreach (string value in listcategories)
            {
                //recuperer le nom
                avantlepoint = value.Substring(0, value.IndexOf("."));
                //Recuperer le prenom
                apreslespoint = value.Substring(value.IndexOf(".") + 1);
                //Passe le id dans un tableau*/
                cmbcategories.Items.Add(apreslespoint);
                lstid.Items.Add(avantlepoint);
                idcategorie[(cmbcategories.Items.Count)+1] = Int32.Parse(avantlepoint);
            }
            MysqlConn.CloseDB();

           

        }

        
    }
}
