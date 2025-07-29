namespace _02_Access_Modifiers
{
    /**
     * Access modifiers, are used to set the access level/visibility for classes, fields, methods and properties.
     * 
     * public : The code is accessible for all classes
     * private : The code is only accessible within the same class
     * protected : The code is accessible within the same class, or in a class that is inherited from that class.
     * internal : The code is only accessible within its own assembly (dll), but not from another assembly. internal is equivalent to friend in c++.
    */

    //if you don’t explicitly specify an access modifier, the compiler assigns a default one based on the context(class, method, variable, etc.).
    //1. Top-Level Types (classes, interfaces, structs, enums)
    //  class MyClass { }:           internal
    //  interface IMyInterface{ }:   internal
    //  struct MyStruct{ }:          internal
    //  enum MyEnum{ }:              internal
    //2. Class Members(fields, methods, properties, etc.)
    //  void MyMethod() { } :               private
    //  int myField; :                      private
    //  string MyProperty{ get; set; } :    private
    //  event Action MyEvent; :             private
    //3. Interface Members
    //  All members in an interface are implicitly public, even if you omit the modifier:
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object from class
            clsA A = new clsA();

            //all public members are accessable and internal 
            Console.WriteLine("All public members are accessable");
            Console.WriteLine("x1={0}", A.x1);
            Console.WriteLine("result of fun1={0}", A.fun1());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2={0}", A.x2);

            //you cannot access protected members in the folling line.
            // Console.WriteLine("x3={0}", A.x3);

            //you cannot access private members in the folling line.
            // Console.WriteLine("result of fun2={0}", A.fun2());

            //you cannot access protected members in the folling line.
            // Console.WriteLine("result of fun3={0}", A.fun3());

            clsB B = new clsB();
            Console.WriteLine("\nObjects from class B expose all public members from the base class");
            Console.WriteLine("x1={0}", B.x1);
            Console.WriteLine("result of fun1={0}", B.fun1());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2={0}", B.x2);
            // Console.WriteLine("result of fun1={0}", B.fun2());

            //you cannot access protected members in the folling line.
            // Console.WriteLine("x3={0}", B.x3);
            //Console.WriteLine("result of fun3={0}", B.fun3());

            Console.ReadKey();
        }
    }
}
