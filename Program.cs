using System;

namespace DZ_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now.ToString(" dd MMMM yyyy ")}]");
            Console.ReadKey();
        }
    }
}
