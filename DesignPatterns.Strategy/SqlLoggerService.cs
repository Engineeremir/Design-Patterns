// See https://aka.ms/new-console-template for more information



public class SqlLoggerService : ILoggerService
{
    public void Log(DBLoggerOption option)
    {
        Console.WriteLine("DB Logger for Sql worked. Log: {0} ", option.Log);
    }
}

