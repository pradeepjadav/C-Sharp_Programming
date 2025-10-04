using C_Sharp_Basics;
using C_Sharp_Basics._1__OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine(BasicsCommon.GetGreeting());

        // Classes And Objects
        ClassesAndObjects.PraticleExampleOne();
        ClassesAndObjects.PraticleExampleTwo();

        // Constructors
        Constructors.PraticeExampleForDefaultConstructor();
        Constructors.PraticleExampleForParameterizedConstructor();
        Constructors.PraticleExampleForCopyConstructor();
        Constructors.PraticleExampleForStaticConstructor();

        // Inheritence 
        Inheritance.PraticeExampleOne();
        Inheritance.PraticeExampleTwoForBaseKeyWord();
        // Types of Inheritance
        Inheritance.PraticeExampleForSingleInheritace();
        Inheritance.PraticeExampleForMultilevelInheritance();
        Inheritance.PraticeExampleForHierarchicalInheritance();

        // Diamond Problem in Inheritance 
        DiamondProblem.PraticeExample(); // This is a resolved example.

        // Polymorphism
        // 1. Compile -time Polymorphism
        Polymorphism.PraticeExampleOneForCompileTimePolymorphism(); // method overloading
        Polymorphism.PraticeExampleTwoForCompileTimePolymorphism(); // operator overloading
        // 2. Runtime Polymorphism
        Polymorphism.PraticeExampleForRuntimePolymorphism(); // method overriding
        Polymorphism.PraticeExampleForBaseKeywordInRuntimePolymorephism(); // base key word
        Polymorphism.PraticeExampleForMethodHidingInRuntimePolymorephism(); // mew key word

    }
}