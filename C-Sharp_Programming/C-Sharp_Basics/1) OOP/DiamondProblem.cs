namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    What is it?

        The Diamond Problem occurs in programming languages that allow multiple inheritance with classes (like C++).
        It happens when a class inherits from two classes that share a common base class, creating ambiguity.

        C# does not allow multiple inheritance with classes (only with interfaces) precisely to avoid this problem.

    Why doesn’t it happen in C#?

        Because C# does not support multiple inheritance with classes.
        Instead, it uses interfaces. Interfaces don’t have implementation (before C# 8), so no ambiguity exists.

    */

    #endregion

    #region Why It Matters in Real World

    /*

    Think of Diamond Problem like this:

        You have two managers (Mammal and Bird) who both report to the same CEO (Animal).

        You (the Bat) report to both managers.

        When the CEO gives an order, you don’t know whether to follow the Mammal manager’s interpretation or the Bird manager’s interpretation → confusion (ambiguity).

    C# solves this by saying:
    👉 “You can’t have two managers (classes). If you need to, use interfaces and decide the rules yourself.”

    */

    #endregion

    #region Praticle

    public class DiamondProblem
    {
        public static void PraticeExample()
        {
            Bat b = new Bat();
            b.Speak(); // ✅ Clear: Bat's Speak() is called
        }
    }

    interface IAnimal
    {
        void Speak();
    }

    interface IMammal : IAnimal
    {
        void Speak();
    }

    interface IBird : IAnimal
    {
        void Speak();
    }

    class Bat : IMammal, IBird
    {
        public void Speak()
        {
            Console.WriteLine("Bat squeaks...");
        }
    }

    #endregion
}
