using System;

namespace Sealed_Method
{
    class Printer
    {
        public virtual void print()
        {
            Console.WriteLine("printer printing....\n");
        }
    }
    class Class1 : Printer
    {
        sealed override public void print()                                 // Sealed Display Functionto override Print() function
        {
            Console.WriteLine("Class1 printing....\n");
        }
    }
    //class Class2 : Class1
    //{
    //    override public void print()            // Class2 class cannot override print function as it is sealed in Class1 class.
    //    {
    //        Console.WriteLine("Class2 printing....");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.print();

            Printer c1 = new Class1();
            c1.print();

            //Printer c2 = new Class2();
            //c2.print();
        }
    }
}
