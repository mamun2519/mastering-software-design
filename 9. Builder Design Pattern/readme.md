# Builder Design Pattern 🚧

### 🔷 Problem Statement:

আপনি এমন একটি অবজেক্ট তৈরি করতে চান যার অনেক অপশনাল পার্ট থাকে। প্রতিবার constructor ব্যবহার করে সব পার্ট define করা ঝামেলার এবং readable নয়। তখন Builder Pattern ব্যবহার করে step-by-step object তৈরি করা যায়।

### 🧱 What is Builder Design Pattern?

Builder Design Pattern এমন একটি creational design pattern যা complex object creation কে simplify করে।

Main Goal: Complex object বানানো step-by-step ভাবে, যেখানে object তৈরির process এবং representation আলাদা করা হয়।

### ।

### 🧰 Key Concepts:

- Product → যেটা তৈরি হবে (e.g., Computer, House)

- Builder Interface → object বানানোর step define করে

- ConcreteBuilder → steps implement করে

- Director (optional) → steps এর order নিয়ন্ত্রণ করে

- Client → builder কে call করে

### 🖥️ Real-Life Example:

একটি Computer build করার কথা ভাবো যেখানে CPU, RAM, HDD আলাদা আলাদা ভাবে যুক্ত করা যায়। কেউ কম RAM চায়, কেউ বেশি। কেউ SSD চায়, কেউ চায় না। এটার জন্য builder pattern perfect.

## C# Code Example: Computer Builder

```cs
using System;

// Product class
class Computer {
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HDD { get; set; }

    public void ShowSpecs() {
        Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, HDD: {HDD}");
    }
}

// Builder interface
interface IComputerBuilder {
    void BuildCPU();
    void BuildRAM();
    void BuildHDD();
    Computer GetComputer();
}

// ConcreteBuilder
class GamingComputerBuilder : IComputerBuilder {
    private Computer _computer = new Computer();

    public void BuildCPU() {
        _computer.CPU = "Intel i9";
    }

    public void BuildRAM() {
        _computer.RAM = "32GB";
    }

    public void BuildHDD() {
        _computer.HDD = "1TB SSD";
    }

    public Computer GetComputer() {
        return _computer;
    }
}

// Director (optional)
class ComputerDirector {
    private IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder) {
        _builder = builder;
    }

    public void BuildComputer() {
        _builder.BuildCPU();
        _builder.BuildRAM();
        _builder.BuildHDD();
    }

    public Computer GetComputer() {
        return _builder.GetComputer();
    }
}

// Client
class Program {
    static void Main(string[] args) {
        IComputerBuilder builder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector(builder);

        director.BuildComputer();
        Computer computer = director.GetComputer();
        computer.ShowSpecs();
    }
}


```

### step 2: Concrete Products

```cs
class WindowsButton : IButton {
    public void Paint() {
        Console.WriteLine("Render a button in Windows style.");
    }
}

class MacButton : IButton {
    public void Paint() {
        Console.WriteLine("Render a button in Mac style.");
    }
}

class WindowsCheckbox : ICheckbox {
    public void Paint() {
        Console.WriteLine("Render a checkbox in Windows style.");
    }
}

class MacCheckbox : ICheckbox {
    public void Paint() {
        Console.WriteLine("Render a checkbox in Mac style.");
    }
}



```

### Step 3: Abstract Factory

```cs
interface IGUIFactory {
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}


```

### Step 4: Concrete Factories

```cs
class WindowsFactory : IGUIFactory {
    public IButton CreateButton() {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox() {
        return new WindowsCheckbox();
    }
}

class MacFactory : IGUIFactory {
    public IButton CreateButton() {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox() {
        return new MacCheckbox();
    }
}


```

### 5. Client Code

```cs
class Application {
    private IButton button;
    private ICheckbox checkbox;

    public Application(IGUIFactory factory) {
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();
    }

    public void Render() {
        button.Paint();
        checkbox.Paint();
    }
}


```

### 6. Main Method

```cs
class Program {
    static void Main(string[] args) {
        IGUIFactory factory;

        string os = "Windows"; // or "Mac"

        if (os == "Windows") {
            factory = new WindowsFactory();
        } else {
            factory = new MacFactory();
        }

        Application app = new Application(factory);
        app.Render();
    }
}


```

### 📘 Real-life Example:

ধরো তুমি e-commerce app বানাচ্ছো। ইউজার যদি বাংলাদেশের হয়, তাহলে BkashPayment, NagadNotification use করবে। ইউজার যদি USA থেকে হয়, তাহলে StripePayment, EmailNotification use করবে। এইভাবে দেশ অনুযায়ী factory switch করতে হয়।
