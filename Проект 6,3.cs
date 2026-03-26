using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] массив = new int[20];
            
            for (int i = 0; i < массив.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                массив[i] = int.Parse(Console.ReadLine());
            }            
            int сумма = 0;
            
            for (int i = 0; i < массив.Length; i++)
            {
                if (i % 2 == 1 && массив[i] < 0)
                {
                    сумма += массив[i];
                }
            }          
            Console.WriteLine($"Сумма отрицательных элементов на нечетных местах: {сумма}");
            Console.ReadKey();
        }
    }
}