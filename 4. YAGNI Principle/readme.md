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

### 📚 কবে তুমি KISS ভঙ্গ করতেছো?

- অনেক nested if-else

- একই কাজের জন্য অনেকগুলো step

- না বুঝে loop বা condition গুলিয়ে ফেলা

- ছোট কাজে function না বানিয়ে সব একসাথে লিখে ফেলা

### 🎯 কিভাবে KISS ফলো করবে?

- ✅ ছোট ছোট ফাংশনে ভাগ করো
- ✅ জটিল কন্ডিশন ব্রেক করো
- ✅ Meaningful নাম দাও variables এবং methods এ
- ✅ সহজ করে explain করার মতো কোড লেখো
