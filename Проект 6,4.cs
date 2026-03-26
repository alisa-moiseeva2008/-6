using System;
class Program
{
    static void Main(string[] args)
    {
        int[] массив = new int[17];
        for (int i = 0; i < массив.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            массив[i] = int.Parse(Console.ReadLine());
        }
        int сумма = 0;
        int количество = 0;

        foreach (int элемент in массив)
        {
            if (элемент > 0 && элемент % 2 != 0)
            {
                сумма += элемент;
                количество++;
            }
        }
        double среднее = (double)сумма / количество;
        Console.WriteLine($"Среднее значение нечетных положительных элементов: {среднее:F2}");
        Console.ReadKey();
    }
}
