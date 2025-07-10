using System;

//bed code



class Bikash : IpaymentProcessor
{
    public void makePayment()
    {
        Console.WriteLine("Bkash Payment");
    }
}
class Nagad : IpaymentProcessor
{
    public void makePayment()
    {
        Console.WriteLine("Nagad Payment");
    }
}
class Rocket : IpaymentProcessor
{
    public void makePayment()
    {
        Console.WriteLine("Rocket Payment");
    }
}

class GooDPaymentServices
{
    public IpaymentProcessor _paymentProcessor;
    public GooDPaymentServices(IpaymentProcessor paymentProcessor)
    {
        this._paymentProcessor = paymentProcessor;
    }
    public void makePayment()
    {
        _paymentProcessor.makePayment();
    }
}

class Program
{
    public static void Main(string[] args)
    {

        // bed code
        PaymentServices paymentServices = new PaymentServices();
        paymentServices.method = "Bkash";
        paymentServices.makePayment();

        // good code
        GooDPaymentServices gooDPaymentServices = new GooDPaymentServices(new Bikash());
        gooDPaymentServices.makePayment();
        gooDPaymentServices = new GooDPaymentServices(new Nagad());
        gooDPaymentServices.makePayment();
    }

}