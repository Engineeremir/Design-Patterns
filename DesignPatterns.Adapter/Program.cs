// See https://aka.ms/new-console-template for more information


var transaction = new TransferTransaction() { Amount = 10, FromIBAN = "1", ToIBAN = "2" };
var adapter = new JsonBankApiAdapter();
var response = adapter.ExecuteTransaction(transaction);
Console.WriteLine("Result {0}",response);
Console.ReadLine();
class TransferTransaction
{
    public string FromIBAN { get; set; }
    public string ToIBAN { get; set; }
    public decimal Amount { get; set; }
}


interface IBankApi
{
    bool ExecuteTransaction(TransferTransaction transaction);
}

class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi _jsonBankApi;

    public JsonBankApiAdapter()
    {
        _jsonBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _jsonBankApi.ExecuteTransaction(transaction);
    }
}

class XmlBankApiAdapter : IBankApi
{
    private readonly XmlBankApi _xmlBankApi;

    public XmlBankApiAdapter()
    {
        _xmlBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _xmlBankApi.ExecuteTransaction(transaction);
    }
}
class XmlBankApi:IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"""

            <TransferTransaction>
                <FromIBAN>{transaction.FromIBAN}</FromIBAN>
                <ToIBAN>{transaction.ToIBAN}</ToIBAN>
                <Amount>{transaction.Amount}</Amount>
            </TransferTransaction>


            """;

        Console.WriteLine($"{GetType().Name} worked");
        return true;
    }
}

class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var json = $$""""
            {
              ""FromIBAN"": ""{{transaction.FromIBAN}}"",
              ""ToIBAN"":   ""{{transaction.ToIBAN}}"",
              ""Amount"":   ""{{transaction.Amount}}""

            }
            """";

        Console.WriteLine($"{GetType().Name} worked");
        return true;
    }
}