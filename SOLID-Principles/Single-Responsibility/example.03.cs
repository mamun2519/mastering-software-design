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
class Program
{
    public static void Main(string[] args)
    {

            INotificationService notificationService = new SendEmail();
            notificationService.Send("Hello World");
            notificationService = new SendSMS();
            notificationService.Send("Hello World");
      

     
    }
}