using System;

interface IWorker {
    void Work();
    void Eat();
}

class HumanWorker : IWorker{
    public void Work() {
        Console.WriteLine("Human is working");
    }
    public void Eat(){
        Console.WriteLine("Human is eating");
    }
}

class RobotWorker : IWorker{
    public void Work(){
        Console.WriteLine("Robot is working");

    }
    public void Eat(){
        Console.WriteLine("Robot is eating"); // brack the ISP
    }
}
class Program
{
    public static void Main(string[] args)
    {
        IWorker human = new HumanWorker();
        IWorker robot = new RobotWorker();
        human.Work();
        human.Eat();
        robot.Work();
        robot.Eat();
       
    }

}