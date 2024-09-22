using System;

class Lab01_01
{
    static void Main()
    {
        Console.WriteLine("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4)) / Math.Sqrt(Math.Pow(b, 2) - 4 + b + 2);
        double z2 = 1 / (Math.Sqrt(b + 2));
        Console.WriteLine("Думаю правильно посчитал :) ");
        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
        Console.ReadLine();
    }
    
}
