using System;







class Program
{


    public static void Main(string[] args)
    {

            Application app = new Application(new WindowsFactory());
            app.Paint();
            
       

    }
}