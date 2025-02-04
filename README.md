# DependencyInjection
Very basic and simple initial look into Dependency Injection in .Net applications

## What Is Dependency Injection?
Dependency Injection is a technique in which a class (the “consumer”) receives the objects (the “dependencies”) it needs from an external source rather than creating them itself. This external source is often referred to as an IoC (Inversion of Control) container, or DI container for short.

### Why “Inversion of Control”?
* Traditionally, a class might be responsible for creating its own dependencies using the new keyword (e.g., var service = new SomeService();).
* Inversion of Control means shifting the responsibility for creating objects away from the class and over to a container (or another part of the code).
* This lets you swap out or configure those objects more easily (for testing, different environments, etc.).

### Why Use Dependency Injection?

* **Loose Coupling** - Classes don’t need to know how dependencies are created; they only define what they need. This reduces tight dependencies and makes your code more flexible.
* **Testability** - With DI, you can easily inject mock or fake implementations in unit tests, simplifying testing.
* **Maintainability** - If a dependency changes, you can update it in one place (the IoC/DI setup), rather than searching through all the code.
* **Single Responsibility** - Classes no longer worry about creating dependencies and can focus on their primary job.

### Different Injection Methods

**Constructor Injection**
* The most common form; dependencies are injected via the constructor.

**Method Injection**
* Dependencies are passed as parameters to a method.
* Useful if you only need a dependency in one method rather than the entire lifespan of the object.

**Property Injection**
* Dependencies are assigned to public properties of a class.
* Less common, can be handy in certain scenarios, but can make it harder to see a class’s full set of dependencies.