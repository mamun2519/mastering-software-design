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

```cs
car.getEngine().getFuelInjector().inject()


```

এটা bad practice। কারণ car অনেক 'stranger'-এর সাথে কথা বলছে। এতে কোড become tightly coupled and hard to maintain.

### ❌ Bad Example:

```cpp
class Engine {
    public FuelInjector GetFuelInjector() => new FuelInjector();
}

class Car {
    public Engine GetEngine() => new Engine();
}

class Driver {
    public void Drive(Car car) {
        car.GetEngine().GetFuelInjector().Inject();  // ❌ Violates LoD
    }
}



```

এখানে Driver → Car → Engine → FuelInjector → Inject()
এই গভীর চেইন যোগাযোগ ভালো না। এটা LoD ভঙ্গ করে।

### ✅ Good Example (LoD Respected):

```cpp
class FuelInjector {
    public void Inject() => Console.WriteLine("Fuel Injected");
}

class Engine {
    private FuelInjector _injector = new FuelInjector();

    public void Start() => _injector.Inject();
}

class Car {
    private Engine _engine = new Engine();

    public void Start() => _engine.Start();
}

class Driver {
    public void Drive(Car car) {
        car.Start(); // ✅ Only talks to Car
    }
}



```

এখানে Driver শুধু Car এর সাথে কথা বলছে, Car ইঞ্জিন চালাচ্ছে, ইঞ্জিন ইনজেক্টর চালাচ্ছে।

✔️ Coupling কমেছে, Maintainability বেড়েছে।

### 🔧 Tips to Follow LoD:

- ✅ Avoid obj.getA().getB().doSomething()
- ✅ Keep methods focused
- ✅ Use delegation
- ✅ Hide internal structure (Encapsulation)
