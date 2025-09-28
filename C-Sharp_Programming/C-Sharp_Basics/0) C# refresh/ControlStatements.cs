namespace C_Sharp_Basics._0__C__refresh
{
    #region Theorys

    /*
    
        Control Statements in C#
        
        1. Conditional Statements
             - if: Executes a block of code if a specified condition is true.
             - else: Executes a block of code if the condition in the if statement is false.
             - else if: Specifies a new condition to test if the previous condition was false.
             - switch: Selects one of many code blocks to execute based on the value of a variable or expression.
        2. Looping Statements
             - for: Repeats a block of code a specified number of times.
             - while: Repeats a block of code as long as a specified condition is true.
             - do-while: Similar to while, but guarantees that the block of code is executed at least once before checking the condition.
             - foreach: Iterates through each element in a collection (like an array or list).
        3. Jump Statements
             - break: Exits the nearest enclosing loop or switch statement.
             - continue: Skips the current iteration of the nearest enclosing loop and proceeds to the next iteration.
             - return: Exits from the current method and optionally returns a value.
             - goto: Transfers control to a labeled statement within the same method (generally discouraged due to readability concerns).
     
    */

    #endregion

    #region Praticle

    public class ControlStatements
    {
        public ControlStatements() { } // Constructor
        public void CheckNumber(int number)
        {
            // Conditional Statements
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
           
            // Switch Statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered one.");
                    break;
                case 2:
                    Console.WriteLine("You entered two.");
                    break;
                default:
                    Console.WriteLine("You entered a number other than one or two.");
                    break;
            }
        }
        public void PrintNumbers(int limit)
        {
            // For Loop
            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Skip even numbers
                }
                Console.WriteLine(i); // Print odd numbers
            }
            
            // While Loop
            int count = 1;
            while (count <= limit)
            {
                Console.WriteLine(count);
                count++;
            }
            
            // Do-While Loop
            int doCount = 1;
            do
            {
                Console.WriteLine(doCount);
                doCount++;
            } while (doCount <= limit);
        }
    }

    #endregion

    #region Interviwe Q&A

    /*
     
        1. What are control statements in C#?
             - Control statements are used to control the flow of execution in a program. They include conditional statements, looping statements, and jump statements.
        2. What is the difference between 'if' and 'switch' statements?
             - 'if' statements are used for conditional branching based on boolean expressions, while 'switch' statements are used for selecting one of many code blocks to execute based on the value of a variable or expression.
        3. How does a 'for' loop differ from a 'while' loop?
             - A 'for' loop is typically used when the number of iterations is known beforehand, while a 'while' loop is used when the number of iterations is not predetermined and depends on a condition.
        4. What is the purpose of the 'break' statement?
             - The 'break' statement is used to exit the nearest enclosing loop or switch statement prematurely.
        5. When would you use a 'continue' statement?
             - The 'continue' statement is used to skip the current iteration of a loop and proceed to the next iteration.
        6. What is the difference between 'while' and 'do-while' loops?
             - A 'while' loop checks the condition before executing the loop body, while a 'do-while' loop executes the loop body at least once before checking the condition.
        7. What are some best practices for using control statements in C#?
             - Some best practices include avoiding deep nesting of control statements for better readability, using meaningful variable names, and ensuring that loops have a clear exit condition to prevent infinite loops.
        8. What’s the difference between for and foreach?
             - for gives index control, foreach is used for collections and is safer.
    
    */

    #endregion
}
