using System;

namespace AreaCalculator
{
    class Calculator
    {
        static void Main()
        {

            Console.Write("Input the lenght of the Triangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the height of the Triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * length * height;
            Console.WriteLine($"A triangle that has a length of {length} and an height of {height} have an area of: {area}");

        }
    }
}