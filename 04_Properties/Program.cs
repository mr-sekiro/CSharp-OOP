namespace _04_Properties
{
    //properties are special members that provide a controlled way to access private fields using get (to read) and set(to write)
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee1 = new clsEmployee();
            //Employee1.ID = 7; // You cannot modify the id value because it's readonly
            Employee1.Name = "Abdullah Hussein";
            Employee1.Salary = 10000;
            Console.WriteLine("Employee Id:={0}", Employee1.ID);
            Console.WriteLine("Employee Name:={0}", Employee1.Name);
            Console.WriteLine("Employee Salary:= {0}", Employee1.Salary);


            //**********************************************************//

            Console.WriteLine();
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
            Settings.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(Settings.ProjectPath);

            Console.ReadKey();
        }
    }
}
