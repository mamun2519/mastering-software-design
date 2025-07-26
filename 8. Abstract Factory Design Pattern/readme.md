# Abstract Factory Design Pattern

### 📌 Definition:

Abstract Factory Design Pattern একটি Factory-এর Factory। এটি একটি interface বা abstract class তৈরি করে যা related object-গুলোর family তৈরি করতে পারে, subclass নির্দিষ্ট না করেই।

### 🎯 যখন ব্যবহার করা হয়:

- যখন related object গুলো একসাথে ব্যবহার করতে হয়।

- যখন object তৈরি করার process subclass-এর উপর ছেড়ে দিতে হয়।

- যখন আপনাকে multiple families of products তৈরি করতে হয়।

### 🏗 উদাহরণ দিয়ে বোঝাই

ধরো তুমি একটি অ্যাপ বানাচ্ছো যা দুটি OS-এ কাজ করবে: Windows এবং Mac। প্রত্যেক OS এর নিজস্ব Button এবং Checkbox থাকে। তুমি চাও এমন একটা সিস্টেম যা runtime-এ ঠিক করবে কোন OS এর UI component তৈরি হবে।

## 🧩 Step-by-step Implementation (C#):

### 1. Product Interfaces

```cs
public interface IVehicle
{
    void Drive();
}



```

### step 2: Concrete Products

```cs
public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Car");
    }
}

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a Bike");
    }
}


```

### Step 3: Factory

```cs
public class VehicleFactory
{
    public static IVehicle GetVehicle(string type)
    {
        if (type.ToLower() == "car")
            return new Car();
        else if (type.ToLower() == "bike")
            return new Bike();
        else
            throw new Exception("Vehicle type not supported");
    }
}


```

### Step 4: Client Code

```cs
class Program
{
    static void Main(string[] args)
    {
        IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
        vehicle1.Drive();

        IVehicle vehicle2 = VehicleFactory.GetVehicle("bike");
        vehicle2.Drive();
    }
}


```

### 🧠 Benefits:

- ✅ Loose Coupling
- ✅ Object creation encapsulated
- ✅ Clean and maintainable code

### 🚫 Without Factory:

```cs
 Car car = new Car();
Bike bike = new Bike();
// এখানে tightly coupled হয়ে গেছে

```

### 🔍 Real-life Analogy:

একটা কফি শপে গিয়ে আপনি বলেন "আমাকে এক কাপ লাট্টে দিন" – আপনি জানেন না কিভাবে সেটা বানায়। Barista বা Factory সেটার দায়িত্ব নেয়।
