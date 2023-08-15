
var loggerOptions = new DBLoggerOption()
{
    Log = "logged successfuly",
};

var loggerService = new LoggerService();

while (Console.ReadKey().Key != ConsoleKey.Escape)
{
    Console.WriteLine("Please select the db type for logging (1: SQL, 2: Postgre, 3: Oracle): ");

    ILoggerService dbLoggerService = null;

    var log = Console.ReadLine();
    switch (log)
    {
        case "1":
            dbLoggerService = new SqlLoggerService(); 
            break;
        case "2":
            dbLoggerService = new PostgreLoggerService();
            break;
        case "3":
            dbLoggerService = new OracleLoggerService();
            break;
        default:
            Console.WriteLine("invalid db");
            break;
    }

    loggerService.SetLoggerService(dbLoggerService);
    loggerService.SetLoggerStrategy(loggerOptions);

}