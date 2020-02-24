# Design Patterns
Collection of 23 Gang of Four design patterns implementations in C#. Done mainly for learning purposes but feel free to use them however you want.

## Behavioral patterns
Define the ways of communication between objects.
 - [Chain of Responsibility](./DesignPatterns/Behavioral/ChainOfResp/) - handles data by passing between objects in the chain
 - [Command](./DesignPatterns/Behavioral/Command/) - encapsulates command/request into separate class
 - [Interpreter](./DesignPatterns/Behavioral/Interpreter/) - executes expressions
 - [Iterator](./DesignPatterns/Behavioral/Iterator/) - sequentall access to the elements in the collection
 - [Mediator](./DesignPatterns/Behavioral/Mediator/) - communication between objects using separate class
 - [Memento](./DesignPatterns/Behavioral/Memento/) - saves and restores object state
 - [Observer](./DesignPatterns/Behavioral/Observer/) - notifies objects about some event
 - [State](./DesignPatterns/Behavioral/State/) - alters class behaviour
 - [Strategy](./DesignPatterns/Behavioral/Strategy/) - encapsulates algorithms to the separate classes
 - [Template Method](./DesignPatterns/Behavioral/TemplateMethod/) - overrides (by creating subclasses) steps of the algorithm
 - [Visitor](./DesignPatterns/Behavioral/Visitor/) - adds new operation to the class without its change

## Creational patterns
Define the ways of creating objects using hidden logic instead of directly `new` keyword use.
 - [Abstract Factory](./DesignPatterns/Behavioral/AbstractFactory/) - creates instances of the specified class family
 - [Builder](./DesignPatterns/Behavioral/Builder/) - constructs instances with a few steps
 - [Factory Method](./DesignPatterns/Behavioral/FactoryMethod/) - creates instances of the derived classes
 - [Prototype](./DesignPatterns/Behavioral/Prototype/) - creates instance by copying or cloning other object
 - [Singleton](./DesignPatterns/Behavioral/Singleton/) - ensures that there is only one instance of the class

## Structural patterns
Define the ways of composing objects and classes to add or change functionality.
 - [Adapter](./DesignPatterns/Behavioral/Adapter/) - matches interfaces of different classes
 - [Bridge](./DesignPatterns/Behavioral/Bridge/) - separates interface from its implementation
 - [Composite](./DesignPatterns/Behavioral/Composite/) - composes object with tree structure
 - [Decorator](./DesignPatterns/Behavioral/Decorator/) - adds new responsibilities to the existing class
 - [Facade](./DesignPatterns/Behavioral/Facade/) - represents a few subsystems
 - [Flyweight](./DesignPatterns/Behavioral/Flyweight/) - small and reusable objects
 - [Proxy](./DesignPatterns/Behavioral/Proxy/) - controlls the access to the object