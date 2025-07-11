using System;



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



class Program
{
    public static void Main(string[] args)
    {



        User user = new User();
        user.name = "John";
        user.email = "john@doe.com";
        user.password = "123456";
        UserService userService = new UserService();
        userService.register(user);
        SendEmail sendEmail = new SendEmail();
        sendEmail.sendEmail(user);
    }
}