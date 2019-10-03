using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class User
    {
        public string firstName;
        public string lastName;
        public string nameRestaurant;
        public string city;
        public int npa;
        public string street;
        public string email;

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
    }
    
}
