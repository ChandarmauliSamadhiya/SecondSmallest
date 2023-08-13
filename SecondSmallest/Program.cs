using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSmallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 5, 30, 15 };
            Array.Sort(numbers);

            int secondSmallest = numbers[1];

            Console.WriteLine("Second smallest element: " + secondSmallest);
            Console.ReadLine();
        }
    }
}
