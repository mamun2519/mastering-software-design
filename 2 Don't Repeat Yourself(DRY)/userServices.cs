using System;

interface INotificationService {
    void Notify(string email, string message);
}

class EmailNotificationService : INotificationService {
    public void Notify(string email, string message){
        Console.WriteLine($"Email sent to {email} with message: {message}");
    }
}

class UserService {
    private INotificationService _notifier;

    public UserService(INotificationService notifier){
        _notifier = notifier;
    }

    public void RegisterUser(string email){
        Console.WriteLine($"User registered with email: {email}");
        _notifier.Notify(email, "Welcome to our service");
    }

    public void ResetPassword(string email){
        Console.WriteLine($"Password reset for email: {email}");
        _notifier.Notify(email, "Your password has been reset");
    }
}

class Program {
    public static void Main(string[] args){
        INotificationService notifier = new EmailNotificationService();
        UserService userService = new UserService(notifier);

        userService.RegisterUser("test@example.com");
        userService.ResetPassword("test@example.com");
    }
}
