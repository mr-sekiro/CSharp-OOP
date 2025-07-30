using System.Threading.Channels;

namespace _10_Sealed_Class
{
    #region Sealed Class
    ////Why Sealed Class?
    ////We use sealed classes to prevent inheritance.
    ////As we cannot inherit from a sealed class, the methods in the sealed class cannot be manipulated from other classes.

    //sealed class clsA
    //{
    //    public void PrintInfo() => Console.WriteLine("Info from Class A");

    //}

    //// trying to inherit sealed class

    //class clsB : clsA // Error Code
    //{


    //} 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sealed Method
            //During method overriding, if we don't want an overridden method to be further overridden by another class, we can declare it as a sealed method. 
            Person person = new Person();
            person.Greet(); // outputs "The person says hello."

            Employee employee = new Employee();
            employee.Greet(); // outputs "The employee greets you."

            Manager manager = new Manager();
            manager.Greet(); // outputs "The employee greets you."
            #endregion

            Console.ReadKey();
        }
    }
}
