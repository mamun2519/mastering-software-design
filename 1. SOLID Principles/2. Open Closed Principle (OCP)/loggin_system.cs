using System;


class FileLogger : Ilogger{
    public void Log(string message){
        Console.WriteLine("FileLogger: " + message);
    }
}
class CloudLogger : Ilogger{
    public void Log(string message){
        Console.WriteLine("CloudLogger: " + message);
    }
}

class LoggerService {
    private Ilogger _logger;
    public LoggerService (Ilogger logger){
        _logger = logger;
    }
    public void Log(string message){
        _logger.Log(message);
    }
}
class Program
{
    public static void Main(string[] args)
    {

        LoggerService loggerService = new LoggerService(new ConsoleLogger());
        loggerService.Log("Hello World");
        loggerService = new LoggerService(new FileLogger());
        loggerService.Log("Hello World");
    
    }

}