﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    public class Controller
    {
        public static int characterController(string nom)
        {
            if(nom.IndexOf("'") > 0)
            {
                return 1;
            }
            if (nom.IndexOf("@") > 0)
            {
                return 11;
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
        public static bool numberController(string Nombre)
        {
            try
            {
                int.Parse(Nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DateController(string date)
        {
            if (date == "")
            {
                return true;
            }
            else
            {
                string motif = @"^\(?([0-9]{2})\)?[.]?([0-9]{2})[.]?([0-9]{4})$";
                bool returnin = Regex.IsMatch(date, motif);
                return Regex.IsMatch(date, motif);
            }

        }
    }
 
  
}
