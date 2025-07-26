# Builder Design Pattern 🚧

### 🔷 Problem Statement:

আপনি এমন একটি অবজেক্ট তৈরি করতে চান যার অনেক অপশনাল পার্ট থাকে। প্রতিবার constructor ব্যবহার করে সব পার্ট define করা ঝামেলার এবং readable নয়। তখন Builder Pattern ব্যবহার করে step-by-step object তৈরি করা যায়।

### 🧱 What is Builder Design Pattern?

Builder Design Pattern এমন একটি creational design pattern যা complex object creation কে simplify করে।

Main Goal: Complex object বানানো step-by-step ভাবে, যেখানে object তৈরির process এবং representation আলাদা করা হয়।

### 🏗 উদাহরণ দিয়ে বোঝাই

ধরো তুমি একটি অ্যাপ বানাচ্ছো যা দুটি OS-এ কাজ করবে: Windows এবং Mac। প্রত্যেক OS এর নিজস্ব Button এবং Checkbox থাকে। তুমি চাও এমন একটা সিস্টেম যা runtime-এ ঠিক করবে কোন OS এর UI component তৈরি হবে।

## 🧩 Step-by-step Implementation (C#):

### 1. Product Interfaces

```cs
interface IButton {
    void Paint();
}

interface ICheckbox {
    void Paint();
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
