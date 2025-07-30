using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Nested_Class
{
    internal class OuterClass
    {
        private int outerVariable;

        public OuterClass(int outerVariable)
        {
            this.outerVariable = outerVariable;
        }

        public void OuterMethod()
        {
            Console.WriteLine("Outer method called.");
        }

        public class InnerClass
        {
            private int innerVariable;


            public InnerClass(int innerVariable)
            {
                this.innerVariable = innerVariable;
            }

            public void InnerMethod()
            {
                Console.WriteLine("Inner method called with innerVariable = " + innerVariable);
            }


            public void AccessOuterVariable(OuterClass outer)
            {
                Console.WriteLine("Accessing outerVariable from inner class: " + outer.outerVariable);
            }
        }
    }
}
