using System;
using System.Collections.Generic;

public  class ConfigManager
{
    private static readonly ConfigManager instance = new ConfigManager();
    private Dictionary<string, string> settings = new Dictionary<string, string>();

    private ConfigManager() { }

    public static ConfigManager Instance => instance;

    public void Set(string key, string value)
    {
        settings[key] = value;
    }

    public string Get(string key)
    {
        return settings.ContainsKey(key) ? settings[key] : null;
    }
}

class Program
{


    public static void Main(string[] args)
    {

        ConfigManager config = ConfigManager.Instance;
        config.Set("API_KEY", "837438743");
        config.Set("API_URL", "https://api.example.com");
        Console.WriteLine(config.Get("API_KEY")); // Output: 837438743
        Console.WriteLine(config.Get("API_URL")); // Output: https://api.example.com



    }
}