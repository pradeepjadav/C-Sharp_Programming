using C_Sharp_Basics;
using C_Sharp_Basics._1__OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine(BasicsCommon.GetGreeting());

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
        Inheritance.PraticeExampleForSingleInheritace();
        Inheritance.PraticeExampleForMultilevelInheritance();
        Inheritance.PraticeExampleForHierarchicalInheritance();

        // Diamond Problem in Inheritance 
        DiamondProblem.PraticeExample(); // This is a resolved example.
    }
}