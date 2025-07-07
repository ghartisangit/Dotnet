using System;

namespace Goto
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting main method");

            Console.WriteLine("\n Using goto statement");
            UseGoto();

            Console.WriteLine("\n Using break statement");
            UseBreak();

            Console.WriteLine("\n Using return statement");
            UseReturn();

            Console.WriteLine("\n Ending Main method");
        }

        public static void UseGoto()
        {
            int x = 5;
            if (x == 5)
            {
                goto skip;
            }
            Console.WriteLine("\n this will not be printed because x==5");
            
            skip:
                Console.WriteLine("\n exited the condition block using goto");
        }

        public static void UseBreak()
        {
            int y = 5;
            switch(y)
            {
                case 1:
                    Console.WriteLine("y is 1");
                    break;
                case 5:
                    Console.WriteLine(" y is 5");
                    break;
                default: 
                    Console.WriteLine("This is default");
                    break;
            }  
            Console.WriteLine("Exited the switch blcok using break");
        }

        public static void UseReturn()
        {
            int z = 5;
            if (z == 5)
            {
                return;
            }
            Console.WriteLine("This will not printed because z==5");
            Console.WriteLine("This line will never be reached if z==5");
        }

    }
}
