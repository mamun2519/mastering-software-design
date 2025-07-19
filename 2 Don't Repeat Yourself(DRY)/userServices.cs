using System;

class UserService {
    public void RegisterUser(string email){
        Console.WriteLine($"User registered with email: {email}");
        SendEmail(email, "Welcome to our service");
    }
    public void ResetPassword(string email){
        Console.WriteLine($"Password reset for email: {email}");
        SendEmail(email, "Your password has been reset");
    }
    public void SendEmail(string email, string message){
        Console.WriteLine($"Email sent to {email} with message: {message}");
    }
}

class Program {
    public static void Main(string[] args){
         UserService userService = new UserService();
         userService.RegisterUser("test@example.com");
         userService.ResetPassword("test@example.com");
        
    }
}