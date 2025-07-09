using System;


interface INotificationService {
    void Send(string message);
}

class SendEmail : INotificationService {
    public void Send(string message){
        Console.WriteLine("Email: " + message);
    }
}
class SendSMS : INotificationService {
    public void Send(string message){
        Console.WriteLine("SMS: " + message);
    }
}
class SendPushNotification : INotificationService{
        public void Send(string message){
                Console.WriteLine("Push Notification: " + message);
        }
}

class NotificationManager {
    private INotificationService _notificationService;
    public NotificationManager(INotificationService notificationService){
        _notificationService = notificationService;
    }
    public void Send (string message){
        _notificationService.Send(message);
    }
}
class Program
{
    public static void Main(string[] args)
    {

               NotificationManager notificationManager = new NotificationManager(new SendEmail());
               notificationManager.Send("Hello, World!");
      

     
    }
}