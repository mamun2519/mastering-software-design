# 🔑 Singleton Design Pattern

### 🧠 সমস্যাটি কী?

ধরুন, আপনার একটি অ্যাপ্লিকেশন আছে যেখানে শুধু একবার একটি object তৈরি হওয়া উচিত, এবং সেই object টি সব জায়গা থেকে ব্যবহারযোগ্য হওয়া দরকার। যেমন:

- Logger: অ্যাপের যেকোনো অংশে লোগ লিখতে হবে, কিন্তু Logger-এর instance যদি অনেক তৈরি হয়, তাহলে log ফাইল এলোমেলো হয়ে যেতে পারে।

- Database Connection: প্রতিবার নতুন করে connection তৈরি করলে performance খারাপ হবে এবং অনেক resource খরচ হবে।

🤔 সমাধান: আমরা এমনভাবে একটি class তৈরি করব, যেটার শুধু একটা instance তৈরি হবে — এবং বারবার সেটা ব্যবহার হবে।

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

### 🔧 Tips to Follow LoD:

- ✅ Avoid obj.getA().getB().doSomething()
- ✅ Keep methods focused
- ✅ Use delegation
- ✅ Hide internal structure (Encapsulation)
