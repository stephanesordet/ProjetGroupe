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
    }
    
}
