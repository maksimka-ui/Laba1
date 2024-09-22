using System;

class Lab01_06
{
    static void Main(string[] args)
    {
        // Ввод данных от пользователя
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите требуемую точность: ");
        double precision = double.Parse(Console.ReadLine());

        // Вычисление суммы ряда Тейлора
        double sum = Taylor(x, precision);

        // Вывод результата
        Console.WriteLine($"Сумма ряда Тейлора для sin(x)/x равна: {sum}");

        Console.ReadLine();
    }

    static double Taylor(double x, double precision)
    {
        double term = 1;  // Первый член ряда равен 1
        double sum = term;
        int n = 1;

        // Вычисление следующих членов ряда до достижения нужной точности
        while (Math.Abs(term) > precision)
        {
            term *= -x * x / ((2 * n) * (2 * n + 1));
            sum += term;
            n++;
        }

        return sum;
    }
}