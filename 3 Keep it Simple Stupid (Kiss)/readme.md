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

Wrong

- একই কাজ ২ বার লেখা
- Hardcoded value everywhere
- Copy-paste করে কাজ চালানো

right

- ✅ ফাংশনে রেখে বারবার call করো
- ✅ Constant বা Config use করো
- ✅ Reusable বানিয়ে DRY follow করো
