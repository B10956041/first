using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            int total = (int)meal_cost+tip_percent+tax_percent;
            Console.WriteLine("用餐總費用:"+total);
        }
    }
}
