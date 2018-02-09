using CommonDemos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we set the index to 2 but it will allow us to add more than 2
            Console.WriteLine("list of customers in list");
            List<Customer> custlist = new List<Customer>(2);

            Dictionary<int, Customer> dict = Customer.CustData();

            custlist.Add(dict[1]);
            custlist.Add(dict[2]);
            custlist.Add(dict[3]);
            custlist.Add(dict[5]);

            foreach (Customer cust in custlist)
            {
                Console.WriteLine(cust.ID + "/" + cust.Name + "/" + cust.Salary);
            }

            Console.WriteLine("=======================================================================");

            //To retrieve one Customer
            Console.WriteLine("To retrieve one Customer");
            Customer cust1 = custlist[0];
            Console.WriteLine(cust1.ID + "/" + cust1.Name + "/" + cust1.Salary);

            Console.WriteLine("===============================<Insert at Position>========================================");
            //Insert at Position
            custlist.Insert(1, dict[1]);
            
            foreach (Customer cust in custlist)
            {
                Console.WriteLine(cust.ID + "/" + cust.Name + "/" + cust.Salary);
            }

            //Display index position
            Console.WriteLine("===============================<Display index position>========================================");

            Console.WriteLine(custlist.IndexOf(dict[2])); 
            Console.ReadLine();
        }
    }
}
