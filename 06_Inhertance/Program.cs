using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _06_Inhertance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 [Inheritance]
            //clsEmployee Employee1 = new clsEmployee();

            ////the following inherited from base class person
            //Employee1.ID = 10;
            //Employee1.Title = "Mr.";
            //Employee1.FirstName = "Abdullah";
            //Employee1.LastName = "Hussein";

            ////the following are from derived class Employee
            //Employee1.DepartmentName = "IT";
            //Employee1.Salary = 5000;

            //Console.WriteLine("Accessing Object 1 (Employee1):\n");
            //Console.WriteLine("ID := {0}", Employee1.ID);
            //Console.WriteLine("Title := {0}", Employee1.Title);
            //Console.WriteLine("Full Name := {0}", Employee1.FullName);
            //Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
            //Console.WriteLine("Salary := {0}", Employee1.Salary);

            //Employee1.IncreaseSalaryBy(100);
            //Console.WriteLine("Salary after increase := {0}", Employee1.Salary);

            #endregion

            #region Example 2 [Inheritance Constructor]

            //clsEmployee Employee1 = new clsEmployee(10, "Abdullah", "Hussein", "Mr", 5000, "IT");

            //Console.WriteLine("Accessing Object 1 (Employee1):\n");
            //Console.WriteLine("ID := {0}", Employee1.ID);
            //Console.WriteLine("Title := {0}", Employee1.Title);
            //Console.WriteLine("Full Name := {0}", Employee1.FullName);
            //Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
            //Console.WriteLine("Salary := {0}", Employee1.Salary);

            //Employee1.IncreaseSalaryBy(100);
            //Console.WriteLine("Salary after increase := {0}", Employee1.Salary); 

            #endregion

            #region Example 3 [Upcasting, Downcasting]
            ////Up Casting is converting derived object to it's base object.
            ////Down Casting is Converting Base object to Derived object

            ////Upcasting is a safe operation because a derived class is always a specialization of the base class
            ////Downcasting can be dangerous because a base class may not have all the members of a derived class.

            //// Upcasting
            //Employee employee = new Employee { Name = "John", Age = 30, Company = "Acme Inc.", Salary = 50000 };
            //Person person = employee;
            //person.Greet(); // Output: "Hi, my name is John and I am 30 years old."

            //// Downcasting
            //Person person2 = new Employee { Name = "Jane", Age = 25, Company = "XYZ Corp.", Salary = 60000 };
            //Employee employee2 = (Employee)person2;
            //employee2.Work(); // Output: "I work at XYZ Corp. and earn $60,000.00 per year."


            ////Person person3 = new Person { Name = "Bob", Age = 40 }; //Invalid downcasting - throws InvalidCastException at runtime
            ////Employee employee3 = (Employee)person3; // Runtime exception: InvalidCastException 
            #endregion

            #region Example 4 [Method Overriding]
            ////If the same method is present in both the base class and the derived class, the method in the derived class overrides the method in the base class. This is called method overriding
            //clsB ObjB = new clsB();
            //ObjB.Print(); 
            #endregion

            #region Example 5 [Method Hiding (Shadowing)]
            ////you can hide the implementation of the methods of a base class from the derived class using the new keyword. Or in other words,
            ////in method hiding, you can redefine the method of the base class in the derived class by using the new keyword.

            ////override replaces the base method behavior and supports polymorphism.
            ////new hides the base method and is type-dependent (base reference → base method).


            //MyBaseClass myBaseObj = new MyBaseClass();
            //Console.WriteLine("\nBase Object:\n");
            //myBaseObj.MyMethod(); // Output: "Base class implementation"
            //myBaseObj.MyOtherMethod(); // Output: "Base class implementation of MyOtherMethod"


            //MyDerivedClass myDerivedObj = new MyDerivedClass();
            //Console.WriteLine("\nDerived Object:\n");
            //myDerivedObj.MyMethod(); // Output: "Derived class implementation using override"
            //myDerivedObj.MyOtherMethod(); // Output: "Derived class implementation of MyOtherMethod using new"


            //MyBaseClass myDerivedObjAsBase = myDerivedObj;
            //Console.WriteLine("\nAfter Castring:\n");
            //myDerivedObjAsBase.MyMethod(); // Output: "Derived class implementation using override"
            //myDerivedObjAsBase.MyOtherMethod(); // Output: "Base class implementation of MyOtherMethod"

            ////MyMethod() uses override, so even when called via base reference(myDerivedObjAsBase), it uses the derived version.
            ////MyOtherMethod() uses new, so the compiler binds it to the base class version when accessed via a base type reference. 
            #endregion

            #region Example 6 [multi-level inheritance]
            ////ElectricCar inherits from Car, which inherits from Vehicle.Each class adds more functionality.This is multi-level inheritance.
            //ElectricCar tesla = new ElectricCar();
            //tesla.Brand = "Tesla";
            //tesla.Model = "Model S";
            //tesla.BatteryLevel = 85;

            //tesla.Start();       // From Vehicle
            //tesla.Drive();       // From Car
            //tesla.Charge();      // From ElectricCar 
            #endregion

            #region Example 7 [hierarchical inheritance]
            //Dog and Cat both inherit from Animal but have their own unique behaviors.This is hierarchical inheritance (one base → many branches).
            Dog dog = new Dog();
            dog.Name = "Rex";
            dog.Eat();   // From Animal
            dog.Bark();  // From Dog

            Cat cat = new Cat();
            cat.Name = "Whiskers";
            cat.Eat();   // From Animal
            cat.Meow();  // From Cat 
            #endregion

            Console.ReadKey();

        }
    }
}
