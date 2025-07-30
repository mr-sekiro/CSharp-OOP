namespace _05_Constructor_and_Destructor
{
    //Constructor
    //In C#, a constructor is similar to a method that is invoked when an object of the class is created.

    //However, unlike methods, a constructor:
    //has the same name as that of the class
    //does not have any return type
    //you can have multiple constructors in the class using overloading

    //Destructor(finalizer)
    //used to destroy objects of class when the scope of an object ends.It has the same name as the class and starts with a tilde ~
    //Features of Destructors:
    //We can only have one destructor in a class.
    //A destructor cannot have access modifiers, parameters, or return types.
    //A destructor is called implicitly by the Garbage collector of the.NET Framework.
    //We cannot overload or inherit destructors.
    //We cannot define destructors in structs.

    /*
      Types of Constructors
      
      Parameterless Constructor
      Parameterized Constructor
      Default Constructor : If we have not defined a constructor in our class, then the C# will automatically create a default constructor with an empty code and no parameters
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Constructors and Destructor Example ===\n");

            // Using Parameterless Constructor
            clsPerson defaultPerson = new clsPerson();
            Console.WriteLine("Default Person:");
            Console.WriteLine($"ID: {defaultPerson.Id}, Name: {defaultPerson.Name}, Age: {defaultPerson.Age}\n");

            // Using Parameterized Constructor
            clsPerson customPerson = new clsPerson(1, "Abdullah", 25);
            Console.WriteLine("Custom Person:");
            Console.WriteLine($"ID: {customPerson.Id}, Name: {customPerson.Name}, Age: {customPerson.Age}\n");

            // Demonstrating Static Class (no object creation)
            Console.WriteLine("Static Class Settings:");
            Console.WriteLine($"Today's Day Number: {Settings.DayNumber}");
            Console.WriteLine($"Today's Day Name: {Settings.DayName}");

            // Setting static property
            Settings.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine($"Project Path: {Settings.ProjectPath}\n");

            // Destructor will be called automatically when the object is cleaned up by the Garbage Collector
            Console.WriteLine("Program end. Destructor will be called by GC when object is no longer in use.");
        }
    }
}
