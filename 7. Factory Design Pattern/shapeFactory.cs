using System;

interface IShap {
        void Draw();
}

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