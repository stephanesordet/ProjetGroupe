using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class User
    {
        private string firstName;
        private string lastName;
        private string nameRestaurant;
        private string city;
        private int npa;
        private string street;
        private string email;

        public User(string firstNameC, string lastNameC, string nameRestaurantC, int npaC, string cityC, string streetC, string emailC)
        {
            firstName = firstNameC;
            lastName = lastNameC;
            nameRestaurant = nameRestaurantC;
            npa = npaC;
            city = cityC;
            street = streetC;
            email = emailC;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string NameRestaurant { get => nameRestaurant; set => nameRestaurant = value; }
        public string City { get => city; set => city = value; }
        public int Npa { get => npa; set => npa = value; }
        public string Street { get => street; set => street = value; }
        public string Email { get => email; set => email = value; }
    }
    
}
