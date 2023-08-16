


public class Trendyol
{
    private Dictionary<IObserver, Product> keyValuePairs = new();
    public void Register(IObserver observer, Product product)
    {
        keyValuePairs.TryAdd(observer, product);
    }

    public void UnRegister(IObserver observer, Product product)
    {
        keyValuePairs.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach (var kv in keyValuePairs)
        {
            kv.Key.StockUpdate(kv.Value);
        }
    }

    public void NotifyWithProductNAme(string productName)
    {
        foreach (var kv in keyValuePairs)
        {
            if(productName == kv.Value.Name)
                kv.Key.StockUpdate(kv.Value);

        }
    }
}
