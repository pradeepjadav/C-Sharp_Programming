namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    Abstraction means hiding the complex implementation details and showing only the essential features of an object.

    It allows developers to focus on what an object does rather than how it does it.

    In C#, abstraction can be achieved in two main ways:

        1. Using Abstract Classes 

        2. Using Interfaces


    1. Abstract Class

        - Declared using the abstract keyword.

        - Cannot be instantiated directly.

        - Can contain abstract (no implementation) and non-abstract (implemented) methods.

        - Derived (child) classes must override all abstract methods.

    2. Interface

        Declared using the interface keyword.

        Defines a contract or blueprint for classes.

        All methods are abstract by default (no implementation).

        A class can implement multiple interfaces (supporting multiple inheritance).

    🔄 Abstract Class vs Interface:

        | Feature          | Abstract Class                          | Interface                           |
        | ---------------- | --------------------------------------- | ----------------------------------- |
        | Implementation   | Can have implemented + abstract methods | Only abstract methods (till C# 7.2) |
        | Fields           | Can have fields                         | Cannot have fields                  |
        | Constructors     | Can have constructors                   | Cannot have constructors            |
        | Access Modifiers | Can use any access modifier             | All are public                      |
        | Inheritance      | Single                                  | Multiple                            |
        | Use When         | Classes share behavior                  | Classes share capabilities          |

    */

    #endregion

    #region Why It Matters in Real World

    /*

    Abstraction helps in building scalable, maintainable, and flexible systems.

    Real-world use cases:

        - Payment Systems: 
            Abstract class defines ProcessPayment(), and each provider (Stripe, Razorpay, PayPal) implements it differently.

        - Data Access Layer: 
            Interface IRepository<T> defines CRUD operations; each entity implements them.

        - Hardware Drivers / Plugins: 
            Abstract class defines general methods; concrete classes handle specific devices.

    👉 Abstraction allows developers to swap implementations easily without changing the entire system — a key principle in Clean
        Architecture and Dependency Inversion.

    */

    #endregion

    #region Praticle

    public class Abstraction
    {
        // Abstract Class
        public static void PraticeExampleForAbstractionClass()
        {
            DogSix dog = new DogSix();
            dog.Sound(); // It is override
            dog.Eat(); // From base class
        }

        // Interface
        public static void PraticeExampleForInterface()
        {
            DogSeven dog = new DogSeven();  // Child class to access both Interface signature.
            dog.Sound(); // It is come from IAnimalOne
            dog.Walk(); // It is come from Iwalkable
        }

        // Both in one class for archive multiple inheritance
        public static void PraticeExampleBothabtractionForMultipleInheritance()
        {
            Paypal paypal = new Paypal();
            paypal.Processpayment(8000); // It is coming from PaymentGateway (abstract)
            paypal.ShowTransactionId(); // It is coming from PaymentGateway
            paypal.Refund(4000); // It is coming from IRefundable
        }
    }

    #region Abstract Class
    abstract class AnimalSix
    {
        public abstract void Sound();  // Abstract method
        public void Eat()              // Concrete method
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class DogSix : AnimalSix
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    #endregion

    #region Interface
    interface IAnimalOne
    {
        void Sound();
    }

    interface IWalkable
    {
        void Walk();
    }

    class DogSeven : IAnimalOne, IWalkable
    {
        public void Sound()
        {
            Console.WriteLine("Dog barks");
        }

        public void Walk()
        {
            Console.WriteLine("Dog walks on four legs");
        }
    }

    #endregion

    #region Both Abtraction at time
    abstract class paymentGateway
    {
        public abstract void Processpayment(double amount); // abstract method
        public void ShowTransactionId()
        {
            Console.WriteLine($"Transaction ID: {Guid.NewGuid}");
        }
    }

    interface IRefundable
    {
        void Refund(double amount);
    }

    class Paypal : paymentGateway, IRefundable
    {
        public override void Processpayment(double amount)
        {
            Console.WriteLine($"paypal: {amount}");
        }

        public void Refund(double amount)
        {
            Console.WriteLine($"Refunding {amount} via paypal");
        }
    }
    #endregion

    #endregion

    #region Interviwe Q&A

    /*

    Q1. What is Abstraction in C#?
    🗣️ Abstraction is the process of hiding the internal implementation and showing only the functionality. 
        It’s achieved through abstract classes and interfaces.

    Q2. Difference between Abstraction and Encapsulation?

        | Concept       | Focus                                 | Example                                         |
        | ------------- | ------------------------------------- | ----------------------------------------------- |
        | Abstraction   | Hides **implementation details**      | `abstract void Sound()`                         |
        | Encapsulation | Hides **data** using access modifiers | `private int age; public int Age { get; set; }` |

    Q3. Can abstract classes have constructors?
    ✅ Yes. They can be used to initialize shared data for derived classes.

    Q4. Can an abstract class implement an interface?
    ✅ Yes, and it can even provide partial implementation.

    Q5. Abstract Class vs Interface:

        | Feature          | Abstract Class                  | Interface                 |
        | ---------------- | ------------------------------- | ------------------------- |
        | Inheritance      | Single                          | Multiple                  |
        | Members          | Fields + Methods                | Methods + Properties only |
        | Access Modifiers | Can have any                    | All are public            |
        | Implementation   | Partial allowed                 | None (before C# 8)        |
        | When to Use      | Common functionality + contract | Only contract definition  |

    Q6. Can interfaces have default implementation?
    ✅ Yes, from C# 8.0 onwards using the default keyword.

    Q7. When should you use an interface instead of an abstract class?
    
        Use an interface when:

            You just need to define a contract.

            Multiple inheritance is needed.

        Use an abstract class when:

            You want to share common functionality among derived classes.

    */

    #endregion
}
