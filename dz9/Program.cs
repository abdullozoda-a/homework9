using System;

namespace dz9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double summa = 0.0;
            for (double i = n; i <= 2 * n; i++)
            { 
                summa += i * i;
            }
            Console.WriteLine($"Сумма будет {summa}");
        }
    }
}
