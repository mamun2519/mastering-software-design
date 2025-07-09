using System;









class Program
{
    public static void Main(string[] args)
    {

        
        
        processor.Process(invoice);
        processor.SendEmail("john.doe@email.com", "Your invoice is ready");
        processor.GenerateFDF(invoice.InvoiceNumber);
        

     
    }
}