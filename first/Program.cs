using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("請輸入要印的N:");
            //string a = Console.ReadLine();
            //int N = int.Parse(a);

            //for (int i = 1; i <= N; i++)
            //{
            //    for (int y = 1; y <= i; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine(N + "*" + i + "=" + N * i);
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        Console.Write(i + "*" + y + "=" + i * y + " ");
            //    }
            //    Console.WriteLine();
            //}

            int[] a = new int[5];

            for(int i =0; i<a.Length;i++)
            {
                Console.Write("請輸入a[" + i + "]的數字:");
                string b = Console.ReadLine();
                a[i] = int.Parse(b);
               
            }

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);


        }
    }
}
