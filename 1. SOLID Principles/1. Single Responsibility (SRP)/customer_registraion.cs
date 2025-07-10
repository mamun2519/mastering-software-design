using System;

class Customer {
    public string name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
}

class ValidaitonManagement {
    public bool Validate(Customer customer){
        return true;
    }
}
class CustomerManagement {
    public void Save(Customer customer){
        ValidaitonManagement vm = new ValidaitonManagement();
        if(vm.Validate(customer)){
            //save to database
            Console.WriteLine("Customer saved successfully");
        }
    }
}
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