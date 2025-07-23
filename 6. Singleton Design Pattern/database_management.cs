using System;
using System.Collections.Generic;

public class Database {
        private static Database instance  = new Database();

        private Database (){
                Console.WriteLine("Database created");
        }

        public static Database getInstance(){
                return instance;
        }

        

class Program
{


    public static void Main(string[] args)
    {

     

    }
}