using C_Sharp_Basics;
using C_Sharp_Basics._1__OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine(BasicsCommon.GetGreeting());

        #region Classes And Objects
        ClassesAndObjects.PraticleExampleOne();
        ClassesAndObjects.PraticleExampleTwo();
        #endregion

        #region Constructors
        Constructors.PraticeExampleForDefaultConstructor();
        Constructors.PraticleExampleForParameterizedConstructor();
        Constructors.PraticleExampleForCopyConstructor();
        Constructors.PraticleExampleForStaticConstructor();
        #endregion

        #region Inheritence
        Inheritance.PraticeExampleOne();
        Inheritance.PraticeExampleTwoForBaseKeyWord();
        // Types of Inheritance
        Inheritance.PraticeExampleForSingleInheritace();
        Inheritance.PraticeExampleForMultilevelInheritance();
        Inheritance.PraticeExampleForHierarchicalInheritance();

        // Diamond Problem in Inheritance 
        DiamondProblem.PraticeExample(); // This is a resolved example.
        #endregion

        #region Polymorphism
        // 1. Compile -time Polymorphism
        Polymorphism.PraticeExampleOneForCompileTimePolymorphism(); // method overloading
        Polymorphism.PraticeExampleTwoForCompileTimePolymorphism(); // operator overloading
        // 2. Runtime Polymorphism
        Polymorphism.PraticeExampleForRuntimePolymorphism(); // method overriding
        Polymorphism.PraticeExampleForBaseKeywordInRuntimePolymorephism(); // base key word
        Polymorphism.PraticeExampleForMethodHidingInRuntimePolymorephism(); // mew key word
        #endregion

        #region Encapsulation
        Encapsulation.PraticeExampleWithoutEncapsulation(); // (Bad Practice)
        Encapsulation.PraticeExampleWithEncapsulation(); // (Good Pratice)

        // Properties (get / set)
        Encapsulation.PraticeExampleWithFullPropertys();
        Encapsulation.PraticeExampleAutoImplimented();
        Encapsulation.PraticeExampleReadOnly();
        Encapsulation.PraticeExampleWriteOnly();

        // Access Modifiers
        Encapsulation.PraticeExampleForAccessModifiers();
        #endregion

        #region Abstraction
        Abstraction.PraticeExampleForAbstractionClass();
        Abstraction.PraticeExampleForInterface();
        Abstraction.PraticeExampleBothabtractionForMultipleInheritance();

        // Abstract Class 
        AbstractClass.PraticeExampleOne();
        AbstractClass.PraticeExampleTwo();
        AbstractClass.PraticeExampleThree();
        AbstractClass.PraticeExampleFour();

        // Interface
        Interface.PraticeExampleOne(); 
        Interface.PraticeExampleTwo();
        Interface.PraticeExampleThree();
        Interface.PraticeExampleFour();
        Interface.PraticeExampleFive();
        Interface.PraticeExampleSix();

        #endregion
    }
}