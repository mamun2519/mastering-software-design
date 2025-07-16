# 📘 Interface Segregation Principle (ISP)

### 📌 সংজ্ঞা (Definition):

“Clients should not be forced to depend on interfaces they do not use.”

বাংলায়: একটা ক্লাস বা অবজেক্টকে এমন কোনো ইন্টারফেস ইমপ্লিমেন্ট করতে বাধ্য করা উচিত না — যেটার কিছু ফাংশন সে ব্যবহারই করে না।

### 🎯 সহজ ভাষায় বুঝি:

একটা ইন্টারফেসে অনেকগুলো ফাংশন থাকলে, কেউ ইচ্ছা না থাকলেও সব ফাংশন ইমপ্লিমেন্ট করতে বাধ্য হয়।
এতে কোড হয়ে যায় “জোড়াতালি” দেয়া।

```cpp

interface IWorker {
    void Work();
    void Eat();
}

class HumanWorker : IWorker {
    public void Work() => Console.WriteLine("Human is working");
    public void Eat() => Console.WriteLine("Human is eating");
}

class RobotWorker : IWorker {
    public void Work() => Console.WriteLine("Robot is working");
    public void Eat() => throw new NotImplementedException();  // ❌ Robot তো খায় না!
}


```

➡️ এখানে Robot-কে Eat() method ইমপ্লিমেন্ট করতে বাধ্য করা হয়েছে — অথচ সে তো খায়ই না!
এটাই ISP violation।

### ISP ঠিক রাখার উপায়:

✅ ভালো ডিজাইন:

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
