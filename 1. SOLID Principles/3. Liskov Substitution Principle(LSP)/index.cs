using System;
interface IBird {
    void Eat();
}
interface IflyingBird : IBird {
    void Fly();
}
class Sparrow : IflyingBird{
    public void Eat(){
        Console.WriteLine("Sparrow is eating");
    }
    public void Fly(){
        Console.WriteLine("Sparrow is flying");
    }
}
class Ostrich : IBird {
    public void Eat(){
            Console.WriteLine("Ostrich is eating");
    }
}
class Program
{
    public static void Main(string[] args)
    {
      
        Sparrow sparrow = new Sparrow();
        sparrow.Eat();
        sparrow.Fly();
        Ostrich ostrich = new Ostrich();
        ostrich.Eat();
    }

}