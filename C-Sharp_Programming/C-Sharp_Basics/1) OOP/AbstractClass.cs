namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    An abstract class is a base class that cannot be instantiated directly.
    
    It defines a template for other classes and can contain:

        - Abstract methods (no implementation)

        - Concrete methods (normal implemented methods)

        - Fields

        - Properties

        - Constructors

    👉 It is used when multiple subclasses share common functionality, but each has its own way of implementing specific behavior.

    When to Use Abstract Classes:

        | Situation                                          | Why Abstract Class Works Best                    |
        | -------------------------------------------------- | ------------------------------------------------ |
        | Shared logic among related classes                 | You can put common code in base class            |
        | Need to enforce certain methods in derived classes | Use abstract methods                             |
        | Want both implementation + flexibility             | Abstract + normal members                        |
        | Common data/initialization needed                  | Use base constructors                            |
        | Building reusable frameworks                       | Abstract classes define contracts for extensions |

    Abstract classes are ideal when:

        - You want to create a common template for related classes.

        - You need shared code + abstract behavior.

        - You plan to extend functionality in the future.
        
    They’re used in:

        - Enterprise systems (e.g., Payment gateways, Report engines)

        - ASP.NET Core middleware

        - EF Core provider layers

        - Game engines (e.g., Base GameObject or Character classes)

    */

    #endregion

    #region Why It Matters in Real World

    /*

    This demonstrates Template Method Pattern — an abstract class defines a fixed sequence of steps,
    and derived classes customize specific parts.

    Used widely in:

        Data import/export modules

        ETL processes

        PDF or Excel report generation systems

    */

    #endregion

    #region Praticle

    public class AbstractClass
    {
        // Example 1 — Basic Example with Fields, Properties, Methods, and Constructor
        public static void PraticeExampleOne()
        {
            FullTimeEmploye employe = new FullTimeEmploye("Alice", 101, 8000);
            employe.DisplayInfo();
            Console.WriteLine($"Salary : {employe.CalculateSalary()}");
        }

        // Example 2 — Abstract Class with Abstract & Normal Properties
        public static void PraticeExampleTwo()
        {
            CircleOne circle = new CircleOne(5, "Red");
            circle.Draw();
            Console.WriteLine($"Area: {circle.Area}");
            circle.DisplayColor();
        }

        // Example 3 — Real-World Scenario: Payment Gateway System
        public static void PraticeExampleThree()
        {
            PaymentGateway gateway = new PayPalGateway();
            gateway.ProcessPayment(250.00);
            gateway.ShowTransactionId();
            gateway.Refund(100.00);
        }

        // Example 4 — Abstract Class with Partial Implementation (Template Method Pattern)
        public static void PraticeExampleFour()
        {
            ReportGenerator report = new SalesReport();
            report.GenerateReport();
        }
    }

    #region Example One
    abstract class Employee
    {
        // Fields
        protected string name;

        // Properties
        public int Id { get; set; }

        // Constructors
        public Employee(string name, int id)
        {
            this.name = name;
            this.Id = id;
            Console.WriteLine("Employee base constructor called.");
        }

        // Abstract Methods
        public abstract double CalculateSalary();

        // Normal Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {name}, ID: {Id}");
        }
    }

    class FullTimeEmploye : Employee
    {
        private double monthlysalary;

        public FullTimeEmploye(string name, int id, double salary)
            : base(name, id) // Call base class constructor
        {
            this.monthlysalary = salary;
            Console.WriteLine("Derived Class constructor Called !");
        }

        public override double CalculateSalary()
        {
            return monthlysalary;
        }
    }
    #endregion

    #region Example Two
    abstract class ShapeTwo
    {
        // Abstract property (must be overriden)
        public abstract double Area { get; }

        // Normal Property
        public string Color { get; set; }

        public abstract void Draw();

        public void DisplayColor() => Console.WriteLine($"Shape color: {Color}");
    }

    class CircleOne : ShapeTwo
    {
        public double Redius { get; set; }

        // Constructor
        public CircleOne(double radios, string color)
        {
            this.Redius = radios;
            base.Color = color;
        }

        // Override abstract property and mothods
        public override double Area => Math.PI * Redius * Redius;

        public override void Draw() => Console.WriteLine("Drawing a circle...");
    }
    #endregion

    #region Example Three
    abstract class PaymentGateway
    {
        // Common field
        protected string TransactionId;

        // Constructor to initialize transaction
        public PaymentGateway()
        {
            TransactionId = Guid.NewGuid().ToString();
        }

        // Abstract methods
        public abstract void ProcessPayment(double amount);
        public abstract void Refund(double amount);

        // Normal methods
        public void ShowTransactionId()
        {
            Console.WriteLine($"Transaction ID: {TransactionId}");
        }

        public void LogTransaction(string status)
        {
            Console.WriteLine($"[{DateTime.Now}] Transaction {TransactionId} - {status}");
        }
    }

    class PayPalGateway : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment: ${amount}");
            LogTransaction("Success");
        }

        public override void Refund(double amount)
        {
            Console.WriteLine($"Refunding ${amount} via PayPal...");
            LogTransaction("Refund Success");
        }
    }
    #endregion

    #region Example Four
    abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            FetchData();
            FormatReport();
            SaveToFile();
        }

        // Steps to be implemented by derived class
        protected abstract void FetchData();
        protected abstract void FormatReport();

        // Shared implementation
        protected void SaveToFile()
        {
            Console.WriteLine("Saving report to file...");
        }
    }

    class SalesReport : ReportGenerator
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching sales data from database...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting sales data into report...");
        }
    }
    #endregion

    #endregion

    #region Interviwe Q&A

    /*



    */

    #endregion
}
