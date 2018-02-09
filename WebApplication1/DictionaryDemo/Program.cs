using CommonDemos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Getting Customer Dictionary
            Dictionary<int, Customer> CustDist = CommonDemos.Customer.CustData();

            //Part-1
            //1. A dictionary is a collection of(key, value) pairs.
            //2. Dictionary class is present in System.Collections.Generic namespace.
            //3. When creating a dictionary, we need to specify the type for key and value.
            //4. Dictionary provides fast lookups for values using keys.
            //5. Keys in the dictionary must be unique.

            //DictionaryPart1(CustDist);

            //Part-2
            //1.TryGetValue()
            //2.Count()
            //3.Remove()
            //4.Clear()
            //5.Using LINQ extension methods with Dictionary
            //6.Different ways to convert an array into a dictionary
            DictionaryPart2(CustDist);

            Console.ReadLine();
        }
        
        

        public static void DictionaryPart1(Dictionary<int, Customer> CustDicitionary)
        {

            // If you try to add a key that already exists in the dictionary you 
            // will get an exception - An item with same key has already been 
            // added. So, check if the key already exists

            if (!CustDicitionary.ContainsKey(5))
            {
                Customer cust6 = new Customer
                {
                    ID = 5,
                    Name = "Sudheer",
                    Salary = 6000
                };
                CustDicitionary.Add(5, cust6);
            }
            //To Get Cust-1 Data
            //To Check whether the customer with id 1 is there or not
            if (CustDicitionary.ContainsKey(6))
            {
                Console.WriteLine("Customer-1 Data ", CustDicitionary[1]);
            }


            //To Print All Customers
            Console.WriteLine("To Print All Customers");
            foreach (KeyValuePair<int, Customer> CustDict in CustDicitionary)
            {
                Console.WriteLine(CustDict.Key + "-" + CustDict.Value.Name + "-" + CustDict.Value.Salary);
            }

            //To Print All Customers with var Keyword
            Console.WriteLine("To Print All Customers with Var Keyword");
            foreach (var CustDict in CustDicitionary)
            {
                Console.WriteLine(CustDict.Key + "-" + CustDict.Value.Name + "-" + CustDict.Value.Salary);
            }

            //To Get All the Keys
            Console.WriteLine(" All the Keys in Dictionary");
            foreach (int keys in CustDicitionary.Keys)
            {
                Console.WriteLine(keys + ",");
            }

            //To Get All the Keys
            Console.WriteLine(" All the Values in Dictionary");
            foreach (Customer values in CustDicitionary.Values)
            {
                Console.WriteLine(values.Name + '-' + values.Salary + ",");
            }
        }

        public static void DictionaryPart2(Dictionary<int, Customer> CustDicitionary)
        {
            // If you are not sure if a key is present or not, you can use 
            // TryGetValue() method to get the value from a dictionary.
            Customer Cust5;
            if (CustDicitionary.TryGetValue(6, out Cust5))
            {
                Console.WriteLine("Customer - 5 data");
                Console.WriteLine(Cust5.ID + " : " + Cust5.Name + " " + Cust5.Salary);
            }
            else
            {
                Console.WriteLine("Customer not Found..");
            }

            //to Find Total no.of Customers in Dictionary
            Console.WriteLine("Total Customers:" + CustDicitionary.Count());

            //Total Customers with Salary is Greater than Entered Amount

            var CustCount = CustDicitionary.Count(cd => cd.Value.Salary > 5000);
            Console.WriteLine("Customers with Salary Greater than 5000 : " + CustCount);

            //To Remove one item from the Dictionary 
            //CustDicitionary.Remove(1);
            Console.WriteLine(CustDicitionary.Count());

            //To Remove all Customers from the Dictionary
            //CustDicitionary.Clear();
            //Console.WriteLine(CustDicitionary.Count());

            //Create an Array of Customer and Convert this into Dictionary

            Customer[] ArrayCustomers = new Customer[4];
            ArrayCustomers[0] = CustDicitionary[1];
            ArrayCustomers[1] = CustDicitionary[2];
            ArrayCustomers[2] = CustDicitionary[3];
            ArrayCustomers[3] = CustDicitionary[5];

            //Type-1
            Console.Write("Type:1");
            Dictionary<int, Customer> dict = ArrayCustomers.ToDictionary(Customer => Customer.ID, Customer => Customer);
            
            foreach (var cust in dict)
            {
                Console.Write(cust.Value.ID + "-" + cust.Value.Name + "-" + cust.Value.Salary);
            }

            //Type-2
            Console.Write("Type:2");
            Dictionary<int, Customer> dict1 = ArrayCustomers.ToDictionary(customer => customer.ID);

            foreach (var cust in dict1)
            {
                Console.Write(cust.Value.ID + "-" + cust.Value.Name + "-" + cust.Value.Salary);
            }

            Dictionary<int, Customer> dict2 = new Dictionary<int, Customer>();
            //Type-3
            Console.Write("Type:3");
            foreach (Customer cust in ArrayCustomers)
            {
                dict2.Add(cust.ID, cust);
            }

            foreach (var cust in dict2)
            {
                Console.Write(cust.Value.ID + "-" + cust.Value.Name + "-" + cust.Value.Salary);
            }

          
        }
    }
}
