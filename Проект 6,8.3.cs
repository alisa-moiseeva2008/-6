using System;
class Program
{
    static long Факториал(int k)
    {
        long результат = 1;
        for (int i = 2; i <= k; i++)
        {
            результат *= i;
        }
        return результат;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double[] массив = new double[n];

        for (int i = 1; i <= n; i++)
        {
            массив[i - 1] = 1.0 / Факториал(i);
        }
        double сумма = 1;
        foreach (double элемент in массив)
        {
            сумма += элемент;
        }
        Console.WriteLine($"Сумма = {сумма:F6}");
        Console.ReadKey();
    }
}
