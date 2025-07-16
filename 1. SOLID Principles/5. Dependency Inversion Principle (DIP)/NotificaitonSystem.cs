using System;

interface INotificationSender{
 void send(string message);
}

class EmailNotificationSender : INotificationSender {
    public void send(string message){
        Console.WriteLine("Email: " + message);
    }
}
class SMSNotificationSender : INotificationSender {
    public void send(string message){
        Console.WriteLine("SMS: " + message);
    }
}

class NotificationService {
    private INotificationSender _notificationSender;
    public NotificationService(INotificationSender notificationSender){
        _notificationSender = notificationSender;
    }

    public void sendNotification(string message){
        _notificationSender.send(message);
    }
}

class Program
{
    public static void Main(string[] args)
    {
       
      
        NotificationService notificationService = new NotificationService(new EmailNotificationSender());
        notificationService.sendNotification("Hello, World!");
        notificationService = new NotificationService(new SMSNotificationSender());
        notificationService.sendNotification("Hello, World!");
    }

}