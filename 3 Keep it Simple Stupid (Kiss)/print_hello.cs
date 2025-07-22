using System;

// bed code


class Program
{  
        // bad code
      static   void PrintHello5Times()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    Console.WriteLine("Hello");
                }
            }
        }
        // good code
        static void PrintHello5TimesGood(){
                for(int i = 0; i < 5; i++){
                        Console.WriteLine("Hello");
                }
        }
        
    public static void Main(string[] args)
    {
        PrintHello5Times();

    }
}