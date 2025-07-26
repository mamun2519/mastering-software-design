# Factory Design Pattern

Factory Design Pattern হলো একটি Creational Design Pattern, যার মাধ্যমে object তৈরির কাজটি encapsulate করে ফেলা হয় — মানে client (ব্যবহারকারী) কে না জানিয়ে backend এ কোন class এর object তৈরি হবে সেটা Factory class handle করে।

### 🧠 Concept:

ধরুন আপনি একাধিক ধরনের Product তৈরি করেন – যেমন Car, Bike, Truck। আপনি চাইলে new Car(), new Bike() করে প্রতিবার নিজে নিজে তৈরি করতে পারেন, কিন্তু এতে tightly coupled হয়ে যায় কোড।

Factory pattern ব্যবহার করলে, আপনি Factory কে শুধু বলে দেন — "আমার Bike লাগবে" — এবং Factory আপনাকে Bike দিয়ে দেয়। কীভাবে বানাবে সেটা আপনি জানেন না, জানতেও হবে না।

### 🎯 Singleton Design Pattern কী?

👉 Singleton হল এমন একটা Design Pattern, যা নিশ্চিত করে যে একটি class-এর শুধু একটি instance থাকবে এবং তা globally accessible হবে।

### 🧱 Singleton Pattern-এর মূল ধারণা

- private static instance => একই instance ধরে রাখে
- private constructor => বাইরে থেকে new করে বানাতে না পারে
- public static method => instance access করার জন্য method

### 📌 উদাহরণ – ধাপে ধাপে

ধরুন, আমাদের একটা Logger class আছে যেটা আমরা অনেক জায়গায় ব্যবহার করব।

```cs
class Logger
{
    // Step 1: একটি static instance রাখি
    private static Logger _instance;

    // Step 2: Constructor কে private করে দিই
    private Logger() { }

    // Step 3: একটি static method যেটা instance ফেরত দিবে
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger(); // শুধুমাত্র একবার বানাবে
        }
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
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
