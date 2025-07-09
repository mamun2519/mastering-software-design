using System;





class GenerateFDF {
    public void Generate(string invoiceNumber){
        Console.WriteLine("Generating FDF for invoice {0}", invoiceNumber);
    }
}

class InvoiceProcessor {
        private SendEmail _sendEmail;
        private GenerateFDF _generateFDF;
    public void Process(Invoice invoice){
        Console.WriteLine("Processing invoice {0}", invoice.InvoiceNumber);
        Console.WriteLine("Invoice date {0}", invoice.InvoiceDate);
        Console.WriteLine("Invoice amount {0}", invoice.InvoiceAmount);
        Console.WriteLine("Customer name {0}", invoice.CustomerName);
    }
    public void SendEmail(string emailAddress, string message){
        _sendEmail.Send(emailAddress, message);
    }
    public void GenerateFDF(string invoiceNumber){
        _generateFDF.Generate(invoiceNumber);
    }
   
}

class Program
{
    public static void Main(string[] args)
    {

        Invoice invoice = new Invoice();
        invoice.InvoiceNumber = "12345";
        invoice.InvoiceDate = DateTime.Now;
        invoice.InvoiceAmount = 100.00m;
        invoice.CustomerName = "John Doe";
        InvoiceProcessor processor = new InvoiceProcessor();
        processor.Process(invoice);
        processor.SendEmail("john.doe@email.com", "Your invoice is ready");
        processor.GenerateFDF(invoice.InvoiceNumber);
        

     
    }
}