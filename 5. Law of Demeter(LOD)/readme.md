# 🧠 Law of Demeter (LoD) — “Don’t talk to strangers”

### 🔍 কী এই Law of Demeter?

Law of Demeter একটি low coupling principle।
এটি বলে:

"একটি অবজেক্টকে শুধুমাত্র তার নিজের property/method, তার তৈরি অবজেক্ট, অথবা method-এর প্যারামিটার অবজেক্ট-এর সাথেই যোগাযোগ করতে দেওয়া উচিত। অন্যদের (strangers) সঙ্গে নয়।"

### 🧠 সহজ ভাষায় ব্যাখ্যা:

"তুমি শুধু তোমার বন্ধুর সাথে কথা বলো, বন্ধুর বন্ধুর সাথে না।"

👉 যদি একটার ভিতর আরেকটা ভিতর আরেকটা ভিতর অবজেক্ট কল করো:

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

✳️ এখন যেটুকু দরকার, কেবল সেটুকুই আছে। ভবিষ্যতে দরকার হলে পরে যোগ করবে।

### 💡 বাস্তব জীবনে YAGNI কখন লাগে?

- Freelancing বা Software Company তে, client যদি A আর B চায়, তখন নিজের ইচ্ছায় C, D, E ফিচার বানানো waste.

- কম্প্লেক্স সিস্টেম আগেভাগে বানাতে গেলে maintenance & bug বেড়ে যায়।
