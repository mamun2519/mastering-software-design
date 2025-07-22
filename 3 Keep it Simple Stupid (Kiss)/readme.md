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

### 🧠 মূল কথা মনে রাখো:

Wrong

- একই কাজ ২ বার লেখা
- Hardcoded value everywhere
- Copy-paste করে কাজ চালানো

right

- ✅ ফাংশনে রেখে বারবার call করো
- ✅ Constant বা Config use করো
- ✅ Reusable বানিয়ে DRY follow করো
