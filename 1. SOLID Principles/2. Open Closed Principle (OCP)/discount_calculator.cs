using System;

// bed code



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