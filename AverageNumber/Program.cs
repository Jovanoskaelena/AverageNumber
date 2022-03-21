using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double NumberOne, NumberTwo, NumberThree, NumberFour;
            Console.WriteLine("Enter the First Number:");
            NumberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            NumberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third Number:");
            NumberThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fourth Number:");
            NumberFour = Convert.ToDouble(Console.ReadLine());

            double average = (NumberOne + NumberTwo + NumberThree + NumberFour) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            NumberOne, NumberTwo, NumberThree, NumberFour, average);
            Console.ReadLine();
        }
    }
}
