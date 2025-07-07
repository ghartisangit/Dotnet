using System;

/* Method overloading is a feature in oop that allows multiple methods in the same class to have the same name but different parameters (static and compile time polymorphism)*/
// Features of it:
//Same method name : All overloaded method share same name
// different parameter : Method differ by the number, type or order of their parameter
//compile time polymorphism  : The method to call is determined at compile time 
//return type irrevelant: Overloading is not dependent on the return type of methods


namespace Method_Overloading
{
    internal class Program
    {

        public class Calculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
           
            public int Add(int x, string y)
            {
                return x + int.Parse(y);
            }

            public double Add(double x, double y)
            {
                return x + y;
            }
            public int Add(float x, float y)
            {
                return Convert.ToInt32(x + y);
            }

            public int Add(int x, int y, int z)
            {
                return x + y + z;
            }
        }


        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"The sum of two number is {calculator.Add(5, 6)}");
            Console.WriteLine($"The sum of two number is {calculator.Add(53D, 6D)}");
            Console.WriteLine($"The sum of two number is {calculator.Add(5.7F, 6.5F)}");
            Console.WriteLine($"The sum of three number is {calculator.Add(5, 6, 3)}");
            Console.WriteLine($"The sum of string number is {calculator.Add(5, "123")}");
        }

    }
}
