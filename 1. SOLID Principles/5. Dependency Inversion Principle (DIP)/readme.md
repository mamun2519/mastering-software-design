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
- শুধু দরকারি interface implement কর
