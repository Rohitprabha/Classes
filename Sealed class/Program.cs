using System;

namespace Sealed_Classes
{
    sealed class SealedClass                                // Sealed class 
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    //class DerivedClass : SealedClass                        //'DerivedClass': cannot derive from sealed type 'SealedClass'
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
}
