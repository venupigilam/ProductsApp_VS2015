using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDemos
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Capital { get; set; }

        public static Dictionary<string, Country> GetCountries()
        {
            //List<Country> countries = new List<Country>();
            Dictionary<string, Country> DictionaryCountries = new Dictionary<string, Country>();
            Country c1 = new Country { Id = 1, Name = "INDIA", Capital = "Delhi" };
            Country c2 = new Country { Id = 2, Name = "PAKISTHAN", Capital = "" };
            Country c3 = new Country { Id = 3, Name = "SRILANKA", Capital = "Colombo" };
            Country c4 = new Country { Id = 4, Name = "USA", Capital = "Washington DC" };
            Country c5 = new Country { Id = 5, Name = "CHINA", Capital = "Beijing" };

            DictionaryCountries.Add(c1.Name, c1);
            DictionaryCountries.Add(c2.Name, c2);
            DictionaryCountries.Add(c3.Name, c3);
            DictionaryCountries.Add(c4.Name, c4);
            DictionaryCountries.Add(c5.Name, c5);

            return DictionaryCountries;
        }
    }


}
