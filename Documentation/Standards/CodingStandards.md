# Coding Standards

> When writing code for this project, try to follow the guidelines found below! These are to help you both make your code more legible as well as to make it more understandable to both others and future you!

---

## Table of Contents
1. [Generic Coding Practices](#generic-coding-practices)

### Generic Coding Practices

#### <h4 style="color:#cf9"> :open_book: **Code Readability**

> [!IMPORTANT]
> Variables should always be informative of the purpose it provides.

This is important as if you need to gain reference to a component it is best to ensure the others working on this project can see what reference is needed.
```csharp
public Rigidbody x;
public Collider v;
public Weapon j;
```
These variables are not descriptive at all to the purpose they serve nor express what it is that the reference is to. This is a much better example below.
```csharp
public Rigidbody playerRB;
public Collider playerMainCollider;
public Weapon activeWeapon;
```

#### <h4 style="color:#aea"> :memo: **Comments**

> [!CAUTION]
> Bad comments are worse than no comments. In addition, comments should not explain what the code is doing. It should explain the end goal and why if needed.

