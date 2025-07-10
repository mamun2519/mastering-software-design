# Open/Closed Principle (OCP)

🎯 আজকের লক্ষ্য:

- OCP কী এবং কেন দরকার
- Real-life example
- ❌ Bad code vs ✅ Good OCP code
- Strategy Pattern এর সংযোগ

### 🧠 OCP কী?

“Software entities (classes, modules, functions) should be open for extension, but closed for modification.”

বাংলায়:

- Extension এর জন্য Open = তুমি নতুন feature Add করতে পারবে
- Modification এর জন্য Closed = পুরনো কোড না পরিবর্তন করে
- 📛 মানে: নতুন feature যোগ করতে হবে — কিন্তু আগের কোডে হাত না দিতে পারলে সবচেয়ে ভালো!

### 📍 2. কেন OCP দরকার?

🧱 Without OCP:

- পুরনো ক্লাসে নতুন feature যোগ করতে গিয়ে পুরোটাই modify করতে হয়

- Bug আসার সম্ভাবনা বাড়ে

- Maintainability কমে

✅ With OCP:

- নতুন ফিচার Add করা যায় নতুন ক্লাস দিয়ে

- পুরনো tested code untouch থাকে

- Scalability ও Testability বাড়ে

### ❌ Bad Example (OCP Violation)

```cs
class NotificationService {
    public void Send(string type, string message){
        if(type == "email")
            Console.WriteLine("Email: " + message);
        else if(type == "sms")
            Console.WriteLine("SMS: " + message);
        else if(type == "push")
            Console.WriteLine("Push: " + message);
    }
}

```

➡️ যদি নতুন type (e.g., WhatsApp) Add করতে চাও, তাহলে এই method modify করতে হবে
📛 এইভাবে class বারবার বদলাতে হয় = OCP Break

### Good Example (OCP Followed)

```cs
 interface INotifier {
    void Send(string message);
}

class EmailNotifier : INotifier {
    public void Send(string message){
        Console.WriteLine("Email: " + message);
    }
}

class SMSNotifier : INotifier {
    public void Send(string message){
        Console.WriteLine("SMS: " + message);
    }
}

class PushNotifier : INotifier {
    public void Send(string message){
        Console.WriteLine("Push: " + message);
    }
}

class NotificationService {
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier){
        _notifier = notifier;
    }

    public void Notify(string message){
        _notifier.Send(message);
    }
}
```

### Use it

```cs
var notifier = new NotificationService(new EmailNotifier());
notifier.Notify("Hello, OCP!");
```

### 🎯 Strategy Pattern & OCP

OCP মানতে গিয়ে আমরা প্রায়ই Strategy Pattern ব্যবহার করি —
একটি interface অনুযায়ী বিভিন্ন behavior ক্লাসে আলাদা করে define করে রাখি।
