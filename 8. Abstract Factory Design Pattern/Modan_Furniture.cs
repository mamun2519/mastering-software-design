using System;

interface IChair {
        void Chair();
}

interface ISofa {
        void Sofa();
}

class ModernChair : IChair{
        public void Chair(){
                Console.WriteLine("Modern Chair");
        }
}

class ModernSofa : ISofa {
        public void Sofa(){
                Console.WriteLine("Modern Sofa");
        }
}

class VictorianChair : IChair {
        public void Chair(){
                Console.WriteLine("Victorian Chair");
        }
       
}
        class VictorianSofa : ISofa{
                public void Sofa(){
                        Console.WriteLine("Victorian Sofa");
                }
        }


interface IFurnitureFactory {
        IChair CreateChair();
        ISofa CreateSofa();
}

class ModernFurnitureFactory : IFurnitureFactory {
        public IChair CreateChair(){
                return new ModernChair();
        }
        public ISofa CreateSofa(){
                return new ModernSofa();
        }
}

class VictorianFurnitureFactory : IFurnitureFactory{
        public IChair CreateChair(){
                return new VictorianChair();
        }
        public ISofa CreateSofa(){
                return new VictorianSofa();
        }
}

class FurnitureFactory {
      private IChair chair;
        private ISofa sofa;
        public FurnitureFactory(IFurnitureFactory factory){
                chair = factory.CreateChair();
                sofa = factory.CreateSofa();
        }
        public void CreateFurniture(){
                chair.Chair();
                sofa.Sofa();
        }
}
class Program
{


    public static void Main(string[] args)
    {

            FurnitureFactory furnitureFactory = new FurnitureFactory(new ModernFurnitureFactory());
            furnitureFactory.CreateFurniture();
           
       

    }
}