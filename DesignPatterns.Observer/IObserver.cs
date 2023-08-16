public interface IObserver
{
    string CustomerName { get; set; }
    void StockUpdate(Product product);
}
