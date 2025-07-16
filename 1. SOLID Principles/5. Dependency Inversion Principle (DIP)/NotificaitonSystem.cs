using System;




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