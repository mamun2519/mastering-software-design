# Prototype Design Pattern

### 🧠 What is Prototype Design Pattern?

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

### 🧠 Benefits:

- ✅ Complex object বানানো সহজ হয়
- ✅ Readable and Maintainable code
- ✅ Same process, different representation possible
