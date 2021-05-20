using System;

namespace StaticMembers
{
    public class Circle
    {
        static float _pi;
        int _Radius;
        static Circle()
        {
            _pi = 3.14F;
            Console.WriteLine("Static Constructor called");
        }
        public Circle(int Radius)
        {
            this._Radius = Radius;
            Console.WriteLine("Non-Static Constructor called");
        }
        public float CalculateArea()
        {
            return Circle._pi * this._Radius * this._Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Area = c1.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            Circle c2 = new Circle(6);
            float Area1 = c2.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);
        }
    }
}
