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

### ❌ Complex Code (Not KISS):

```cpp
public int Add(int a, int b){
    if (a > 0 && b > 0){
        return (a + b);
    } else if (a < 0 || b < 0){
        return (a + b);
    } else {
        return (a + b);
    }
}


```

### ✅ KISS Code:

```cpp
public int Add(int a, int b){
    return a + b;
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
