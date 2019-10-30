using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    public class Products
    {
        public int id;
        public string name;
        public string categoriename;
        public int idcategorie;

        public Products(int idC, string namec)
        {
            id = idC;
            name = namec;
        }
        public Products(int idC, string namec,string categorienameC,int idcategorieC)
        {
            id = idC;
            name = namec;
            categoriename = categorienameC;
            idcategorie = idcategorieC;
        }


        public override string ToString()
        {
            return name;
        }
    }
}
