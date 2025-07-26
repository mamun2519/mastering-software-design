# Abstract Factory Design Pattern

### 📌 Definition:

Abstract Factory Design Pattern একটি Factory-এর Factory। এটি একটি interface বা abstract class তৈরি করে যা related object-গুলোর family তৈরি করতে পারে, subclass নির্দিষ্ট না করেই।

### 🧠 Concept:

ধরুন আপনি একাধিক ধরনের Product তৈরি করেন – যেমন Car, Bike, Truck। আপনি চাইলে new Car(), new Bike() করে প্রতিবার নিজে নিজে তৈরি করতে পারেন, কিন্তু এতে tightly coupled হয়ে যায় কোড।

Factory pattern ব্যবহার করলে, আপনি Factory কে শুধু বলে দেন — "আমার Bike লাগবে" — এবং Factory আপনাকে Bike দিয়ে দেয়। কীভাবে বানাবে সেটা আপনি জানেন না, জানতেও হবে না।

### 🏗️ Structure:

```vbnet
        Client
           |
        Factory
        /  |  \
    Car Bike Truck  --> Implements Product Interface


```

✅ Use Cases:

- Object creation complicated হলে

- Subclasses কোনটা instantiate হবে সেটা runtime এ ঠিক হলে

- Object creation logic centralize করতে চাইলে

### Example:

### Step 1: Interface (Common Product)

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
