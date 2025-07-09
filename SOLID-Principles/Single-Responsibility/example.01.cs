using System;


}
class User
{
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
}

class UserService
{
    public void register(User user)
    {
        // register user
        Console.WriteLine("User registered", user.name);
    }
}

class SendEmail
{
    public void sendEmail(User user)
    {
        // send email
        Console.WriteLine("Email sent to", user.email);
    }
}


class ReportFileSaver
{
    public void saveToFile(GoodReport report, string fileName)
    {
        System.IO.File.WriteAllText(fileName, report.content);
    }
}
class Program
{
    public static void Main(string[] args)
    {



    
      
       
    }
}