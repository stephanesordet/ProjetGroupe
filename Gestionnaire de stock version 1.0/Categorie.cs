/**
 * \file      Categorie.cs
 * \author    L. Kirchner Bannwart and S. Sordet 
 * \version   1.0
 * \date      Novembre 07. 2019
 * \brief     Information and methods about a categorie a product has.
 *
 * \details   this class contains all the attributes, properties and methods a categorie can have. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Categorie
    {
        private int id;
        private string name;

        public Categorie(int idC, string namec)
        {
            id = idC;
            name = namec;
        }

        public override string ToString()
        {
            return name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
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
    }
}
