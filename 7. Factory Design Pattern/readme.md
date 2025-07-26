# Factory Design Pattern

Factory Design Pattern হলো একটি Creational Design Pattern, যার মাধ্যমে object তৈরির কাজটি encapsulate করে ফেলা হয় — মানে client (ব্যবহারকারী) কে না জানিয়ে backend এ কোন class এর object তৈরি হবে সেটা Factory class handle করে।

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

Step 1: Interface (Common Product)

```cs
public interface IVehicle
{
    void Drive();
}



```

step 2: Concrete Products

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

Step 3: Factory

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

Step 4: Client Code

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

### ✅ Main Method:

```cs
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Starting application...");
        logger2.Log("Logging from another part");

        Console.WriteLine(logger1 == logger2); // True — কারণ একই instance
    }
}


```

### 🎯 Output:

```cs
Log: Starting application...
Log: Logging from another part
True


```

### 🔒 কেন Constructor private?

```cs
private Logger() { }

```

➡️ কারণ আপনি যদি new Logger() করতে পারেন, তাহলে তো আপনি একাধিক instance তৈরি করতে পারবেন — যা singleton pattern ভেঙে দেবে।

### 🧪 Singleton Pattern কখন ব্যবহার করবেন?

- ✅ Configuration class => সারা অ্যাপে একটাই সেটিংস দরকার

- ✅Logger service => বারবার log লিখতে একই object দরকার

- ✅ Caching service => একটিই memory/cache instance দরকার

- ✅ Database connection => একাধিক connection performance খারাপ করে

### ⚠️ গুরুত্বপূর্ণ সতর্কতা:

- Multithreading environment এ এই singleton সঠিকভাবে কাজ না করতে পারে। সে জন্য Thread-safe Singleton লিখতে হয় (আগামি দিনে শিখব)।

- Overuse করলে flexibility কমে যেতে পারে।

### 🧠 সহজ বাংলায় মনে রাখুন:

“Singleton pattern মানে — এই ক্লাসের জন্য একটা মাত্র object বানাও, বারবার সেটাকেই ব্যবহার করো।”
