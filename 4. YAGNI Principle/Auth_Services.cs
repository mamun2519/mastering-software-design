using System;

// bed code
class AuthService01
{
    public void RegisterUser(string userType)
    {
        if (userType == "admin")
        {
            Console.WriteLine("Registering admin user...");
        }
        else if (userType == "customer")
        {
            Console.WriteLine("Registering customer...");
        }
        else if (userType == "vendor")
        {
            Console.WriteLine("Registering vendor...");
        }
        else if (userType == "moderator")
        {
            Console.WriteLine("Registering moderator...");
        }
    }
}
// good code

class AuthService02
{
    public void RegisterUser(string userType)
    {
        if (userType == "admin")
        {
            Console.WriteLine("Registering admin user...");
        }
        else if (userType == "customer")
        {
            Console.WriteLine("Registering customer...");
        }
    }
}


class Program
{


    public static void Main(string[] args)
    {

            AuthService01 authService01 = new AuthService01();
            authService01.RegisterUser("admin");
            authService01.RegisterUser("customer");
        
                

    }
}