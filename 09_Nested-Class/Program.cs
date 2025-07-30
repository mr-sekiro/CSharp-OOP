namespace _09_Nested_Class
{
    //class within another class. It is known as a nested class
    //defining an object of another class inside this class is called composition.
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 [Nested Class]

            OuterClass outer1 = new OuterClass(42);

            OuterClass.InnerClass inner1 = new OuterClass.InnerClass(100);

            outer1.OuterMethod(); // prints "Outer method called."
            inner1.InnerMethod(); // prints "Inner method called with innerVariable = 100"
            inner1.AccessOuterVariable(outer1); // prints "Accessing outerVariable from inner class: 42" 

            #endregion

            #region Example 2 [Composition Class]
            clsA ObjectA1 = new clsA();
            ObjectA1.Method1();
            ObjectA1.Method2();
            #endregion

            Console.ReadKey();
        }
    }
}
