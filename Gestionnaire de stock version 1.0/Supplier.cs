/**
 * \file      Supplier.cs
 * \author    L. Kirchner Bannwart and S. Sordet 
 * \version   1.0
 * \date      Novembre 07. 2019
 * \brief     Information and methods about a supplier has.
 *
 * \details   this class contains all the attributes, properties and methods a supploier can have. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{//Création de la classe Supplier
    public class Supplier
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

        public int Id { get => id; set => id = value; }
        public string Gender { get => gender; set => gender = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Company { get => company; set => company = value; }
        public string City { get => city; set => city = value; }
        public int Npa { get => npa; set => npa = value; }
        public string Street { get => street; set => street = value; }
        public string Email { get => email; set => email = value; }

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
            Gender = genderC;
            Id = idC;
            FirstName = firstNameC;
            LastName = lastNameC;
            Email = emailC;
            
     

        }
        public override string ToString()
        {
            return Gender+" "+LastName;
        }

    }
}
