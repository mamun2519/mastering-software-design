using System;




class Program
{
    public static void Main(string[] args)
    {

 
        orderServices.PlaceOrder(order);
        orderRepository.Save(order);
        emailServices.SendEmail(order);
     
    }
}