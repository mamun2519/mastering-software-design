using System;

// bed code
class BedDiscountCalculator{
    public void CalculateDiscount(double price, int quantity, string method){
         if(method == "Regular"){
             Console.WriteLine(price * quantity * 0.9);
         }
         else if(method == "Premium"){
             Console.WriteLine(price * quantity * 0.8);
         }
        else if(method == "VIP"){
             Console.WriteLine(price * quantity * 0.7);
        }
    }
}
// good code
interface ICustomer{
    void CalculateDiscount(double price, int quantity, string method);
}

class RegularCustomer : ICustomer{
    public void CalculateDiscount(double price, int quantity, string method){
        Console.WriteLine(price * quantity * 0.9);
    }
}
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