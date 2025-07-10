using System;


class OrderServices {
    public void PlaceOrder(Order order){
        Console.WriteLine("Order placed for " + order.orderEmail);
    }
}

class OrderRepository {
    public void Save(Order order){
        Console.WriteLine("Order saved for " + order.orderEmail);
    }
}

class EmailServices {
    public void SendEmail(Order order){
        Console.WriteLine("Email sent for " + order.orderEmail);
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Order order = new Order{ orderNumber = "123", orderEmail = "test@test.com"};
        OrderServices orderServices = new OrderServices();
        OrderRepository orderRepository = new OrderRepository();
        EmailServices emailServices = new EmailServices();
        orderServices.PlaceOrder(order);
        orderRepository.Save(order);
        emailServices.SendEmail(order);
     
    }
}