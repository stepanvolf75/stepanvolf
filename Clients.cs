using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Client
    {
        // data pojištěného
        public string FirstName;
        public string LastName;
        public int Age;
        public string PhoneNumber;
        public string InsuranceNumber;

        // konstruktor
        public Client(string FirstName, string LastName, int Age, string PhoneNumber, string InsuranceNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.InsuranceNumber = InsuranceNumber;
        }
        
        // seznam pojištěných
        public static List<Client> ListOfClients = new List<Client>();

        // ToString pro výpis dat pojištěnců
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", FirstName, LastName, Age, PhoneNumber, InsuranceNumber);
        }
    }
}
