# 🧠 KISS Principle মানে কী?

### Keep It Simple, Stupid

- 👉 সহজ করে লেখো
- 👉 জটিল করে না লিখে বুঝতে সহজ হয় এমন কোড লেখো
- 👉 কোড অন্য কেউ পড়লে যেন মাথা ঘুরে না যায় 😅

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
