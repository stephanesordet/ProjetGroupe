using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Supplier
    {

        private string gender;
        private string firstName;
        private  string lastName;
        private string company;
        private string city;
        private int npa;
        private string street;
        private string email;

        public Supplier(string genderC, string firstNameC, string lastNameC, string companyC, int npaC, string cityC, string streetC, string emailC)
        {
            gender = genderC;
            firstName = firstNameC;
            lastName = lastNameC;
            company = companyC;
            npa = npaC;
            city = cityC;
            street = streetC;
            email = emailC;
           
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Company { get => company; set => company = value; }
        public string City { get => city; set => city = value; }
        public int Npa { get => npa; set => npa = value; }
        public string Street { get => street; set => street = value; }
        public string Email { get => email; set => email = value; }
    }
}
