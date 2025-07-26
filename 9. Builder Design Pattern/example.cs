using System;

class Cumputer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HDD { get; set; }

    public void ShowSpecs()
    {
        Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, HDD: {HDD}");
    }
}

interface IComputerBuilder{
        void BuildCPU();
        void BuildRAM();
        void BuildHDD();
        Cumputer GetComputer();
}

class ComputerBuilder : IComputerBuilder{
        private Cumputer cumputer = new Cumputer();
        public void BuildCPU(){
                cumputer.CPU = "Intel i7";
        }
        public void BuildRAM(){
                cumputer.RAM = "16GB";
        }
        public void BuildHDD(){
                cumputer.HDD = "1TB";
        }
        public Cumputer GetComputer(){
                return cumputer;
        }
}


class ComputerDirector {
        private IComputerBuilder builder;
        public ComputerDirector(IComputerBuilder builder){
                this.builder = builder;
                
        }
        public void buildComputer(){
                builder.BuildCPU();
                builder.BuildRAM();
                builder.BuildHDD();
        }

        public Cumputer GetComputer(){
                return builder.GetComputer();
        }
}
class Program
{


    public static void Main(string[] args)
    {



        IComputerBuilder builder = new ComputerBuilder();
            ComputerDirector director = new ComputerDirector(builder);
            director.buildComputer();
            Cumputer cumputer = director.GetComputer();
            cumputer.ShowSpecs();

    }
}