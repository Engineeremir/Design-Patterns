// See https://aka.ms/new-console-template for more information



public class PostgreLoggerService : ILoggerService
{
    public void Log( DBLoggerOption option)
    {
        Console.WriteLine("DB Logger for Postgre worked. Log: {0} ", option.Log);
    }
}

