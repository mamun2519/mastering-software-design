using System;

class InvoiceService {
    public void SendInvoice(){
        Console.WriteLine("Invoice sent");
        sendMail("test@test.com");
    }
    public void SendInvoice(string email){
        Console.WriteLine("Invoice sent to "+email);
        sendMail(email);
    }

    public void sendMail(string email){
        Console.WriteLine("Mail sent to "+email);
    }
}

class Program {
    public static void Main(string[] args){
        InvoiceService invoiceService = new InvoiceService();
        invoiceService.SendInvoice();
        invoiceService.SendInvoice("test2@test.com");
        
    }
}