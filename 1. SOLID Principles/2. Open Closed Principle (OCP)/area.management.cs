using System;




class Rectangle : IShape{
        public void CalculateArea(){
            // calculate for rectangle
            Console.WriteLine("Rectangle");
        }
}
class Triangle : IShape{
        public void CalculateArea(){
            // calculate for triangle
            Console.WriteLine("Triangle");
        }
}
class Program
{
    public static void Main(string[] args)
    {

        IShape shape = new Circle();
        shape.CalculateArea();
    
    }

}