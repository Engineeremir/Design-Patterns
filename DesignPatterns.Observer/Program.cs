
var phone = new Product("Samsung Galaxy S22", 1000);
var Observer = new Observer("Emirhan KALEM");
var trendyol = new Trendyol();

trendyol.Register(Observer, phone);
trendyol.NotifyWithProductNAme(phone.Name);

Console.ReadLine();
