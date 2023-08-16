



public class Observer : IObserver
{
    public string CustomerName { get; set; }

    public Observer(string customerName)
    {
        CustomerName = customerName;
    }

    public void StockUpdate(Product product)
    {
        Console.WriteLine($"Dear {CustomerName}, {product.Name} is in stock now");
    }
}
