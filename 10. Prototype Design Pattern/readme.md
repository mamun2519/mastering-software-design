# Prototype Design Pattern

### 🧠 What is Prototype Design Pattern?

Prototype Design Pattern হলো একটি Creational Pattern যা কোনো object কে copy বা clone করার জন্য ব্যবহার করা হয়, নতুন object তৈরি না করেই।

Key Idea:
একবার object তৈরি কর, তারপর যখন দরকার, সেই object-এর copy (clone) তৈরি করো।

### 🔍 কখন ব্যবহার করা হয়?

- যখন object তৈরি করা ব্যয়বহুল বা সময়সাপেক্ষ হয়।

- যখন কোনো object-এর অনেক configuration থাকে।

- যখন নতুন object তৈরির বদলে existing object কে duplicate করা বেশি উপযোগী।

### 🖼 Real-life Example:

ধরো একটি গেম বানাচ্ছো। তোমার কাছে অনেক চরিত্র (Character) আছে। প্রতিবার নতুন করে object বানানোর বদলে তুমি একবার বানানো চরিত্র copy করে ব্যবহার করছো।

### 🖥️ Real-Life Example:

একটি Computer build করার কথা ভাবো যেখানে CPU, RAM, HDD আলাদা আলাদা ভাবে যুক্ত করা যায়। কেউ কম RAM চায়, কেউ বেশি। কেউ SSD চায়, কেউ চায় না। এটার জন্য builder pattern perfect.

## C# Code Example

### Step 1: Prototype Interface তৈরি করা

```cs
public interface IPrototype
{
    IPrototype Clone();
}

```

### Step 2: Concrete Class

```cs
public class Employee : IPrototype
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public IPrototype Clone()
    {
        // Shallow copy
        return (IPrototype)this.MemberwiseClone();
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}");
    }
}


```

### Step 3: Client Code

```cs
class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Juboraj", "IT");
        emp1.ShowDetails();

        // Clone emp1 into emp2
        Employee emp2 = (Employee)emp1.Clone();
        emp2.Name = "Mamun";

        emp1.ShowDetails();
        emp2.ShowDetails();
    }
}


```

### Step 3: Client Code

```cs

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Juboraj", "IT");
        emp1.ShowDetails();

        // Clone emp1 into emp2
        Employee emp2 = (Employee)emp1.Clone();
        emp2.Name = "Mamun";

        emp1.ShowDetails();
        emp2.ShowDetails();
    }
}

```

emp2 হলো emp1 এর clone। কিন্তু তুমি চাইলে property গুলো change করতে পারবে।

### 🧠 Deep Copy vs Shallow Copy

- Shallow Copy: শুধু reference copy হয়। Nested object আলাদা হয় না।

- Deep Copy: nested object গুলোও নতুনভাবে copy হয়।

### Deep Copy Example (Serialization ব্যবহার করে)

```cs
public IPrototype DeepClone()
{
    using (var ms = new MemoryStream())
    {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(ms, this);
        ms.Position = 0;
        return (IPrototype)formatter.Deserialize(ms);
    }
}

```

### ✅ Benefits:

- Object creation fast হয়।

Existing object এর উপর ভিত্তি করে নতুন object বানানো যায়।

Complex initialization বারবার করার দরকার হয় না।
