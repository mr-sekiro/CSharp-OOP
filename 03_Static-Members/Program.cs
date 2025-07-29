namespace _03_Static_Members
{
    //Static members are class-level members that belong to the class itself, not to any specific object (instance). They are shared across all instances of the class.
    //Static Fields – one copy shared by all objects.
    //Static Methods – can be called without creating an object.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Employee class.
            clsA objA1 = new clsA();
            clsA objA2 = new clsA();


            objA1.x1 = 7;
            objA2.x1 = 10;
            //x2 is shared for all object because it's on the class level, you can access it 
            //using the class name.
            clsA.x2 = 100;


            Console.WriteLine("objA1.x1:={0}", objA1.x1);
            Console.WriteLine("objA2.x1:={0}", objA2.x1);
            Console.WriteLine("objA1.method1 results:={0}", objA1.Method1());
            Console.WriteLine("objA2.method1 results:={0}", objA2.Method1());


            //Method 2 cannot be accessed through object, only through the class itself.
            //Console.WriteLine(objA1.Method2());
            Console.WriteLine("static method2 results:={0}", clsA.Method2());

            Console.WriteLine("static x2:={0}", clsA.x2);

            Console.ReadKey();
        }
    }
}
