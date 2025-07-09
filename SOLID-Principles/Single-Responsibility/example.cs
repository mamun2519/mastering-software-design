using System;









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