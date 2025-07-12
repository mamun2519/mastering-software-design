using System;






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