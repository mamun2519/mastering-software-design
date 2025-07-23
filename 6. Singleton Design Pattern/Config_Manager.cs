using System;

class ConfigManager {
        private static ConfigManager _instance;

        private ConfigManager () { }

        public ConfigManager Instance (){
                if (_instance == null)
                {
                    _instance = new ConfigManager();
                }
                return _instance;
        }
} 

class Program
{


    public static void Main(string[] args)
    {

           
           
                

    }
}