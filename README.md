# Design Patterns
Collection of 23 Gang of Four design patterns implementations in C#. Done mainly for learning purposes but feel free to use them however you want.

## Behavioral patterns
Define the ways of communication between objects.
 - [Chain of Responsibility](./DesignPatterns/Behavioral/ChainOfResp/) - handles data by passing it between objects in the chain
 - [Command](./DesignPatterns/Behavioral/Command/) - encapsulates command/request into separate class
 - [Interpreter](./DesignPatterns/Behavioral/Interpreter/) - executes expressions
 - [Iterator](./DesignPatterns/Behavioral/Iterator/) - sequental access to the elements in the collection
 - [Mediator](./DesignPatterns/Behavioral/Mediator/) - communication between objects using separate class
 - [Memento](./DesignPatterns/Behavioral/Memento/) - saves and restores object state
 - [Observer](./DesignPatterns/Behavioral/Observer/) - notifies objects about some event
 - [State](./DesignPatterns/Behavioral/State/) - alters class behaviour
 - [Strategy](./DesignPatterns/Behavioral/Strategy/) - encapsulates algorithms to the separate classes
 - [Template Method](./DesignPatterns/Behavioral/TemplateMethod/) - overrides (by creating subclasses) steps of the algorithm
 - [Visitor](./DesignPatterns/Behavioral/Visitor/) - adds new operation to the class without its change

## Creational patterns
Define the ways of creating objects using hidden logic instead of directly `new` keyword use.
 - [Abstract Factory](./DesignPatterns/Creational/AbstractFactory/) - creates instances of the specified class family
 - [Builder](./DesignPatterns/Creational/Builder/) - constructs instances with a few steps
 - [Factory Method](./DesignPatterns/Creational/FactoryMethod/) - creates instances of the derived classes
 - [Prototype](./DesignPatterns/Creational/Prototype/) - creates instance by copying or cloning other object
 - [Singleton](./DesignPatterns/Creational/Singleton/) - ensures that there is only one instance of the class

## Structural patterns
Define the ways of composing objects and classes to add or change functionality.
 - [Adapter](./DesignPatterns/Structural/Adapter/) - matches interfaces of different classes
 - [Bridge](./DesignPatterns/Structural/Bridge/) - separates interface from its implementation
 - [Composite](./DesignPatterns/Structural/Composite/) - composes object using tree structure
 - [Decorator](./DesignPatterns/Structural/Decorator/) - adds new responsibilities to the existing class
 - [Facade](./DesignPatterns/Structural/Facade/) - class representing a few subsystems
 - [Flyweight](./DesignPatterns/Structural/Flyweight/) - small and reusable objects
 - [Proxy](./DesignPatterns/Structural/Proxy/) - controlls the access to the object