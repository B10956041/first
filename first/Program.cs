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

            //int[] a = new int[5];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write("請輸入a[" + i + "]的數字:");
            //    string b = Console.ReadLine();
            //    a[i] = int.Parse(b);
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //Array.Resize(ref a, 10);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write("請輸入a[" + i + "]的數字:");
            //    string b = Console.ReadLine();
            //    a[i] = int.Parse(b);
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


           

            try
            {
                int[] Num = { 1, 2, 3, 4, 5 };
                String[] StudentName = { "Jack", "Marry", "Tom", "Grace", "Alice" };
                int[] Computer = { 80, 65, 100, 98, 63 };
                int[] Program = { 75, 67, 93, 25, 82 };
                int[] Animation = { 60, 62, 91, 50, 87 };

                Console.Write("請輸入學生座號:");
                string num = Console.ReadLine();
                int StudentNum = int.Parse(num);

                for (int i = 1; i <= StudentNum; i++)
                {
                    if (i == StudentNum)
                    {
                        Console.WriteLine("姓名:" + StudentName[i - 1]);
                        Console.WriteLine("電腦概論:" + Computer[i - 1]);
                        Console.WriteLine("程式設計:" + Program[i - 1]);
                        Console.WriteLine("動畫設計:" + Animation[i - 1]);
                    }
                }
            }

            catch
            {
                Console.WriteLine("沒有這個座號");
            }






        }
    }
}
