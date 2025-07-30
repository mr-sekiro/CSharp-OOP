namespace _11_Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class
            ////There are many situations when you might need to split a class definition, such as when working on a large scale projects.
            ////multiple developers and programmers might need to work on the same class at the same time.In this case we can use a feature called Partial Class.
            ////we can split the definition of a class over two or more source files.

            ////the code of MyClass is seperated in 2 files class1.cs and class2.cs
            //MyClass obj = new MyClass();
            //obj.Method1();
            //obj.Method2();
            #endregion

            #region Partial Methods
            //Partial methods are a feature in C# that allow you to declare a method in one part of a partial class, but provide its implementation in another part of the same class.
            //Partial methods are optional, and you can use them when you want to allow other parts of your code to optionally provide an implementation for a specific method.
            //Things to remember about Partial Method:
            //partial keyword.
            //return type void.
            //implicitly private.
            //and cannot be virtual.
            MyClass obj = new MyClass();
            obj.Age = 25;
            obj.PrintAge(); //  
            #endregion

            Console.ReadKey();
        }
    }
}
