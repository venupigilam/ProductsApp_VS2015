using CommonDemos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we set the index to 2 but it will allow us to add more than 2
            Console.WriteLine("list of customers in list");
            List<Customer> custlist = new List<Customer>(100);

            Dictionary<int, Customer> dict = Customer.CustData();

            custlist.Add(dict[1]);
            custlist.Add(dict[2]);
            custlist.Add(dict[3]);
            custlist.Add(dict[5]);

            Dictionary<string, Country> DictCoutries = new Dictionary<string, Country>();
            DictCoutries = CommonDemos.Country.GetCountries();
            //Part-1
            //PartOne(custlist);
            //Part-2
            //PartTwo(custlist);
            //Part-3
            //PartThree(custlist);
            //Part-4
            //PartFour(custlist);
            //Part-5
            //partFive(custlist);
            //Part-6
            partSix(DictCoutries);
            Console.ReadLine();
        }

        public static void PartOne(List<Customer> custlist, Dictionary<int, Customer> dict)
        {
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
        }
        public static void PartTwo(List<Customer> custlist)
        {
            //1. Contains
            if (custlist.Contains(custlist[0]))
            {
                Console.WriteLine("Customer 1 Found");
            }
            //2. Exists
            if (custlist.Exists(cust => cust.Name == "Venu"))
            {
                Console.WriteLine("Customer Found");
            }
            else
            {
                Console.WriteLine("Customer not Found");
            }
            //3. Find
            Customer c = custlist.Find(cst => cst.Salary > 5000);
            Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);

            //4. FindLast
            Customer c1 = custlist.FindLast(cst => cst.Salary > 5000);
            Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);

            //5. FindAll
            List<Customer> clst = custlist.FindAll(cst => cst.Salary >= 4000);
            foreach (Customer cc in clst)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", cc.ID, cc.Name, cc.Salary);
            }

            //6. FindIndex
            int index = custlist.FindIndex(cst => cst.Salary > 5000);
            Console.WriteLine("Index for Venu :{0}", index);
            //7. FindLastIndex
            int Lastindex = custlist.FindLastIndex(cst => cst.Salary > 5000);
            Console.WriteLine("Index for Venu :{0}", index);

            //8. ToList
            Customer[] custarr = new Customer[2];
            custarr[0] = custlist[0];
            custarr[1] = custlist[1];

            List<Customer> culst = custarr.ToList();
            foreach (Customer cl in culst)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", cl.ID, cl.Name, cl.Salary);
            }

            //9. ToArray
            Customer[] cstarr = custlist.ToArray();
            //10. ToDictionary
            Dictionary<int, Customer> custdist = custlist.ToDictionary(cd => cd.ID);

        }

        public static void PartThree(List<Customer> custlist)
        {

            Console.WriteLine("AddRange");
            Customer c3 = new Customer { ID = 99, Name = "HP Road", Salary = 5500 };
            Customer c4 = new Customer { ID = 999, Name = "B Nagar", Salary = 6500 };
            List<Customer> CHouses = new List<Customer>();
            CHouses.Add(c3); CHouses.Add(c4);
            custlist.AddRange(CHouses);
            foreach (Customer c in custlist)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);
            }

            Console.WriteLine("InsertRange");
            Customer c9 = new Customer { ID = 9, Name = "Vidya Nagar", Salary = 4500 };
            Customer c91 = new Customer { ID = 91, Name = "H Nagar", Salary = 3500 };

            Console.WriteLine("RemoveAll");
            CHouses.RemoveAll(cc => cc.ID > 9);
            CHouses.Add(c9); CHouses.Add(c91);
            custlist.InsertRange(0, CHouses);
            foreach (Customer c in custlist)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("GetRange");
            List<Customer> cl = custlist.GetRange(0, 2);
            foreach (Customer c in cl)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("RemoveAt");
            custlist.RemoveAt(0);
            foreach (Customer c in custlist)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("RemoveRange");
            custlist.RemoveRange(0, 3);
            foreach (Customer c in cl)
            {
                Console.WriteLine("ID : {0},Name : {1}, Salary : {2}", c.ID, c.Name, c.Salary);
            }

        }

        public static void PartFour(List<Customer> custlist)
        {
            List<int> numbers = new List<int>() { 1, 6, 7, 4, 2, 9 };
            Console.WriteLine("Before Sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            Console.WriteLine("After Sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Reverse();
            Console.WriteLine("After Sorting Desc");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            custlist.Sort();
            Console.WriteLine("Before Sorting");
            foreach (Customer c in custlist)
            {
                Console.WriteLine(c.Salary);
            }
            custlist.Reverse();
            Console.WriteLine("After Sorting");
            foreach (Customer c in custlist)
            {
                Console.WriteLine(c.Salary);
            }
            SortbyName Sn = new SortbyName();

            custlist.Sort(Sn);
            Console.WriteLine("Before Sorting by Name");
            foreach (Customer c in custlist)
            {
                Console.WriteLine(c.Name);
            }
            //custlist.Reverse(Sn);
            //Console.WriteLine("After Sorting by Name Desc");
            //foreach (Customer c in custlist)
            //{
            //    Console.WriteLine(c.Salary);
            //}

            //Comparison
            custlist.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
            Console.WriteLine("Sort by Name : Comparision");
            foreach (Customer c in custlist)
            {
                Console.WriteLine(c.Name);
            }
            custlist.Sort((c1, c2) => c1.Salary.CompareTo(c2.Salary));
            Console.WriteLine("Sort by Name : Comparision");
            foreach (Customer c in custlist)
            {
                Console.WriteLine(c.Name);
            }
        }

        public class SortbyName : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public static void partFive(List<Customer> custlist)
        {
            Console.WriteLine("TrueForAll");
            Console.WriteLine("Are all salaries Greater than 5000 :" + custlist.TrueForAll(c => c.Salary > 5000));

            Console.WriteLine("ReadOnly");
            ReadOnlyCollection<Customer> ReadonlyCustomer = custlist.AsReadOnly();
            Console.WriteLine("ReadOnly customers List" + ReadonlyCustomer.Count());

            Console.WriteLine("List Customers Before TrimExess");
            Console.WriteLine(custlist.Capacity);
            Console.WriteLine("List Customers After TrimExess");
            custlist.TrimExcess();
            Console.WriteLine(custlist.Capacity);
        }

        public static void partSix(Dictionary<string, Country> DictCountry)
        {
            //DictCountry
            string CCode = string.Empty;
            String userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                CCode = Console.ReadLine().ToUpper();
                Country cc = DictCountry.ContainsKey(CCode) ? DictCountry[CCode] : null;
                if (cc != null)
                {
                    Console.WriteLine("Country => Id : {0},Name : {1}, Capital : {2}", cc.Id, cc.Name, cc.Capital);
                }
                else
                {
                    Console.WriteLine("Country Code Not Found");
                }

                do
                {
                    Console.WriteLine("Do you want to Continue : Y/N");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "N" && userChoice !="Y");

            } while (userChoice == "Y");
        }
    }
}
