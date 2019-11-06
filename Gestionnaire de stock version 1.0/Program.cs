using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Authors: Luana Kirchner Bannwart and Stéphane Sordet
/// Version: 1.0
/// Date : 11.09.2019
/// Project : Gestionnaire de stock
/// </summary>
namespace Gestionnaire_de_stock_version_1._0
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //tes
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());

        }




    }
}
