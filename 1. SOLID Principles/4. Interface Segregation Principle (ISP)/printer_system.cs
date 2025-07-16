using System;

interface IPirnt {
    void Print();
}

interface IScan {
    void Scan();
}
interface iFax{
    void Fax();
}

class Printer : IPirnt {
    public void Print(){
        Console.WriteLine("Printing");
    }
}

class Scanner : IScan {
    public void Scan(){
        Console.WriteLine("Scanning");
    }
}
class Program
{
    public static void Main(string[] args)
    {
       
        Printer printer = new Printer();
        printer.Print();
        Scanner scanner = new Scanner();
        scanner.Scan();
       
    }

}