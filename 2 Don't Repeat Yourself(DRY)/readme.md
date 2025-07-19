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

➡️ এখানে SendReminder() আর GenerateInvoice() — দুটোতেই email পাঠানো একইভাবে আছে।

এটা হচ্ছে code duplication — DRY break করে।

### ✅ Good Example (DRY Applied):

```cpp

class InvoiceService {
    private void SendEmail() {
        Console.WriteLine("Sending email to customer...");
    }

    public void GenerateInvoice() {
        Console.WriteLine("Generating invoice...");
        SendEmail();
    }

    public void SendReminder() {
        SendEmail();
    }
}


```

➡️ এখন SendEmail() method একবার লিখেই দু’জায়গায় ব্যবহার করা হলো — এটা DRY principle।

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
