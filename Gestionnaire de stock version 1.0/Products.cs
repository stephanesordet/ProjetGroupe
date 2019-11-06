using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    public class Products
    {
        private int id;
        private string name;
        private string categoriename;
        private int idcategorie;

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
        public string Categoriename
        {
            get
            {
                return categoriename;
            }
            set
            {
                categoriename = value;
            }
        }
        public int Idcategorie
        {
            get
            {
                return idcategorie;
            }
            set
            {
                idcategorie = value;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
