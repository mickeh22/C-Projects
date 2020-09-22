using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            /*This is my first project ever in C# and i hope you who looks at this
             * May find it helpful in your own learning as well.
             * 
             * 
             * 
             * 
             */

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "Hello and welcome to my first programming project i C#!";

            Console.SetCursorPosition(45, 15);
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Console.WriteLine("How's it going?");
            Console.WriteLine();
            Console.WriteLine("You know, unemployed just messing around with programming!");
            Console.ReadKey();
            Console.Write("Well shit man, that sucks, but it's good that you are learning!");

            Console.ReadKey();
            Console.Beep(300, 1000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("This is my second screen showing");
            Console.ReadKey();

            Console.Write("OH! And sorry for the beep");

            Console.ReadKey();


        }
    }
}
