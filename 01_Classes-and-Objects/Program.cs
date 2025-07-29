namespace _01_Classes_and_Objects
{
    //Class : 
    //A class is a blueprint or template for creating objects.
    //It defines properties (fields) and behaviors (methods) that the objects created from the class will have.
    //It does not occupy memory until you create an object from it.

    //Object :
    //An object is an instance of a class.
    //It is created using the new keyword.
    //It occupies memory and can store data and execute methods defined in the class.

    //Object in memory :
    //each instance has its own space in mem, only members
    //function are shared among all objects
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson();
            person1.Fname = "Abdullah";
            person1.Lname = "Hussein";
            Console.WriteLine("Access Obj1 (person1:)");
            Console.WriteLine(person1.FullName());

            clsPerson person2 = new clsPerson();
            person2.Fname = "Ismail";
            person2.Lname = "Mohammed";
            Console.WriteLine("\nAccess Obj2 (person2:)");
            Console.WriteLine(person2.FullName());
        }
    }
}
