using System;

//bed code







class Program
{
    public static void Main(string[] args)
    {

        
        // good code
        GooDPaymentServices gooDPaymentServices = new GooDPaymentServices(new Bikash());
        gooDPaymentServices.makePayment();
        gooDPaymentServices = new GooDPaymentServices(new Nagad());
        gooDPaymentServices.makePayment();
    }

}