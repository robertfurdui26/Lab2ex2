using System;

namespace Lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 2: Scrieti un program care va afisa factorialul unui numar n, n fiind citit
            de la tastatura.*/

            Console.WriteLine("FACTORIAL");
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for(int i = n; i >= 1; i--)
            {
                factorial *= i; //inmulteste cu fiecare numar
            }
            Console.WriteLine("Factorialul din " + n + " Este " + factorial);
        }
    }
}