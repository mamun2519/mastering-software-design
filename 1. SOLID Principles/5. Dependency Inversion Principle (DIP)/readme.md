# 📘Dependency Inversion Principle (DIP)

### 📌 📌 সংজ্ঞা (Definition):

High-level modules should not depend on low-level modules. Both should depend on abstractions.

Abstractions should not depend on details. Details should depend on abstractions.

### 🎯 সহজ ভাষায় বোঝি:

ধরো, তুমি একটা অ্যাপ বানাও যেখানে PaymentService ক্লাস আছে।
এই ক্লাস সরাসরি BkashPayment ক্লাসকে ডাকে। তাহলে PaymentService ক্লাসটা BkashPayment-এর উপর নির্ভরশীল হয়ে পড়ে — এটা DIP break করে।

```cpp

class BkashPayment {
    public void Pay() => Console.WriteLine("Paying with Bkash");
}

class PaymentService {
    private BkashPayment _bkash = new BkashPayment();

    public void MakePayment() {
        _bkash.Pay();  // tightly coupled
    }
}



```

➡️ এখন যদি Bkash বাদ দিয়ে Nagad দিতে চাও, তাহলে PaymentService ক্লাসটা modify করতে হবে। এটি DIP ভঙ্গ করে।

### ✅ DIP ঠিক করার উপায়:

➡️ আমরা একটা interface (abstraction) তৈরি করব, এবং PaymentService ওই interface-এর উপর নির্ভর করবে, কোনো নির্দিষ্ট implementation-এর উপর নয়।ISP ঠিক রাখার উপায়:

```cpp

interface IWorkable {
    void Work();
}

interface IFeedable {
    void Eat();
}

class HumanWorker : IWorkable, IFeedable {
    public void Work() => Console.WriteLine("Human is working");
    public void Eat() => Console.WriteLine("Human is eating");
}

class RobotWorker : IWorkable {
    public void Work() => Console.WriteLine("Robot is working");
}

```

➡️ এখন যার যেটা দরকার, সে শুধু সেটাই implement করছে — ফোর্স করছে না কিছু!
এইটাই হলো Interface Segregation Principle ✅

➡️ এখন WhatsApp বা Facebook Message Add করতে চাইলে শুধু নতুন class implement করলেই হবে — পুরনো NotificationService একদম touch করা লাগবে না!

### 🧠 মূল কথা মনে রাখো:

Wrong

- বড় ইন্টারফেসে সব ফাংশন জোর করে বসানো
- যেটা ক্লাস ব্যবহার করে না, সেটাও ইমপ্লিমেন্ট

right

- ছোট ছোট, ভাগ করা ইন্টারফেস বানাও
- শুধু দরকারি interface implement কর
