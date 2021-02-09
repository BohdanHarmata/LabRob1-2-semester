using System;

namespace LabRob1._2
{
    class Program
    {
        delegate double Calculate(double x, double y);
        static void Main(string[] args)
        {
            Calculate Add = (x, y) =>
            {
                return x + y;
            };
            Calculate Sub = (x, y) =>
            {
                return x - y;
            };
            Calculate Mult = (x, y) =>
            {
                return x * y;
            };
            Calculate Div = (x, y) =>
            {
                if (y != 0)
                {
                    return x / y;
                }
                else
                {
                    return 0;
                }
            };


            Console.WriteLine("Виберіть операцію(+, -, *, /)");
            string operation = Console.ReadLine();
            Console.WriteLine("Введіть два числа:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (operation == "+")
            {
                Console.WriteLine("Відповідь:" + Add(x, y));
            }
            else if(operation == "-")
            {
                Console.WriteLine("Відповідь:" + Sub(x, y));
            }
            else if (operation == "*")
            {
                Console.WriteLine("Відповідь:" + Mult(x, y));
            }
            else if (operation == "/")
            {
                if (Div(x, y) != 0)
                {
                    Console.WriteLine("Відповідь:" + Div(x, y));
                }else if(Div(x, y) == 0)
                {
                    Console.WriteLine("Помилка не можна ділити на нуль");
                }
            }
        }
    }
}
