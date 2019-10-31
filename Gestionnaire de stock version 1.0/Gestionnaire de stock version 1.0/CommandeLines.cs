using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class CommandeLines
    {
        private int id;
        private string nameproduit;
        private string categorie;
        private int quantity;
        private string peremption;
        private string orderDate;
        private string unities;
        private int status;

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
        public CommandeLines(int idC, string nameproduitC, string unitiesC, int quantityC, string orderDateC, int statusC)
        {
            id = idC;
            nameproduit = nameproduitC;
            unities = unitiesC;
            quantity = quantityC;
            orderDate = orderDateC;
            status = statusC;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Nameproduit
        {
            get
            {
                return nameproduit;
            }
            set
            {
                nameproduit = value;
            }
        }
        public string Categorie
        {
            get
            {
                return categorie;
            }
            set
            {
                categorie = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string Peremption
        {
            get
            {
                return peremption;
            }
            set
            {
                peremption = value;
            }
        }
        public string OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        public string Unities
        {
            get
            {
                return unities;
            }
            set
            {
                unities = value;
            }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

    }
}
