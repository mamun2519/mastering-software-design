using System;

interface Iworkable {
    void work();
}
interface Ieatable{
    void eat();
}

class Human : Iworkable, Ieatable {
    public void work(){
        Console.WriteLine("Human works");
    }
    public void eat(){
        Console.WriteLine("Human eats");
    }
    
}
class     Robot : Iworkable{
    public void work(){
        Console.WriteLine("Robot works");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Human human = new Human();
        Robot robot = new Robot();
        human.work();
        human.eat();
        robot.work();
            
       
    }

}