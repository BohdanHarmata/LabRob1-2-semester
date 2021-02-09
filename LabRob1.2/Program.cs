using System;

namespace LabRob1._2
{
    class Program
    {
        delegate int Calculate(int x, int y);
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
                    return x + y;
                }
                else
                {
                    return 0;
                }
            };
            Console.WriteLine("Виберіть операцію");
            string operation = Console.ReadLine();
            if (operation == "Add")
            {
                Console.WriteLine("Відповідь:" + Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            }
            else if(operation == "Sub")
            {
                Console.WriteLine("Відповідь:" + Sub(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            }
            else if (operation == "Mult")
            {
                Console.WriteLine("Відповідь:" + Mult(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            }
            else if (operation == "Div")
            {
                Console.WriteLine("Відповідь:" + Div(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            }
        }
    }
}
