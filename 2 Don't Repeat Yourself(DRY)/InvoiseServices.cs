using System;

interface IMessenger {
    void Send(string email, string message);
}

class EmailMessenger : IMessenger {
    public void Send(string email, string message){
        Console.WriteLine($"Email sent to {email} with message: {message}");
    }
}

class InvoiceService {
    private IMessenger _messenger;

    public InvoiceService(IMessenger messenger){
        _messenger = messenger;
    }

    public void SendInvoice(){
        Console.WriteLine("Invoice sent");
        _messenger.Send("test@test.com", "Your invoice is ready.");
    }

    public void SendInvoice(string email){
        Console.WriteLine("Invoice sent to " + email);
        _messenger.Send(email, "Your invoice is ready.");
    }
}

class Program {
    public static void Main(string[] args){
        IMessenger messenger = new EmailMessenger();
        InvoiceService invoiceService = new InvoiceService(messenger);

        invoiceService.SendInvoice();
        invoiceService.SendInvoice("test2@test.com");
    }
}
