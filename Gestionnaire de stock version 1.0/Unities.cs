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
