using System;


// bed code
class Shape {
    public string Type;
}

class AreaCalculator {
    public void CalculateArea(Shape shape) {
        if (shape.Type == "Circle") {
            // calculate for circle
        } else if (shape.Type == "Rectangle") {
            // calculate for rectangle
        }
        // etc...
    }
}
// good code
interface IShape {
    void CalculateArea();
}

class Circle : IShape {
        public void CalculateArea(){
            // calculate for circle
            Console.WriteLine("Circle");
        }
}

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