namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

        ✅ What is a Constructor?

            A Constructor is a special method in a class.

            It is automatically called when an object of the class is created.

            It is used to initialize fields/properties of the class.

        👉 Rules:

            Name must be the same as the class name.

            No return type (not even void).

            Can be overloaded (multiple constructors in a class).
        
        Types of Constructors in C#

            1. Default Constructor

                No parameters.
                Automatically provided by C# if you don’t define any.
            
            2. Parameterized Constructor

                Takes parameters to set values at object creation.

            3. Copy Constructor
                Creates a new object as a copy of an existing object.

           4. Static Constructor

                Runs only once per class (not per object).
                Used to initialize static fields.

           5. Private Constructor

                Prevents instantiation outside the class.
                Used in Singleton Pattern.

                public class Logger
                {
                    private Logger() { } // Private constructor
                }
        

    */

    #endregion

    #region Why It Matters in Real World

    /*

        Initialization made easy: Automatically set default values when creating objects.

        Overloading flexibility: Different ways to initialize objects.

        Static Constructors: Used in enterprise apps for loading configuration once (e.g., DB connection strings, API keys).

        Private Constructors: Used in Singleton design pattern, common in logging, configuration, caching services.

        
    Real-world example:

        In Entity Framework, constructors are used to initialize DB contexts.

        In ASP.NET Core, services like ILogger use constructors for dependency injection.

    */

    #endregion

    #region Praticle

    public static class Constructors
    {
        // Example 1: Default Constructor
        public static void PraticeExampleForDefaultConstructor()
        {
            StudentOne s = new StudentOne();
            s.Display(); // Output: Unknown, 0
        }

        // Example 2: Parameterized Constructor
        public static void PraticleExampleForParameterizedConstructor()
        {
            StudentTwo s = new StudentTwo("Alice", 20);
            s.Display(); // Output: Alice, 20
        }

        // Example 3: Copy Constructor
        public static void PraticleExampleForCopyConstructor()
        {
            StudentTwo original = new StudentTwo("Bob", 22);
            StudentTwo copy = new StudentTwo(original.Name, original.Age); // Simulating copy constructor
            copy.Display(); // Output: Bob, 22

            CarOne car = new CarOne();
            CarOne carOne = new CarOne(new CarOne { Brand = "Toyota" });

            CarOne carOneCopy = new CarOne(car);
        }

        // Example 4: Static Constructor
        public static void PraticleExampleForStaticConstructor()
        {
            Console.WriteLine(AppConfig.Version);
        }
    }

    public class StudentOne
    {
        public string Name;
        public int Age;

        public StudentOne()  // default constructor
        {
            Name = "Unknown";
            Age = 0;
        }

        public void Display()
        {
            Console.WriteLine($"{Name}, {Age}");
        }
    }

    public class StudentTwo
    {
        public string Name;
        public int Age;

        public StudentTwo(string name, int age) // parameterized constructor
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"{Name}, {Age}");
        }
    }

    public class CarOne
    {
        public string Brand;

        public CarOne() // default constructor
        {
            Brand = "Unknown";
        }
        public CarOne(CarOne c) // copy constructor
        {
            Brand = c.Brand;
        }
    }

    public class AppConfig
    {
        public static string Version;

        static AppConfig()
        {
            Version = "1.0.0";
            Console.WriteLine("Static Constructor called!");
        }
    }


    #endregion

    #region Interviwe Q&A

    /*

    Q1. What is a constructor in C#?
    👉 A special method used to initialize objects when they are created. It has the same name as the class and no return type.

    Q2. Difference between constructor and method?

    Constructor → No return type, auto-called, same name as class.

    Method → Has return type, explicitly called, can have any name.

    Q3. Can we overload constructors in C#?
    👉 Yes, using different parameter lists (constructor overloading).

    Q4. What is a static constructor?
    👉 A constructor that initializes static data. Called only once, before any object is created or static member accessed.

    Q5. Can a constructor be private?
    👉 Yes. It prevents object creation outside the class, often used in Singleton Pattern.

    Q6. When is the default constructor provided by C#?
    👉 If no constructor is defined in the class, the compiler automatically provides a default constructor.

    */

    #endregion
}
