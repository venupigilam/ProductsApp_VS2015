using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDemos
{
    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }

        public static Dictionary<int, Customer> CustData()
        {
            Dictionary<int, Customer> CustDicitionary = new Dictionary<int, Customer>();

            Customer cust1 = new Customer
            {
                ID = 1,
                Name = "Venu Pigilam",
                Salary = 5000
            };

            Customer cust2 = new Customer
            {
                ID = 2,
                Name = "Anil Podili",
                Salary = 6000
            };

            Customer cust3 = new Customer
            {
                ID = 3,
                Name = "Janga Reddy Marri",
                Salary = 4000
            };

            CustDicitionary.Add(1, cust1);
            CustDicitionary.Add(2, cust2);
            CustDicitionary.Add(3, cust3);

            Customer cust5 = new Customer
            {
                ID = 5,
                Name = "Sudheer",
                Salary = 6000
            };
            CustDicitionary.Add(5, cust5);

            return CustDicitionary;
        }
    }

    
}
