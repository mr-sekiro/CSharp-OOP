namespace _07_Abstract_Class
{
    //Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).
    //Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).
    //we cannot create objects of an abstract class. We use the abstract keyword to create an abstract class.
    internal class Program
    {
        static void Main(string[] args)
        {
            //You cannot create an object of an abstract class, you can only inherit it.
            //Person Person1= new Person();

            Employee employee = new Employee();
            employee.FirstName = "Abdullah";
            employee.LastName = "Hussein";
            employee.EmployeeId = 123;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"

            Console.ReadKey();
        }
    }
}
