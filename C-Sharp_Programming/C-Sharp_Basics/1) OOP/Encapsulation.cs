namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    What is Encapsulation?

        Encapsulation means binding data (fields) and methods (functions) that work on that data into a single unit — a class — and restricting direct access to the internal state.

    👉 In simple words:

        “Encapsulation is hiding internal data and exposing only what’s necessary.”

    Encapsulation is achieved using:

        1. Private fields

        2. Public properties (get/set)

        3. Access modifiers (public, private, protected, internal, etc.)

    Real-World Example:

    Think of a capsule medicine 💊 — it hides the internal chemicals, and you just use it safely.
    Same with C# classes — they hide fields and expose safe access via properties (get/set).

    Why Encapsulation is Important:

        | Benefit                  | Description                                               |
        | ------------------------ | --------------------------------------------------------- |
        | **Data Security**        | Prevents direct modification of fields                    |
        | **Controlled Access**    | Exposes only necessary operations                         |
        | **Code Maintainability** | Implementation can change without affecting external code |
        | **Reusability**          | Easy to use and extend safely                             |

    Access Modifiers in C#:

        👉 Access modifiers control visibility and access of members.
        
        | Modifier               | Accessible From                                    | Used For                  |
        | ---------------------- | -------------------------------------------------- | ------------------------- |
        | **public**             | Anywhere                                           | For global access         |
        | **private**            | Only inside the same class                         | To hide internal data     |
        | **protected**          | Same class + derived classes                       | For inheritance           |
        | **internal**           | Within the same assembly/project                   | For project-level sharing |
        | **protected internal** | Same assembly + derived classes                    | Combined access           |
        | **private protected**  | Same class or derived classes in the same assembly | More restricted variant   |



    */

    #endregion

    #region Why It Matters in Real World

    /*

    Imagine a Bank Account Class:

        Balance → private

        Deposit/Withdraw → public methods

        Internal calculation fees → internal

        Transaction history → protected for child classes

        So users can only interact safely — they can’t just modify balance directly.

    */

    #endregion

    #region Praticle

    public class Encapsulation
    {
        // Without Encapsulation (Bad Practice)
        public static void PraticeExampleWithoutEncapsulation()
        {
            StudentFour s = new StudentFour();
            s.Age = -5;  // ❌ Invalid age, but still allowed
            Console.WriteLine($"Age: {s.Age}");
        }

        // With Encapsulation (Good Practice)
        public static void PraticeExampleWithEncapsulation()
        {
            StudentFive studentFive = new StudentFive();
            studentFive.Age = 21;      // ✅ Valid
            Console.WriteLine($"Age: {studentFive.Age}");

            studentFive.Age = -5;      // ❌ Invalid age
        }

        // Properties (get / set)
        public static void PraticeExampleWithFullPropertys()
        {
            FullProperty fullProperty = new FullProperty();
            fullProperty.Name = "ABC";
            Console.WriteLine($"Full Property Name: {fullProperty.Name}");
        }

        // Auto-Implemented Property
        public static void PraticeExampleAutoImplimented()
        {
            AutoImplementedProperty auto = new AutoImplementedProperty();
            auto.CourseName = "C# (C-Sharp)";
            Console.WriteLine($"Auto Implemented Property output: {auto.CourseName}");
        }

        // Read-Only Property
        public static void PraticeExampleReadOnly()
        {
            ReadOnlyProperty onlyProperty = new ReadOnlyProperty();
            //onlyProperty.University = "Error throwing";
            Console.WriteLine($"Read-only property outoput: {onlyProperty.University}");
        }

        // Write-Only Property
        public static void PraticeExampleWriteOnly()
        {
            WriteOnlyProperty writeOnly = new WriteOnlyProperty();
            writeOnly.Password = "ASDSNKNFKIIWDKWNDK!^@25";
            //Console.WriteLine(writeOnly.Password); // It will throw an error
        }

        // Example with Access Modifiers
        public static void PraticeExampleForAccessModifiers()
        {
            AccessModifiesProperty modifiesProperty = new AccessModifiesProperty();

            //modifiesProperty.salary = 0.000; // Not Accessible because only within class

            //modifiesProperty.department = "ABC"; // Not Accessble because within class + derived

            modifiesProperty.empId = 1; // It is accessible because Within project

            modifiesProperty.Name = "CSharp learner"; // It is accessible because accessible anywere
        }
    }

    class StudentFour
    {
        public string Name;
        public int Age;
    }

    class StudentFive
    {
        private int age;  // private field

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) // validating user input
                    age = value;
                else
                    Console.WriteLine("Invalid age!");
            }
        }
    }

    class FullProperty
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class AutoImplementedProperty
    {
        public string CourseName { get; set; }
    }

    class ReadOnlyProperty
    {
        public string University { get; } = "MIT";
    }

    class WriteOnlyProperty
    {
        private string password;
        public string Password { set { password = value; } }
    }

    class AccessModifiesProperty
    {
        private double salary;             // only within class
        protected string department;       // within class + derived
        internal int empId;                // within project
        public string Name { get; set; }   // accessible anywhere
    }
    #endregion

    #region Interviwe Q&A

    /*

    Q1. What is encapsulation in C#?
    👉 Wrapping data and code into one unit and restricting direct access to fields.

    Q2. How do you achieve encapsulation in C#?
    👉 By using private fields and public properties (get/set).

    Q3. Difference between public and private?
    👉 public is accessible everywhere; private is only within the same class.

    Q4. Why use properties instead of public fields?
    👉 Properties allow validation, logging, or computed logic — public fields don’t.

    Q5. Can we have logic in get/set?
    👉 Yes, we can validate, log, or compute data before returning or setting.

    Q6. What is the default access modifier for a class member?
    👉 private (for fields and methods inside a class).

    */

    #endregion
}
