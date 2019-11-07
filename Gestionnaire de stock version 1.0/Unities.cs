/**
 * \file      Unities.cs
 * \author    L. Kirchner Bannwart and S. Sordet 
 * \version   1.0
 * \date      Novembre 07. 2019
 * \brief     Information and methods about a unities a commandeLines has.
 *
 * \details   this class contains all the attributes, properties and methods a unities can have. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Unities
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Unities(int idC, string nameC)
        {
            Id = idC;
            Name = nameC;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
