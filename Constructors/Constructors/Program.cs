using System;

namespace Constructors
{
    public class Person
    {
        public string Name;
        public int Age;
        public static string Category;

        public Person()  //Default constructor
        {
            Name = "unknown";
            Age = 20;
           
        }

        public Person(string name, int age)    //parameterized constrcutor : it accepts the parameters to initialze the fields with specific values
        {
            Name = name;
            Age = age;
        }

        public Person(Person person)  //copy constructor: it creates a new object by copying the values of another object. it duplicate the object and 
        {                                   //takes an object of the same class as a prameter
            Name = person.Name;
            Age = person.Age;
        }

        static Person()    //static constructor: No parameters and no access modifier .. Called only once during the program's execution 
        {
            Category = "Human";
        }

        private Person(int age, string name)   //private constructor (used within the class only)  it cannot be instantiated from outside. Often used in singleton patterns
        {
            Name = name;
            Age = age;
        }


        //Factory method to create an object using the private constructor 
        public static Person CreateSpecialPerson(int age, string name)
        {
            return new Person(age, name);
        }

        public void Displayinfo()

        {
            Console.WriteLine($"My name is {Name} and age is {Age} and category is {Category}");
        }

        //In C#, a destructor is a special method
        ~Person()
        {
            Console.WriteLine("Bye");
        }
       
    }

    public class Program
    {
        public static void Main()
        {
            //Default constructor
            Person p1 = new Person();
            p1.Displayinfo();

            //Parameterized Constructor
            Person p2 = new Person("Sangit", 12);
            p2.Displayinfo();


            //Copy constructor  
            Person p3 = new Person(p2);
            p3.Displayinfo();    //Output will be sangit and 12 cuz it take the object of p2 as a parameter.  it act as a independent 


            //static constructor(
            Console.WriteLine($"Category from static constructor : {Person.Category}");

            //factory method
            Person p4 = Person.CreateSpecialPerson(100, "Special");
            p4.Displayinfo();

        }
    }
}
