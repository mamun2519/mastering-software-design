# 🧠YAGNI Principle কী

### YAGNI এর পূর্ণ রূপ:

You Aren’t Gonna Need It

এটি একটি গুরুত্বপূর্ণ Agile/XP (Extreme Programming) প্রিন্সিপল।

### ✅ YAGNI বলছে:

"Don't implement something until it is necessary."

অর্থাৎ: আপনি যদি কোনো ফিচার বা ফাংশন এখন প্রয়োজন না হয়, তবে সেটি এখনই বানানোর দরকার নেই। ভবিষ্যতের কথা ভেবে অপ্রয়োজনীয় কোড লেখা উচিত না।

### 🎯 লক্ষ্য:

- Overengineering কমানো

- Time save করা

- কোড clean ও maintainable রাখা

### উদাহরণ (Bad Code - Violating YAGNI):

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
