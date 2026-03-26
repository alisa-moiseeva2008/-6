using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            
            double[] массив = new double[n];
            double степень = x;          
            for (int i = 1; i <= n; i++)
            {
                массив[i - 1] = степень / i;
                степень *= x * x;
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
}