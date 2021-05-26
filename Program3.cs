using System;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] qw = { 2, -1, 4, 4, 3, -9, 8, 24 };
            int vn = 0;

            for (int i = 0; i < qw.Length; i++)
            {
                vn = Math.Abs(qw[i]);
                if (Math.Abs(Convert.ToInt32(qw[i])) > vn)
                {
                    vn = Math.Abs(Convert.ToInt32(qw[i]));
                    Console.WriteLine("Минимальный элемент массива " + vn);
                }
            }

            //2
            int a = 4;
            int[] masd = { 1, 7, 7, 5 };
            for (int i = 0; i < a; i++)
            {
                int yyt = masd[i];
                bool hasEquals = false;
                for (int r = 0; r < a; r++)
                {
                    if (i == r)
                    {
                        continue;
                    }
                    if (yyt == masd[r] && i != r)
                    {
                        hasEquals = true;
                    }
                }
                if (!hasEquals)
                {
                    Console.WriteLine("Уникальный элемент: " + yyt);
                }
            }

            //3
            int[] fewf = new int[9];
            Random rand = new Random();

            for (int i = 0; i < fewf.Length; i++)
            {
                int aa = rand.Next(-10, 10);
                int b = rand.Next(10);
                fewf[i] = aa + b;
                Console.WriteLine("Случайные числа" + fewf[i]);
            }
        }
    }
}
    

