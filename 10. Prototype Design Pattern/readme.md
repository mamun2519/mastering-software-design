# Prototype Design Pattern

### 🧠 What is Prototype Design Pattern?

Prototype Design Pattern হলো একটি Creational Pattern যা কোনো object কে copy বা clone করার জন্য ব্যবহার করা হয়, নতুন object তৈরি না করেই।

Key Idea:
একবার object তৈরি কর, তারপর যখন দরকার, সেই object-এর copy (clone) তৈরি করো।

### 🔍 কখন ব্যবহার করা হয়?

- যখন object তৈরি করা ব্যয়বহুল বা সময়সাপেক্ষ হয়।

- যখন কোনো object-এর অনেক configuration থাকে।

- যখন নতুন object তৈরির বদলে existing object কে duplicate করা বেশি উপযোগী।

### 🖼 Real-life Example:

ধরো একটি গেম বানাচ্ছো। তোমার কাছে অনেক চরিত্র (Character) আছে। প্রতিবার নতুন করে object বানানোর বদলে তুমি একবার বানানো চরিত্র copy করে ব্যবহার করছো।

### 🖥️ Real-Life Example:

একটি Computer build করার কথা ভাবো যেখানে CPU, RAM, HDD আলাদা আলাদা ভাবে যুক্ত করা যায়। কেউ কম RAM চায়, কেউ বেশি। কেউ SSD চায়, কেউ চায় না। এটার জন্য builder pattern perfect.

## C# Code Example

### Step 1: Prototype Interface তৈরি করা

```cs

// Con
```

### 🧠 Benefits:

- ✅ Complex object বানানো সহজ হয়
- ✅ Readable and Maintainable code
- ✅ Same process, different representation possible
