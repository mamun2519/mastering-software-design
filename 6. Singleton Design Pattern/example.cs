using System;

class Logger {

        private static Logger _instance;
        private Logger(){}

        public static Logger GetInstance(){
                if(_instance == null){
                        _instance = new Logger();
                }
                return _instance;
        }

        public void Log(string message){
                Console.WriteLine(message);
        }
}


class Program
{


    public static void Main(string[] args)
    {

            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Starting application...");
            logger2.Log("Logging from another part");

            Console.WriteLine(logger1 == logger2);
            
           
                

    }
}