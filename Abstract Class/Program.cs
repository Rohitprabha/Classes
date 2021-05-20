using System;

namespace Abstract_Class
{
    abstract class Animal
    {
        public abstract void animalSound();         // Abstract method (does not have a body)
        public void sleep()                         // Regular method
        {
            Console.WriteLine("boww");
        }
    }
    class Dog : Animal                                 // Derived class (inherit from Animal)
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says: boww boww");         // The body of animalSound() is provided here
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();                    //cannot create an object for abstract class
            Dog myDog = new Dog();
            myDog.animalSound();
            myDog.sleep();
        }
    }
}
