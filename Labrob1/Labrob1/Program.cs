using System;

namespace Labrob1
{
    class Program
    {

        delegate int Avarage(int a, int b, int c);
        static void Main(string[] args)
        {
            Avarage avg = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };

            var avarage = avg(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Середнье арифметичне дорівнює " + avarage);
        }
    }
}
