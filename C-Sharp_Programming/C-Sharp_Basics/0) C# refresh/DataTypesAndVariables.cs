namespace C_Sharp_Basics._0__C__refresh
{
    #region Theory

    /*  
      Date type and variables in C#

      1. Value types 
         - int: Represents integer numbers(e.g., 1, -5, 42).
         - float: Represents single-precision floating-point numbers(e.g., 3.14f, -0.001f).
         - double: Represents double-precision floating-point numbers(e.g., 3.14159, -0.0001).
         - char: Represents a single character(e.g., 'A', 'b', '1').
         - bool: Represents a boolean value(true or false).
         - struct: A user-defined value type that can contain multiple related variables.
      2. Reference types
         - string: Represents a sequence of characters(e.g., "Hello, World!").
         - array: A collection of elements of the same type(e.g., int[], string[]).
         - class: A user-defined reference type that can contain fields, properties, methods, and events.
         - interface: A contract that defines a set of methods and properties that implementing classes must provide.
         - delegate: A type that represents references to methods with a specific parameter list and return type.
      3. Nulable types
          int? number = nulll;
    */

    #endregion

    #region Praticle

    public class DataTypesAndVariables
    {
        int x = 5; // Integer variable
        string name = "John"; // String variable
        int? age = null; // Nullable integer variable (? is meaning it is accepted nullble values)
        bool isActive = true; // Boolean variable
        float pi = 3.14f; // Float variable

        public DataTypesAndVariables() { } // Constructor
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {(age.HasValue ? age.Value.ToString() : "N/A")}, Active: {isActive}, Pi: {pi}");
        } // Method to display information
    }

    #endregion

    #region Interviwe Q&A

    /*
    
        1. What are the different data types in C#?
           - C# has several built-in data types, including int, float, double, char, bool, string, and more. It also supports user-defined types like classes and structs.
        2. What is the difference between value types and reference types?
           - Value types store the actual data directly, while reference types store a reference (or address) to the data. Value types include int, float, char, etc., while reference types include string, arrays, classes, etc.
        3. How do you declare a variable in C#?
           - You declare a variable by specifying its data type followed by its name. For example: int myNumber; string myString;
        4. What is a nullable type in C#?
           - A nullable type is a value type that can also hold a null value. It is declared using the ? symbol after the data type (e.g., int? myNullableInt;).
        5. Can you explain the difference between 'int' and 'Int32' in C#?
           - 'int' is an alias for 'Int32' in C#. They are functionally equivalent and can be used interchangeably.
        6. How do you convert a string to an integer in C#?
           - You can use methods like int.Parse(), Convert.ToInt32(), or int.TryParse() to convert a string to an integer.
        7. What is the default value of an uninitialized variable in C#?
           - The default value depends on the data type. For example, the default value for int is 0, for bool it is false, and for reference types like string it is null.
        8. How do you define a constant variable in C#?
           - You can define a constant variable using the 'const' keyword. For example: const int myConst = 10;
        9. What are enums in C#?
           - Enums (enumerations) are a special data type that allows you to define a set of named constants. For example: enum Days { Sunday, Monday, Tuesday }
        10. How do you handle large numbers in C#?
            - For large numbers, you can use data types like long (for integers) or decimal (for high-precision floating-point numbers).

    */

    #endregion
}
