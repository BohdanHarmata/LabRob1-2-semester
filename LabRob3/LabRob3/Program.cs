using System;

namespace LabRob3
{
    class Program
    {
        delegate int One (int x);
        delegate int Two(int y);
        delegate int Three(int z);
        delegate int Avarage (ref int []arr);

        static void Main(string[] args)
        {
            One one = delegate (int x)
            {
                return x;
            };
            Two two = delegate (int y)
            {
                return y;
            };
            Three three = delegate (int z)
            {
                return z;
            };
            Random r = new Random();
            var x = one(r.Next());
            var y = two(r.Next());
            var z = three(r.Next());


            int[] array = new int[] { x, y, z };
            for (int i = 0; i < array.Length; i++) 
            {

                Console.WriteLine(" Число в массиві " + array[i]);
            }
 
            Avarage arr = delegate (ref int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int avg = (array[i] + array[i+1] + array[i+2]) / array.Length;
                    return avg;
                }
                return 0;
            };
            var avarage = arr(ref array);
            Console.WriteLine("Середнє арифметичне " + avarage);

        }
    }
}
