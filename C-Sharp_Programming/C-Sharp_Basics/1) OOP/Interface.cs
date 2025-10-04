namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    An interface in C# defines a contract or blueprint that classes or structs must follow.
    It only declares members (methods, properties, events, or indexers) — no implementation is provided (until C# 8.0).

    Think of an interface as a promise:

        “If you implement me, you must implement all my members.”

    👉 Interfaces help write loosely coupled and testable code, a cornerstone of SOLID principles.

    In Interface Allowed in C#:

        | Member Type     | Allowed in Interface?   | Description                                            |
        | --------------- | ---------------------   | ------------------------------------------------------ |
        | **Method**      | ✅                     | Declared without body (implementation done in class).  |
        | **Property**    | ✅                     | Only declaration, no backing field.                    |
        | **Event**       | ✅                     | Can be declared and implemented using `event` keyword. |
        | **Indexer**     | ✅                     | Used to access elements via index like arrays.         |
        | **Field**       | ❌                     | Not allowed.                                           |
        | **Constructor** | ❌                     | Not allowed.                                           |

    Interfaces are the backbone of clean architecture.
    They allow developers to define behavior, not implementation — ensuring flexibility, maintainability, and scalability.

    In real-world systems, almost every major design pattern (Repository, Strategy, Dependency Injection, etc.) 
    uses interfaces at its core.

    Key Characteristics: 

        - Declared using the interface keyword.

        - Members are public and abstract by default.

        - A class can implement multiple interfaces (unlike classes which support single inheritance).

        - Interfaces cannot have fields, constructors, or access modifiers (except public).

        - From C# 8.0 onward, interfaces can include default method implementations.

    Real-World Scenarios — Interface in Enterprise Systems:

        | Scenario                 | Interface                       | Purpose                                                   |
        | ------------------------ | ------------------------------- | --------------------------------------------------------- |
        | **Repository Pattern**   | `IRepository<T>`                | Defines CRUD operations in Data Access Layer              |
        | **Dependency Injection** | `IService`, `ILogger`           | Inject implementations at runtime                         |
        | **Payment Gateway**      | `IPaymentGateway`               | Common contract for PayPal, Razorpay, Stripe              |
        | **Logging Frameworks**   | `ILogger`                       | Allow different logging mechanisms (File, Console, Cloud) |
        | **Messaging System**     | `IMessageSender`                | Unified interface for Email, SMS, Push Notifications      |
        | **Testing & Mocking**    | `IUserService`, `IOrderService` | Enables easy mocking in unit tests                        |

    */

    #endregion

    #region Praticle

    public class Interface
    {
        // Example 1 — Basic Interface Implementation
        public static void PraticeExampleOne()
        {
            IShape circle = new CircleTwo(5);
            Console.WriteLine($"Area: {circle.Area()}");
            Console.WriteLine($"Perimeter: {circle.Perimeter()}");
        }

        // Example 2 — Multiple Interface Implementation
        public static void PraticeExampleTwo()
        {
            Document doc = new Document();
            doc.Print();
            doc.Save("Report");
        }

        // Example 3 — Interface Inheritance (Extending Another Interface)
        public static void PraticeExampleThree()
        {
            FileHandler file = new FileHandler();
            file.Read();
            file.Write("Interface Chaining Example");
        }

        // Example 4 — Explicit Interface Implementation
        public static void PraticeExampleFour()
        {
            Notification notification = new Notification();

            // Cannot call Send() directly because it’s explicit
            ((IEmail)notification).Send();
            ((ISMS)notification).Send();
        }

        // Example 5 — Interface with Default Implementation (C# 8+)
        public static void PraticeExampleFive()
        {
            ILogger logger = new ConsoleLogger();
            logger.Log("Application started");
            logger.LogError("Something went wrong!");
        }

        // Example 6 — Complete Interface Implementation
        public static void PraticeExampleSix()
        {
            Developer dev = new Developer { Name = "Pradeep" };

            // Subscribe to event
            dev.WorkCompleted += (sender, e) => Console.WriteLine("Work completed successfully!");

            // Using property
            Console.WriteLine($"Employee: {dev.Name}");

            // Using method
            dev.Work();

            // Using indexer
            dev[0] = "Fix bugs";
            Console.WriteLine($"Task 1: {dev[0]}");
        }
    }

    #region Example One
    interface IShape
    {
        double Area();
        double Perimeter();
    }

    class CircleTwo : IShape
    {
        public double Radius { get; set; }

        public CircleTwo(double radius)
        {
            Radius = radius;
        }

        public double Area() => Math.PI * Radius * Radius;

        public double Perimeter() => 2 * Math.PI * Radius;
    }
    #endregion

    #region Example Two
    interface IPrintable
    {
        void Print();
    }

    interface ISavable
    {
        void Save(string filename);
    }

    class Document : IPrintable, ISavable
    {
        public string Content { get; set; } = "Interface Example Document";

        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Save(string filename)
        {
            Console.WriteLine($"Saving '{Content}' to {filename}.txt");
        }
    }
    #endregion

    #region Example Three
    interface IReadable
    {
        void Read();
    }

    interface IWritable : IReadable
    {
        void Write(string data);
    }

    class FileHandler : IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading data from file...");
        }

        public void Write(string data)
        {
            Console.WriteLine($"Writing '{data}' to file...");
        }
    }
    #endregion

    #region Example Four
    interface IEmail
    {
        void Send();
    }

    interface ISMS
    {
        void Send();
    }

    class Notification : IEmail, ISMS
    {
        void IEmail.Send()
        {
            Console.WriteLine("Sending Email Notification...");
        }

        void ISMS.Send()
        {
            Console.WriteLine("Sending SMS Notification...");
        }
    }
    #endregion

    #region Example Five
    interface ILogger
    {
        void Log(string message);

        // Default implementation (C# 8+)
        void LogError(string error)
        {
            Console.WriteLine($"Error: {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Info: {message}");
        }
    }
    #endregion

    #region Example Six
    public interface IEmployee
    {
        // ✅ Property (declaration only, no backing field)
        string Name { get; set; }

        // ✅ Method
        void Work();

        // ✅ Event
        event EventHandler WorkCompleted;

        // ✅ Indexer
        string this[int index] { get; set; }
    }

    public class Developer : IEmployee
    {
        private string[] tasks = new string[5];

        // Implementing Property
        public string Name { get; set; }

        // Implementing Event
        public event EventHandler WorkCompleted;

        // Implementing Method
        public void Work()
        {
            Console.WriteLine($"{Name} is coding...");
            // Raise event when work is completed
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }

        // Implementing Indexer
        public string this[int index]
        {
            get => tasks[index];
            set => tasks[index] = value;
        }
    }
    #endregion

    #endregion

    #region Interviwe Q&A

    /*

    Q1. What is an Interface in C#?
    🗣️ It’s a contract that defines a set of members that implementing classes must provide.

    Q2. Difference Between Abstract Class and Interface?
        | Feature          | Abstract Class                  | Interface                                |
        | ---------------- | ------------------------------- | ---------------------------------------- |
        | Inheritance      | Single                          | Multiple                                 |
        | Members          | Fields + Methods + Properties   | Methods + Properties only                |
        | Access Modifiers | Any                             | Public only                              |
        | Implementation   | Partial allowed                 | None (before C# 8), Default (after C# 8) |
        | Constructor      | Allowed                         | Not allowed                              |
        | Use Case         | Common functionality + template | Common contract only                     |

    Q3. Can an interface inherit another interface?
    ✅ Yes, it supports multiple inheritance.

    Q4. Can interfaces have constructors or fields?
    ❌ No, only abstract members (methods, properties, events, indexers).

    Q5. Can we create an object of an interface?
    ❌ No, but you can create an object of a class that implements it.

    Q6. Can a class implement multiple interfaces with same method name?
    ✅ Yes, but use explicit implementation to resolve ambiguity.

    Q7. What’s the benefit of using interfaces in C#?
    ✅ Helps achieve:

        Loose coupling

        Scalability

        Testability

        Dependency Injection

    */

    #endregion
}
