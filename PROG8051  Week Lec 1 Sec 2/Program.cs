using System;


namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            // More about numbers
            int a = 13;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b); // modulus - returns the remainder
            Console.WriteLine(++a);
            Console.WriteLine(--b);

            // Comparison

            Console.WriteLine(a != b); // > < >= <= !=

            // Logical operators
            Console.WriteLine(a > b && a > 5); // and
            Console.WriteLine(a < b || a > 5); // or

            // More about strings
            // 1st - length of the string

            string classname = "PROG 8051";
            Console.WriteLine(classname.Length);

            // 2nd - accessing individual characters of the string

            Console.WriteLine(classname[classname.Length-2]);


            // Substring method
            Console.WriteLine(classname.Substring(4));

            Console.WriteLine(classname.Substring(2,5));

            // Conversion
            double age1 = 34.5;
            Console.WriteLine(age1.GetType());

            // int/double to string
            
            Console.WriteLine(Convert.ToString(age1).GetType());

            string age2 = "23";
            Console.WriteLine(age2.GetType());
            Console.WriteLine(Convert.ToInt32(age2).GetType());


            // Read from a line
           // string name1 = Console.ReadLine();
           // Console.WriteLine(name1);


            // Little example
            Console.WriteLine("please enter your name");
            string fname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("please enter your year of birth");
            string year1 = Console.ReadLine();

            int age = 2024 - Convert.ToInt32(year1);


            Console.WriteLine(fname[0] +"." +lname + "@gmail.com");

            // Interpolation

            string result = $"{fname[0]}.{lname}@gmail.com";

            Console.WriteLine(result);

            // Variables and Data Types
            // integer data type = a whole number
            int age = 25;

            // douoble - stores decimal numbers
            double weight = 8.5;

            // String - stores text

            string name = "sdalkajdhaskjd";

            // Char - char is used to stoe a single character

            char firstletter = 'A';

            // boolean - true/false

            bool result1 = true;
            // How to create a variable

            int year = 2024;

            Console.WriteLine(year);
            year = 2023;
            Console.WriteLine(year);
            // How to write to the Console.
            Console.WriteLine("Hello World  ");

            Console.Write("Hello World  1");

            Console.WriteLine("Hello World  2");

            // Single line comment
            // What is a comment, how to create one
            
            // Multi line comment
            /*
            Console.Write("Hello World  1");

            Console.WriteLine("Hello World  2");
            */
        }
    }
}