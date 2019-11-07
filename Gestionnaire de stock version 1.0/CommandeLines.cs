/**
 * \file      CommandeLines.cs
 * \author    L. Kirchner Bannwart and S. Sordet 
 * \version   1.0
 * \date      Novembre 07. 2019
 * \brief     Information and methods about a Commandes.
 *
 * \details   this class contains all the attributes, properties and methods a commandeLines can have. 
 */
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
        private string arrivaldate;

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
        public CommandeLines(int idC, string nameproduitC, string unitiesC, int quantityC, string orderDateC, int statusC, string arrivaldateC)
        {
            id = idC;
            nameproduit = nameproduitC;
            unities = unitiesC;
            quantity = quantityC;
            orderDate = orderDateC;
            status = statusC;
            arrivaldate = arrivaldateC;
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
        public string Arrivaldate
        {
            get
            {
                return arrivaldate;
            }
            set
            {
                arrivaldate = value;
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
