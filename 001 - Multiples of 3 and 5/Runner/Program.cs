using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter maximum number: ");
            var max = Console.ReadLine();

            var engine = new CalculatorEngine(int.Parse(max));
            var multiples = engine.GetMultiplesOf(3, 5);
            var sum = engine.GetSumMultiplesOf(3, 5);

            Console.WriteLine("Numbers: ");
            multiples.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Sum: " + sum.ToString());

            Console.ReadKey();
        }
    }
}
