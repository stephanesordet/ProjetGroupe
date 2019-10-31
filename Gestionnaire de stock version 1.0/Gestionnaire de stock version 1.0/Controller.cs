using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    public class Controller
    {
        public int characterController(string nom)
        {
            if(nom.IndexOf("'") > 0)
            {
                return 1;
            }
            if (nom.IndexOf("@") > 0)
            {
                return 1;
            }
            if (nom.IndexOf("%") > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public int numberControl(int numero)
        {
            return;
        }
        public int stringControl(int numero)
        {
            return;
        }
    }
}
