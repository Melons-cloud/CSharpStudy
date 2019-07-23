using System;
using System.Diagnostics;

namespace CsharpStudy
{
    public class Attribute
    {
        [Conditional("DEBUG")]

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Test
    {
        static void function1()
        {
            Attribute.Message("In Function 1.");
        }

        static void function2()
        {
            Attribute.Message("In Function 2.");
            
        }

        public static void Main()
        {
            Attribute.Message("In Main function.");
            function1();
            Console.ReadKey();
        }

    }
    
}