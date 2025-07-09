using System;

class Invoice {
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal InvoiceAmount { get; set; }
    public  string CustomerName { get; set; }
}

class SendEmail {
    public void Send(string emailAddress, string message){
        Console.WriteLine("Sending email to {0} with message {1}", emailAddress, message);
    }
}

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
   
}

class InvoiceEmailSender {
    private readonly SendEmail _sendEmail = new SendEmail();

    public void Send(Invoice invoice, string emailAddress){
        string message = $"Invoice #{invoice.InvoiceNumber} is ready.";
        _sendEmail.Send(emailAddress, message);
    }
}

class InvoicePDFGenerator {
    private readonly GenerateFDF _generateFDF = new GenerateFDF();

    public void Generate(Invoice invoice){
        _generateFDF.Generate(invoice.InvoiceNumber);
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
        InvoiceEmailSender emailSender = new InvoiceEmailSender();
        emailSender.Send(invoice, "john.doe@example.com");
        InvoicePDFGenerator pdfGenerator = new InvoicePDFGenerator();
        pdfGenerator.Generate(invoice);  
        

     
    }
}