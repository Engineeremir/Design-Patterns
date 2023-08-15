// See https://aka.ms/new-console-template for more information



public class LoggerService
{
    private ILoggerService _loggerService;

    public LoggerService(ILoggerService loggerService)
    {
        _loggerService = loggerService;
    }

    public LoggerService()
    {
         
    }

    public void SetLoggerService(ILoggerService loggerService)
    {
        _loggerService = loggerService;
    }
    public void SetLoggerStrategy(DBLoggerOption log)
    {
        _loggerService.Log(log);
    }

    
}

