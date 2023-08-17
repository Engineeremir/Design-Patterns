using DesignPatterns.Singleton;

Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries = await CountryProvider.Instance.GetCountries();

foreach (var country in countries)
    Console.WriteLine(country.Name);