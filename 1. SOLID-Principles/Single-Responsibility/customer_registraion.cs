using System;



class EmailManagement {
    public void SendEmail(Customer customer){
        //send email
        Console.WriteLine("Email sent successfully");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer{ name = "John", email = "john@doe.com", phone ="029484954"};
         CustomerManagement cm = new CustomerManagement();
         cm.Save(customer);
         EmailManagement em = new EmailManagement();
         em.SendEmail(customer);
        
        }
      
}