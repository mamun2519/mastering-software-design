using System;



class Circle : IShap{
        public void Draw(){
                Console.WriteLine("Drawing Circle");
        }
}

class Rectangle : IShap {

        public void Draw(){
                Console.WriteLine("Drawing Rectangle");
        }
        
}

class Triangle : IShap {
        public void Draw(){
                Console.WriteLine("Drawing Triangle");
        }
}

class ShapeFactory {
        public IShap GetShape(string shapeType){
                if(shapeType == null){
                        return null;
                }
                if(shapeType.Equals("CIRCLE")){
                        return new Circle();
                } else if(shapeType.Equals("RECTANGLE")){
                        return new Rectangle();
                } else if(shapeType.Equals("TRIANGLE")){
                        return new Triangle();
                }
                return null;
        }
}
class Program
{


    public static void Main(string[] args)
    {

            ShapeFactory shapeFactory = new ShapeFactory();
            IShap shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.Draw();
            IShap shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.Draw();
       

    }
}