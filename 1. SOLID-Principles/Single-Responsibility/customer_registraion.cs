using System;




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