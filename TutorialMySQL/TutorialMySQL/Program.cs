using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.Id = 1;
            contact.Name = "Mli";
            contact.Tel = "00 00 00 00 00";

            // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            
            ConnectionDB bdd = new ConnectionDB();
            bdd.AddContact(contact);
            
        }
    }
}
