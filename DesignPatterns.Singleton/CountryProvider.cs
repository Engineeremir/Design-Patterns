using DesignPatterns.Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class CountryProvider
    {
        private static CountryProvider instance;
        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());
        private new List<Country> Countries { get; set; }
        private CountryProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();
            Countries = new List<Country>()
                {

                new Country(){Name="Turkey"},
                new Country(){Name="Germany"}

                };
        }
        public async Task<List<Country>> GetCountries() => Countries;
    }
}
