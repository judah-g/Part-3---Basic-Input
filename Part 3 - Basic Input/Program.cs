using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //judah
            //age

            string name;
            int age = 0, year = DateTime.Now.Year;

            Console.WriteLine("whats your name?");
            name = Console.ReadLine();
            Console.WriteLine($"your name is {name.ToUpper()}???");

            Console.WriteLine();
            Console.WriteLine("HOW OLD ARE YOU?");
            while (age == 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out age))
                { Console.WriteLine($"if you are {age} you were born in {year - age}"); }
                else { Console.WriteLine("thats not an age"); }
            }

            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            //addition

            int num1 = 0, num2 = 0, num3 = 0;

            Console.Write("give me a number\t\t");

            while (num1 == 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out num1))
                { Console.Write("give me another\t\t"); }
                else { Console.WriteLine("thats not a number"); }
            }

            while (num2 == 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out num2))
                { Console.Write("give me one more\t\t"); }
                else { Console.WriteLine("thats not a number"); }
            }

            while (num3 == 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out num3))
                { Console.Write($"your total is {num1 + num2 + num3}"); }
                else { Console.WriteLine("thats not a number"); }
            }

            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            //distance

            double dist1 = 0, dist2 = 0, dist3 = 0;

            Console.Write("give me a distance in km\t");

            while (dist1 == 0)
            {
                if (double.TryParse(Console.ReadLine(), out dist1))
                { Console.Write("give me another\t\t"); }
                else { Console.WriteLine("thats not a number"); }
            }

            while (dist2 == 0)
            {
                if (double.TryParse(Console.ReadLine(), out dist2))
                { Console.Write("give me one more\t\t"); }
                else { Console.WriteLine("thats not a number"); }
            }

            while (dist3 == 0)
            {
                if (double.TryParse(Console.ReadLine(), out dist3))
                { Console.Write($"your average is {((dist1 + dist2 + dist3) / 3).ToString("0.00")}"); }
                else { Console.WriteLine("thats not a number"); }
            }

            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            //pythagorean

            double side1 = 0, side2 = 0;

            Console.WriteLine("i'm making a right triangle, give me a side length");

            while (side1 == 0)
            {
                if (double.TryParse(Console.ReadLine(), out side1))
                { Console.WriteLine("give me another"); }
                else { Console.WriteLine("thats not a number"); }
            }

            while (side2 == 0)
            {
                if (double.TryParse(Console.ReadLine(), out side2))
                { Console.Write($"the hypotenuse would be {Math.Sqrt(side1 * side1 + side2 * side2).ToString("0.00")}"); }
                else { Console.WriteLine("thats not a number"); }
            }

            System.Threading.Thread.Sleep(3000);
        }
    }
}
