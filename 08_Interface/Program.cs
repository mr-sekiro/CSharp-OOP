namespace _08_Interface
{
    //defines a contract — a set of method signatures(and optionally properties, events, indexers) that a class or struct must implement.
    //It does not contain implementation, only declarations.
    //Interface : is similar to abstract class. However, unlike abstract classes, all methods of an interface are fully abstract (method without body).
    //interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies).

    //Interfaces can contain properties and methods, but not fields/variables
    //An interface cannot contain a constructor (as it cannot be used to create objects)
    //We must provide the implementation of all the methods of interface inside the class that implements it.

    //implicit and explicit interface implementation
    //1. Implicit Interface Implementation
    //You implement the interface members using normal public methods.These members are directly accessible from the class instance.

    //2. Explicit Interface Implementation
    //You implement the interface method in such a way that it is only accessible through the interface reference, not the class instance.

    //Abstract Class Vs Interface
    //| Feature          | Interface                                    | Abstract Class                      |
    //| ---------------- | -----------------------------------------    | ----------------------------------- |
    //| Syntax           | interface                                    | abstract class                      |
    //| Implementation   | Cannot implement methods(until C# 8.0)       | Can provide method bodies           |
    //| Fields           | Not allowed                                  | Allowed                             |
    //| Constructors     | Not allowed                                  | Can define constructors             |
    //| Access Modifiers | All members are public                       | Can have any access modifier        |
    //| Inheritance      | Multiple interfaces                          | Only one abstract/base class        |
    //| Purpose          | Define capability/contract                   | Define base behavior + contract     |
    //| Example          | IDisposable, IEnumerable                     | Stream, DbContext, Shape            |

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 [Interface]
            //You cannot create an object of an Interface, you can only Implement it.
            //IPerson Person1 = new IPerson();

            Employee employee = new Employee();
            employee.FirstName = "Abdullah";
            employee.LastName = "Hussein";
            employee.EmployeeId = 123;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"
            employee.Print();
            employee.SendEmail();
            #endregion

            #region Example 2 [Implementing Multiple Interfaces]
            AdminUser admin = new AdminUser
            {
                Username = "Abdullah",
                Role = "SystemAdmin",
                AdminLevel = 5
            };

            admin.DisplayInfo();
            admin.LogOut();
            admin.MakeCall();
            admin.SendEmailMessage("Update", "System update complete.");
            admin.SendTextMessage("Reminder", "Meeting at 10 AM.");

            //Call explicit IUserInfo members
            IUserInfo userInfo = admin;
            userInfo.ShowMessage();
            Console.WriteLine(userInfo.GetInfoString());

            //Call explicit IContactService member
            IContactService contact = admin;
            contact.SendFaxMessage("Report", "Monthly performance report"); 
            #endregion

        }
    }
}
