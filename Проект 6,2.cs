using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] массив = new double[8];            
            for (int i = 0; i < массив.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                массив[i] = double.Parse(Console.ReadLine());
            }           
            double сумма = 0;
            int количество = 0;          
            foreach (double элемент in массив)
            {
                if (элемент > 0)
                {
                    сумма += элемент;
                    количество++;
                }
            }         
            double среднее = сумма / количество;
            Console.WriteLine($"Среднее арифметическое положительных элементов: {среднее:F2}");
            Console.ReadKey();
        }
    }
}