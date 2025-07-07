using System;

//Inheritance us a fundamental concept of oop that allows one class 
//single , multiple, multi level, hybrid, hierarchical


namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            DerivedClass derivedclass = new DerivedClass();
            derivedclass.BaseMethod();
            derivedclass.DerivedMethod();

            MultipleInheritance multipleInheritance = new MultipleInheritance();  //multiple inheritance
            multipleInheritance.FirstMethod();
            multipleInheritance.SecondMethod();
        }
    }
    public class DerivedClass
    {
        public  void BaseMethod()
        {

        }
        public void DerivedMethod()
        {

        }
    }

    public class MultipleInheritance
    {
        public void FirstMethod()
        {

        }
        public void SecondMethod()
        {

        }
    }
}
