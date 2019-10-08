using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Unities
    {
        public int id;
        public string name;

        public Unities(int idC, string nameC)
        {
            id = idC;
            name = nameC;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
