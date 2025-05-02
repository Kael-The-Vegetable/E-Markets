# Coding Standards

> When writing code for this project, try to follow the guidelines found below! These are to help you both make your code more legible as well as to make it more understandable to both others and future you!

---

## Table of Contents
1. [Generic Coding Practices](#generic-coding-practices)
	1. [Code Readability](#code-readability)
	1. [Code Structure](#code-structure)
1. [Code Structure](#code-structure)
	1. [Class Structure](#class-structure)
	1. [Naming Conventions](#naming-conventions)
1. [Unity Standards](#unity-standards)
	1. [MonoBehaviour Methods](#monobehaviour-methods)
	1. [Serialization Attributes](#serialization-attributes)

## Generic Coding Practices

### <h3 style="color:#cf9"> :open_book: **Code Readability**

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

### <h3 style="color:#aea"> :memo: **Comments**

> [!CAUTION]
> Bad comments are worse than no comments. In addition, comments should not explain what the code is doing. It should explain the end goal and why if needed.

Tool scripts should have `<summary>`'s so that each tool is best understood on **how** it should be used. Example below:

```csharp
/// <summary>
/// Used to move the player in a specific localized direction
/// </summary>
/// <param name="filePath">Path to file, excluding master directory.</param>
public void Move(Vector2 direction)
{
	throw new NotImplementedException();
}
```

## Code Structure

### <h3 style="color:#fd9"> :package: Class Structure

- One ***`class`*** per file. This can be different for maybe a general `Interfaces.cs` file but keep classes to one per file.
- **Standard Member Arrangements.** Keep classes to use the following format. Use `#region` as much as possible.
	- **Fields and Properties** (Organize based on purpose).
		- Always declare the access modifier you wish to use (`public`, `private`, `internal`, etc). Default should be `private` unless it requires broader access.
	- **Constructors** (if any).
	- **Unity Methods** (e.g.,`Start()`, `Update()`).
	- **Custom Methods** (organize further based on purpose, if two methods require one another then place them one after another).

### <h3 style="color:#9df"> :performing_arts: Naming Conventions

- **Classes & Interfaces**
	- Use **PascalCase** and add an additional `I` to the front of interfaces. (e.g., `ISaveable`).

- **Methods & Enums** 
	- Use **PascalCase.** (e.g., `OnMove()`, `EntityType`).

- **Variables**
	- **Properties:** use **PascalCase.**
	- **Fields:** use **camelCase.** (method variables fall under this aswell).
	- **Private Variables:** Add an `_` before the variable.

- **Constants**
	- Use **ALL_CAPS** with an `_` between words. Private constants also fall under the rule of an `_` before the name.

## Unity Standards

### <h3 style="color:#aaa"> :gear: MonoBehaviour Methods
- Use `Awake()` for initialization that doesn't depend on other objects (except managers).
- Use `OnEnable()` for initialization that should occur every time the object is set active. (e.g., Adding listeners to UnityEvents.)
- Use `OnDisable()` for removal that should occur every time the object is set to inactive. (e.g., Removing listeners to UnityEvents.)
- Use `Start()` for initialization that is dependant on other objects.
- Avoid using `Update()` and `FixedUpdate()` for logic that doesn't occur every frame.
- Use `Update()` for logic that needs to ocurr or be detected in every frame. Use `FixedUpdate()` for physics based code. Use `LateUpdate()` if it is dependant on another object's `Update()` method.
- Use `UnityEvents` or `events` majority of the time.

### <h3 style="color:#c8f"> :art: Serialization Attributes
- Use `[Serialized]` on private fields that need to be set in the Inspector.
- Use `[HideInInspector]` on fields that shouldn't be modified in the Inspector but should be saved.
- Use `[field: Thing Here]` to apply Attributes to automatically implemented properties.
- Use Attributes such as `[Range(#, #)]` to force the value to follow some logic you have attached to the value. (e.g., You put a Range of 0 to 1 on a variable used in Lerping).
- Use UI Toolkit for custom editors of the inspector.

