using System;6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] цены = new int[15];        
            for (int i = 0; i < цены.Length; i++)
            {
                цены[i] = rnd.Next(20, 301);
            }    
            Console.WriteLine("Цены на товары:");
            for (int i = 0; i < цены.Length; i++)
            {
                Console.WriteLine($"{i + 1}-й товар: {цены[i]} руб.");
            }
            int минЦена = цены[0];
            int индексМин = 0;
            for (int i = 1; i < цены.Length; i++)
            {
                if (цены[i] < минЦена)
                {
                    минЦена = цены[i];
                    индексМин = i;
                }
            }
            Console.WriteLine($"Самый дешевый товар: {индексМин + 1}-й, цена: {минЦена} руб.");
            Console.ReadKey();
        }
    }
}