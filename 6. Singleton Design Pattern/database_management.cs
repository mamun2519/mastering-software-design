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

        public void query(string sql){
                Console.WriteLine("Query: " + sql);
        }
}

class Program
{


    public static void Main(string[] args)
    {

        
        Database db = Database.getInstance();
            db.query("SELECT * FROM users");

    }
}