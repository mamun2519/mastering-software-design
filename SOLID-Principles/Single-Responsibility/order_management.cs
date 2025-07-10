using System;




class Program
{
    public static void Main(string[] args)
    {

       
        OrderRepository orderRepository = new OrderRepository();
        EmailServices emailServices = new EmailServices();
        orderServices.PlaceOrder(order);
        orderRepository.Save(order);
        emailServices.SendEmail(order);
     
    }
}