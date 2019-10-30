using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class CommandeLines
    {
        public int id;
        public string nameproduit;
        public string categorie;
        public int quantity;
        public string peremption;
        public string orderDate;
        public string unities;
        public int status;

        //Produit en stock
        public CommandeLines(int idC, string nameproduitC, string categorieC, int quantityC, string unitiesC, string peremptionC)
        {
            id = idC;
            nameproduit = nameproduitC;
            categorie = categorieC;
            unities = unitiesC;
            quantity = quantityC;
            peremption = peremptionC;
        }
        //Commande un produit
        public CommandeLines(int idC, string nameproduitC, string unitiesC, int quantityC, string orderDateC)
        {
            id = idC;
            nameproduit = nameproduitC;
            unities = unitiesC;
            quantity = quantityC;
            orderDate = orderDateC;
        }


    }
}
