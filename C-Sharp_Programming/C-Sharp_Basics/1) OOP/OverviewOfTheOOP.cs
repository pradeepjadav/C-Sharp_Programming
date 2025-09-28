namespace C_Sharp_Basics._0__C__refresh
{
    #region Theorys

    /*
    
        Object-Oriented Programming (OOP) in C#

            Encapsulation → hide data using properties
            Inheritance → class Car : Vehicle
            Polymorphism → Overloading (compile-time), Overriding (runtime with virtual/override)
            Abstraction → abstract class, interface    
     
    */

    #endregion

    #region Praticle

    public class OverviewOfTheOOP
    {
        // Encapsulation
        private string name; // Private field
        public string Name // Public property
        {
            get { return name; }
            set { name = value; }
        }

        // Inheritance
        public class Vehicle
        {
            public void Start() { Console.WriteLine("Vehicle started"); }
        }
        public class Car : Vehicle // Car inherits from Vehicle
        {
            public void Drive() { Console.WriteLine("Car is driving"); }
        }
       
        // Polymorphism [have to type of the 1. run-time (Overloading) and 2. compile-time (Overriding)]
        public class Animal
        {
            public virtual void Speak() { Console.WriteLine("Animal speaks"); } // Virtual method
        }
        public class Dog : Animal
        {
            public override void Speak() { Console.WriteLine("Dog barks"); } // Overriding method
        }
        public class Cat : Animal
        {
            public override void Speak() { Console.WriteLine("Cat meows"); } // Overriding method
        }
        
        // Abstraction: two ways [ 1. abstract class and 2. interface ]
        public abstract class Shape
        {
            public abstract double Area(); // Abstract method
        }
        
        public class Circle : Shape
        {
            private double radius;
            public Circle(double radius) { this.radius = radius; }
            public override double Area() { return Math.PI * radius * radius; } // Implementing abstract method
        }

        // Method to demonstrate OOP concepts
        public void DemonstrateOOP() 
        {
            // Encapsulation
            Name = "MyCar";
            Console.WriteLine($"Car Name: {Name}");
            
            // Inheritance
            Car myCar = new Car();
            myCar.Start();
            myCar.Drive();
            
            // Polymorphism
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            myDog.Speak();
            myCat.Speak();
            
            // Abstraction
            Shape myCircle = new Circle(5);
            Console.WriteLine($"Circle Area: {myCircle.Area()}");
        } 
    }

    #endregion

    #region Interviwe Q&A

    /*
     
        1. What are the four main principles of Object-Oriented Programming (OOP)?
           - The four main principles of OOP are Encapsulation, Inheritance, Polymorphism, and Abstraction.
        2. Can you explain encapsulation and how it is implemented in C#?
           - Encapsulation is the principle of hiding the internal state and behavior of an object and exposing only what is necessary. In C#, it is implemented using access modifiers (private, public, protected) and properties to control access to fields.
        3. What is inheritance and how does it work in C#?
           - Inheritance is a mechanism where a new class (derived class) can inherit properties and methods from an existing class (base class). In C#, it is implemented using the ':' symbol. For example, 'class Car : Vehicle' means Car inherits from Vehicle.
        4. Can you explain polymorphism and provide an example in C#?
            - Polymorphism allows methods to do different things based on the object that it is acting upon. In C#, it can be achieved through method overloading (compile-time polymorphism) and method overriding (run-time polymorphism using virtual and override keywords). For example, a base class Animal can have a Speak method that is overridden in derived classes like Dog and Cat.
        5. What is abstraction and how is it implemented in C#?
            - Abstraction is the concept of hiding complex implementation details and showing only the essential features of an object. In C#, it can be implemented using abstract classes and interfaces. An abstract class can have abstract methods that must be implemented by derived classes, while an interface defines a contract that implementing classes must follow.
        6. Difference between abstract class and interface?
            - abstract class can have implementation, interface only contracts (before C# 8).
    */

    #endregion
}
