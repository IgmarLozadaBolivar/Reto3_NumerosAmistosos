using System;

namespace Reto3
{
    class NumerosAmistosos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Bienvenido a Numeros Amigos".ToUpper());
            Console.WriteLine("---------------------------\n");

            int startRange = 1000;
            int endRange = 1500;
            bool seEncuentra = false;

            for (int m = startRange; m <= endRange && !seEncuentra; m++)
            {
                int n = SumDivisors(m);
                if (n > m && n <= endRange && SumDivisors(n) == m)
                {
                    Console.WriteLine($"El par amigable es ({m}, {n})");
                    seEncuentra = true;
                }
            }
        }

        static int SumDivisors(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}