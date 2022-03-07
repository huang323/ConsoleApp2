using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int meal_costint = (int)meal_cost;
            int sum = meal_costint + tip_percent + tax_percent;
            Console.WriteLine($"用餐總費用:" + sum);


        }


    }
}
