using System;

namespace StaticClass
{
    public static class Circle
    {
        public static float _pi = 3.14F;
        public static int _Radius;                              //everything inside the static class must be static.
        public static float CalculateArea()
        {
            return Circle._pi * Circle._Radius * Circle._Radius;
        }
    }
    //class class1 : Circle                                     //error 'class1': cannot derive from static class 'Circle'
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            //We cannot create an object of the static class.
            Circle._Radius = 5;                             //methods of the static class can be called using the class name 
            Console.WriteLine(Circle.CalculateArea());
        }
    }
}
