namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    Inheritance in C# allows a class (called the derived/child class) to acquire properties and methods from another class (called the base/parent class).

        - Promotes code reuse.

        - Enables hierarchy in OOP.

        - Supports polymorphism.

    👉 Inheritance uses the ':' symbol in C#.

    Types of Inheritance in C#
     
        1️. Single Inheritance: A child class inherits from one parent class.
        ✅ Supported in C#

        2. Multilevel Inheritance: A class is derived from another derived class.
        ✅ Supported in C#

        3. Hierarchical Inheritance: Multiple classes inherit from a single parent class.
        ✅ Supported in C#

        4. Multiple Inheritance: A class inherits from more than one base class.
        ❌ Not supported with classes in C# (to avoid diamond problem).
        ✅ But possible using interfaces.

        5. Hybrid Inheritance: A combination of multiple inheritance and multilevel inheritance.
        ❌ Not supported in C# with classes.
        ✅ Can be achieved using interfaces.

        | Type of Inheritance | Supported in C#?     | How?                       |
        | ------------------- | -------------------  | -------------------------  |
        | Single              | ✅ Yes               | Classes                    |
        | Multilevel          | ✅ Yes               | Classes                    |
        | Hierarchical        | ✅ Yes               | Classes                    |
        | Multiple            | ❌ No (with classes) | ✅ Achieved via Interfaces |
        | Hybrid              | ❌ No (with classes) | ✅ Achieved via Interfaces |

    */

    #endregion

    #region Why It Matters in Real World

    /*

        - UI Components: A Button class inherits from a Control class in .NET.

        - Domain Modeling: Employee can inherit from Person and add extra properties like EmployeeID.

        - Frameworks: ASP.NET controllers inherit from ControllerBase.

        This ensures reusability and avoids duplicate code.

    Key Points:

        - Single Inheritance only (C# doesn’t support multiple inheritance for classes; use interfaces for that).

        - base keyword → access base class methods/constructors.

        - virtual & override → enable polymorphism.

    */

    #endregion

    #region Praticle

    public class Inheritance
    {
        // simple example 
        public static void PraticeExampleOne()
        {
            StudentThree s = new StudentThree();
            s.Name = "Pradeep";
            s.StudentId = "S101";
            s.Greet();   // Inherited from Person
            s.Study();   // Defined in Student
        }

        // Base Keyword usage
        public static void PraticeExampleTwoForBaseKeyWord()
        {
            Dog d = new Dog();
            d.Speak();
        }

        // Single Inheritance
        public static void PraticeExampleForSingleInheritace()
        {
            DogOne d = new DogOne();
            d.Eat();
            d.Bark();
        }

        // Multilevel Inheritance
        public static void PraticeExampleForMultilevelInheritance()
        {
            DogTwo dogTwo = new DogTwo();
            dogTwo.Breathe(); // It is come from LivingBeing Class (perant of the parent class)
            dogTwo.Eat(); // It is come from AnimalTwo (parent class)
            dogTwo.Bark();  // (Chiled class)
        }

        // Hierarchical Inheritance
        public static void PraticeExampleForHierarchicalInheritance()
        {
            Circle circle = new Circle();
            circle.Draw(); // Come from the parent class (Shape)
            circle.Area();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw(); // Come from the parent class (Shape)
            rectangle.Area();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }

    class StudentThree : Person
    {
        public string StudentId { get; set; }
        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();  // Calls parent method
            Console.WriteLine("Dog barks");
        }
    }

    #region Single Inheritance
    class AnimalOne
    {
        public void Eat() => Console.WriteLine("Eating...");
    }

    class DogOne : AnimalOne
    {
        public void Bark() => Console.WriteLine("Barking...");
    }
    #endregion

    #region Multilevel Inheritance
    class LivingBeing
    {
        public void Breathe() => Console.WriteLine("Breathing...");
    }

    class AnimalTwo : LivingBeing
    {
        public void Eat() => Console.WriteLine("Eating...");
    }

    class DogTwo : AnimalTwo
    {
        public void Bark() => Console.WriteLine("Barking...");
    }
    #endregion

    #region Hierarchical Inheritance
    class Shape
    {
        public void Draw() => Console.WriteLine("Drawing shape...");
    }

    class Circle : Shape
    {
        public void Area() => Console.WriteLine("Area of circle");
    }

    class Rectangle : Shape
    {
        public void Area() => Console.WriteLine("Area of rectangle");
    }

    #endregion

    #endregion

    #region Interviwe Q&A

    /*

    Q1: What is inheritance in C#?
    A: Inheritance allows a class to reuse and extend functionality of another class using the : operator.

    Q2: Does C# support multiple inheritance?
    A: No, C# only supports single inheritance for classes but allows multiple inheritance via interfaces.

    Q3: What is the difference between base and this keyword?

    base → refers to the parent class.

    this → refers to the current instance.

    Q4: Why do we use virtual, override, and new in inheritance?

        virtual → makes a method overridable.

        override → overrides a base class virtual/abstract method.

        new → hides the base class method.

    Q5: Why doesn’t C# support multiple inheritance with classes?
    👉 To avoid ambiguity (Diamond Problem). Interfaces provide a safer alternative.

    Q6: How do you implement multiple inheritance in C#?
    👉 Using interfaces. A class can implement multiple interfaces.

    Q7: Which inheritance type is commonly used in real-world C# projects?
    👉 Mostly single and multilevel inheritance, often combined with interfaces for abstraction.

    */

    #endregion
}
