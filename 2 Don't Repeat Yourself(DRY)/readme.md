# 📘 Don't Repeat Yourself (DRY)

### 📌 📌 সংজ্ঞা (Definition):

“Every piece of knowledge must have a single, unambiguous, authoritative representation within a system.”

বাংলায়: একই কোড বা লজিক বারবার লিখবে না। বরং সেটাকে একবার লিখে বারবার ব্যবহার করো।.

### ❌ Bad Example (DRY Violation):

```cpp

class InvoiceService {
    public void GenerateInvoice() {
        Console.WriteLine("Generating invoice...");
        Console.WriteLine("Sending email to customer...");
    }

    public void SendReminder() {
        Console.WriteLine("Sending email to customer...");
    }
}



```

➡️ এখন যদি Bkash বাদ দিয়ে Nagad দিতে চাও, তাহলে PaymentService ক্লাসটা modify করতে হবে। এটি DIP ভঙ্গ করে।

### ✅ DIP ঠিক করার উপায়:

➡️ আমরা একটা interface (abstraction) তৈরি করব, এবং PaymentService ওই interface-এর উপর নির্ভর করবে, কোনো নির্দিষ্ট implementation-এর উপর নয়।ISP ঠিক রাখার উপায়:

### DIP-Compliant Version:

```cpp

interface IPaymentMethod {
    void Pay();
}

class BkashPayment : IPaymentMethod {
    public void Pay() => Console.WriteLine("Bkash Payment");
}

class NagadPayment : IPaymentMethod {
    public void Pay() => Console.WriteLine("Nagad Payment");
}

class PaymentService {
    private IPaymentMethod _payment;

    public PaymentService(IPaymentMethod payment) {
        _payment = payment;
    }

    public void MakePayment() {
        _payment.Pay();  // depends on abstraction
    }
}


```

### Main Program

```cs
class Program {
    public static void Main(string[] args) {
        PaymentService service = new PaymentService(new BkashPayment());
        service.MakePayment();

        service = new PaymentService(new NagadPayment());
        service.MakePayment();
    }
}

```

➡️ এখন তুমি যখনই নতুন payment system যোগ করবে, PaymentService class একদম না ছুঁয়ে কাজ হবে।
এই হলো DIP: Abstraction-এর উপর নির্ভর করো, details-এর উপর নয়।

### 🧠 মূল কথা মনে রাখো:

Wrong

- ❌ High-level class → Low-level class-এ নির্ভর করবে না

right

- ✅ তারা দুজনেই নির্ভর করবে Interface বা Abstract class-এর উপর
- ✅ Details (implementation) → Interface implement করবে
