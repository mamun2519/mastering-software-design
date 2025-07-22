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
class ReportService {
    public void GenerateReport(string type) {
        if (type == "pdf") {
            Console.WriteLine("Generating PDF Report...");
        } else if (type == "excel") {
            Console.WriteLine("Generating Excel Report...");
        } else if (type == "html") {
            Console.WriteLine("Generating HTML Report...");
        } else if (type == "csv") {
            Console.WriteLine("Generating CSV Report...");
        } else if (type == "json") {
            Console.WriteLine("Generating JSON Report...");
        }
    }
}


```

🟥 এখানে এখনো requirement শুধু "pdf" আর "excel" এর জন্য। কিন্তু HTML, CSV, JSON future এ লাগতে পারে ভেবে এখনই বানিয়ে ফেলেছে — এটা YAGNI violation।

### ✅ Good Code (Follow YAGNI):

```cpp
class ReportService {
    public void GenerateReport(string type) {
        if (type == "pdf") {
            Console.WriteLine("Generating PDF Report...");
        } else if (type == "excel") {
            Console.WriteLine("Generating Excel Report...");
        }
    }
}


```

✳️ এখন যেটুকু দরকার, কেবল সেটুকুই আছে। ভবিষ্যতে দরকার হলে পরে যোগ করবে।

### 💡 বাস্তব জীবনে YAGNI কখন লাগে?

- Freelancing বা Software Company তে, client যদি A আর B চায়, তখন নিজের ইচ্ছায় C, D, E ফিচার বানানো waste.

- কম্প্লেক্স সিস্টেম আগেভাগে বানাতে গেলে maintenance & bug বেড়ে যায়।
