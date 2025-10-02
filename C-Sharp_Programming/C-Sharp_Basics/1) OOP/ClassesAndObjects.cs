namespace C_Sharp_Basics._1__OOP
{

    #region Theorys

    /*

        What is a class?
            - A class is a blueprint or template for creating object.
            - It defines fileds (Date/ Variables) and mothods (Behaviuor/Functions).
            - Thinks of it like a blueprint of the hourse -- you can build many hourse (Objects) from one blueprint (classes).
        
        What is a Object?
            - An object is an instance of the class.
            - Each object has its own copy fileds and can use the methods.

        Key points:
            - Class => Definition (Blueprint).
            - Object => Instance (Real world entity).
            - Multiple objects can be create from one class.
            - Class members -> Fileds, Proparties, Methods, Constructors

    */

    #endregion

    #region Why It Matters in Real World

    /*

        - Encapsulation of data: All student details, car details, etc. are grouped together.

        - Code Reusability: Define once → use multiple objects.

        - Scalability: Enterprise apps rely heavily on objects (e.g., Employee, Customer, Order).

        - Used in Entity Framework, ASP.NET MVC, Web API, Microservices — everywhere.

        Example in real-world project:

            - Class User → objects for each registered user in your system.

            - Class Product → objects for each item in e-commerce apps.

    */

    #endregion

    #region Praticle

    public static class ClassesAndObjects
    {
        // Example 1: Simple Class & Object
        public static void PraticleExampleOne()
        {
            Student s1 = new Student();
            s1.Name = "Pradeep";
            s1.Age = 100;
            s1.DisplayInfo();

            Student s2 = new Student();
            s2.Name = "Anjali";
            s2.Age = 200;
            s2.DisplayInfo();
        }

        // Example 2: Class with Constructor
        public static void PraticleExampleTwo()
        {
            Book bookOne = new Book("1984", "George Orwell");
            bookOne.DisplayInfo();

            Book bookTwo = new Book("To Kill a Mockingbird", "Harper Lee");
            bookTwo.DisplayInfo();
        }

        /*
        
            Output:
            StudentId: 0 Name: Pradeep, Age: 100
            StudentId: 0 Name: Anjali, Age: 200

            Title: 1984, Author: George Orwell
            Title: To Kill a Mockingbird, Author: Harper Lee
        */
    }

    public class Student
    {
        public long Id;
        public string Name;
        public int Age;

        public void DisplayInfo()
        {
            Console.WriteLine($"StudentId: {Id} Name: {Name}, Age: {Age}");
        }
    }

    public class Book
    {
        public string Title;
        public string Author;

        // constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }

    #endregion

    #region Interviwe Q&A

    /*

        Q1. What is a class in C#?
        👉 A class is a user-defined blueprint or prototype from which objects are created. It defines fields, methods, constructors, and properties.

        Q2. What is an object in C#?
        👉 An object is an instance of a class. It represents a real-world entity with data (fields) and behavior (methods).

        Q3. Can we create an object without using the new keyword?
        👉 Yes, in special cases like factory methods, reflection, and deserialization, objects can be created without explicitly calling new.

        Q4. Where are objects stored in memory?
        👉 Objects are stored in the heap, while the reference (variable) is stored in the stack.

        Q5. Difference between class and object?

            Class → Blueprint
            Object → Instance of class

        Q6. Can a class exist without an object?
        👉 Yes. A class can exist as a definition without creating any object. But to use its members (except static ones), an object is needed.

    */

    #endregion
}
