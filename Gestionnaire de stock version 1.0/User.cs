/**
 * \file      User.cs
 * \author    L. Kirchner Bannwart and S. Sordet 
 * \version   1.0
 * \date      Novembre 07. 2019
 * \brief     Information and methods about a user has.
 *
 * \details   this class contains all the attributes, properties and methods a user can have. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class User
    {
        private int id;
        private string lastName;
        private string firstName;
        private string nameRestaurant;
        private string city;
        private int npa;
        private string street;
        private string email;

        public User(int idC,string lastNameC, string firstNameC, string nameRestaurantC, string cityC, int npaC, string streetC, string emailC)
        {
            id = idC;
            LastName = lastNameC;
            FirstName = firstNameC;
            NameRestaurant = nameRestaurantC;
            Npa = npaC;
            City = cityC;
            Street = streetC;
            Email = emailC;

        }
        public User(string lastNameC, string firstNameC, string nameRestaurantC, string cityC, int npaC, string streetC, string emailC)
        {
   
            LastName = lastNameC;
            FirstName = firstNameC;
            NameRestaurant = nameRestaurantC;
            Npa = npaC;
            City = cityC;
            Street = streetC;
            Email = emailC;

        }

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string NameRestaurant { get => nameRestaurant; set => nameRestaurant = value; }
        public string City { get => city; set => city = value; }
        public int Npa { get => npa; set => npa = value; }
        public string Street { get => street; set => street = value; }
        public string Email { get => email; set => email = value; }
    }
}
