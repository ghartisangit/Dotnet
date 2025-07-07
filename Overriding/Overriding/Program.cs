using System;

//overriding occur when a subclass provide a specific implementaiton for a method that is already defined in its base class. 
//The base method must be marked as virtual and the overriding method in the subclass must use the iverride keyword.

//the  base class method must be marked with virtual or abstract
//The derived class method must use the override keyword 


namespace Overriding
{

    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal can speak");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog bark");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Animal dog= new Dog(); //animal ley child class ko refernce leko cha
            //overriding the action. this is the actual overriding
            dog.Speak();

            Dog dog1 = new Dog();
            dog1.Speak();
        }
    }
}
