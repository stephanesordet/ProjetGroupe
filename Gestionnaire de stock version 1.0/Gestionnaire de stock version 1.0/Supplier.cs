using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{//Création de la classe Supplier
    class Supplier
    {

        private int id;
        private string gender;
        private string firstName;
        private string lastName;
        private string company;
        private string city;
        private int npa;
        private string street;
        private string email;

        //Constructeur pour créer un nouveau Supplier 
        public Supplier(string genderC, string firstNameC, string lastNameC, string companyC, int npaC, string cityC, string streetC, string emailC)
        {
            Gender = genderC;
            FirstName = firstNameC;
            LastName = lastNameC;
            Company = companyC;
            Npa = npaC;
            City = cityC;
            Street = streetC;
            Email = emailC;
           
        }
        //Construceur pour récupérer les infos du Supplier 
        public Supplier(string genderC, int idC, string firstNameC, string lastNameC, string emailC)
        {
            gender = genderC;
            id = idC;
            firstName = firstNameC;
            lastName = lastNameC;
            email = emailC;
            
     

        }
        public override string ToString()
        {
            return gender+" "+lastName;
        }

    }
}
