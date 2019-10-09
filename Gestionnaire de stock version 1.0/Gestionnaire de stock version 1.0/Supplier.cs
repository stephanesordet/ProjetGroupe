using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0
{
    class Supplier
    {

        public int id;
        public string gender;
        public string firstName;
        public string lastName;
        public string company;
        public string city;
        public int npa;
        public string street;
        public string email;

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
        public Supplier(int idC, string firstNameC, string lastNameC)
        {
            id = idC;
            firstName = firstNameC;
            lastName = lastNameC;
            
     

        }
        public override string ToString()
        {
            return firstName+" "+lastName;
        }

    }
}
