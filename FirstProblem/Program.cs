using System;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfMultiplesOfThreeOrFive(1000));
        }

        private static int SumOfMultiplesOfThreeOrFive(int n)
        {
            var total = 0;
            for (var i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
