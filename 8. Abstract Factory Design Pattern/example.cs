using System;






class Application {
        private IButton button;
        private ICheckbox checkbox;
        public Application (IGUIFactory factory){
                        button = factory.CreateButton();
                        checkbox = factory.CreateCheckbox();
        }
        public void Paint(){
                button.Print();
                checkbox.Print();
        }
}
class Program
{


    public static void Main(string[] args)
    {

            Application app = new Application(new WindowsFactory());
            app.Paint();
            
       

    }
}