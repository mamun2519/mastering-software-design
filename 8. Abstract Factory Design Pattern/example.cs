using System;





interface IGUIFactory {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
}

class WindowsFactory : IGUIFactory {
        public IButton CreateButton(){
                return new WindowsButton();
        }
        public ICheckbox CreateCheckbox(){
                return new WindowsCheckbox();
        }
}

class MacFactory : IGUIFactory {
        public IButton CreateButton(){
                return new MacButton();
        }
        public ICheckbox CreateCheckbox(){
                return new MacCheckbox();
        }
}

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