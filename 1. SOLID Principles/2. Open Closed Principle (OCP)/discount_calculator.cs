using System;

// bed code

class PremiumCustomer : ICustomer{
    public void CalculateDiscount(double price, int quantity, string method){
        Console.WriteLine(price * quantity * 0.8);
    }
}
class VIPCustomer : ICustomer{
    public void CalculateDiscount(double price, int quantity, string method){
        Console.WriteLine(price * quantity * 0.7);
    }
}

class DiscountServices{
    private ICustomer _customer;
    public DiscountServices(ICustomer customer){
        _customer = customer;
    }
    public void CalculateDiscount(double price, int quantity, string method){
        _customer.CalculateDiscount(price, quantity, method);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        BedDiscountCalculator bed = new BedDiscountCalculator();
        bed.CalculateDiscount(100, 2, "Regular");

        // good code
        DiscountServices discountServices = new DiscountServices(new RegularCustomer());
        discountServices.CalculateDiscount(100, 2, "Regular");
    
    }

}