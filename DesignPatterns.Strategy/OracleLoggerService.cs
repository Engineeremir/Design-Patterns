// See https://aka.ms/new-console-template for more information



public class OracleLoggerService : ILoggerService
{
    public void Log(DBLoggerOption option)
    {
        Console.WriteLine("DB Logger for Oracle worked. Log: {0} ", option.Log);
    }
}

