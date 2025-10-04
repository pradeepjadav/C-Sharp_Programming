namespace C_Sharp_Basics._1__OOP
{
    #region Theorys

    /*

    🔹 What is Polymorphism?

        Polymorphism = “Many forms”.
        It allows the same method or operator to behave differently based on the context (class, parameters, or runtime object).

        👉 In simple words: One name, many behaviors.

    Types of Polymorphism in C#

        Polymorphism in C# can be categorized into two main types:

        A) Compile-time Polymorphism (Static)

            Achieved by Method Overloading & Operator Overloading.

            The decision is made at compile-time.

        B) Runtime Polymorphism (Dynamic)

            Achieved by Method Overriding using virtual / override.

            The decision is made at runtime (based on object type).

    // Note: Abstract classes and interfaces also support runtime polymorphism.

    */

    #endregion

    #region Why It Matters in Real World

    /*

    Compile-time polymorphism → Like a Bank ATM button “Withdraw”:

        If you insert a debit card → it withdraws from savings.

        If you insert a credit card → it withdraws from credit limit.

    Runtime polymorphism → Like a remote control:

        The same “Play” button plays a movie on TV or music on the speaker, depending on the device connected.

    */

    #endregion

    #region Praticle

    public class Polymorphism
    {
        // A) Compile-time Polymorphism
        // 1. Method Overloading: Same method name, but different parameters(number, type, or order).
        public static void PraticeExampleOneForCompileTimePolymorphism()
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add(int, int): " + calc.Add(5, 10)); // Calls Add(int, int)
            Console.WriteLine("Add(double, double): " + calc.Add(5.5, 10.2)); // Calls Add(double, double)
            Console.WriteLine("Add(int, int, int): " + calc.Add(5, 10, 15)); // Calls Add(int, int, int)
        }

        // 2. Operator Overloading: You can redefine operators(+, -, *, etc.) for custom classes.
        public static void PraticeExampleTwoForCompileTimePolymorphism()
        {
            complex c1 = new complex(2, 3);
            complex c2 = new complex(4, 5);
            complex c3 = c1 + c2; // Uses overloaded + operator
            Console.WriteLine("Complex Addition: " + c3.real + " + " + c3.Imaginary + "i");
        }

        // B) Runtime Polymorphism
        // 1. Method Overriding (virtual & override): Base class method is redefined in derived class.
        public static void PraticeExampleForRuntimePolymorphism()
        {
            AnimalThree myAnimal;

            myAnimal = new DogThree();
            myAnimal.Speak(); // Outputs: Dog barks

            myAnimal = new CatOne();
            myAnimal.Speak(); // Outputs: Cat meows
        }

        // 2. Using base keyword: We can also call the base class method inside the override.
        public static void PraticeExampleForBaseKeywordInRuntimePolymorephism()
        {
            DogFour dog = new DogFour();
            dog.Speak(); // print in console "Animal makes a sound" and "Dog barks"
        }

        // 3. Method Hiding (new keyword): If you don’t want to override but just hide the base method, use new.
        public static void PraticeExampleForMethodHidingInRuntimePolymorephism()
        {
            AnimalFour animal = new AnimalFour();
            animal.Speak();

            AnimalFour dogFive = new DogFive();
            dogFive.Speak(); // Calls AnimalFour's Speak due to reference type

        }
    }

    #region A) Compile-time Polymorphism
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class complex
    {
        public int real, Imaginary;

        public complex(int r = 0, int i = 0)
        {
            real = r;
            Imaginary = i;
        }
        public static complex operator +(complex c1, complex c2)
        {
            return new complex(c1.real + c2.real, c1.Imaginary + c2.Imaginary);
        }
    }
    #endregion

    #region B) Runtime Polymorphism
    class AnimalThree
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class DogThree : AnimalThree
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class CatOne : AnimalThree
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }
    class DogFour : AnimalThree
    {
        public override void Speak()
        {
            base.Speak();  // Calls base class method (AnimalThree)
            Console.WriteLine("Dog barks");
        }
    }
    class AnimalFour
    {
        public void Speak() => Console.WriteLine("Animal sound");
    }
    class DogFive : AnimalFour
    {
        public new void Speak() => Console.WriteLine("Dog sound");  // Hides base class method
    }

    #endregion

    #endregion

    #region Interviwe Q&A

    /*

    Q1. What is the difference between overloading and overriding?
    👉 Overloading = compile-time, different signatures.
    👉 Overriding = runtime, same signature but different implementation.

    Q2. Can constructors be overloaded in C#?
    👉 Yes, constructor overloading is allowed.

    Q3. Can constructors be overridden in C#?
    👉 No, constructors are not inherited, so they can’t be overridden.

    Q4. What’s the difference between override and new?
    👉 override = replaces base method behavior (polymorphism).
    👉 new = hides base method (no polymorphism).

    Q5. Can static methods be overridden?
    👉 No, static methods are not polymorphic.

    */

    #endregion

}