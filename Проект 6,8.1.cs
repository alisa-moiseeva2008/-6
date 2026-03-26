using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double[] массив = new double[n];
        int знак = 1;
        for (int i = 1; i <= n; i++)
        {
            массив[i - 1] = знак * (1.0 / i);
            знак = -знак;
        }
        double сумма = 0;
        foreach (double элемент in массив)
        {
            сумма += элемент;
        }
        Console.WriteLine($"Сумма = {сумма:F4}");
        Console.ReadKey();
    }
}
