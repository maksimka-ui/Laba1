using System;

class TaylorSeriesTable
{
    static void Main(string[] args)
    {
        // Ввод данных от пользователя
        Console.Write("Введите начальное значение отрезка: ");
        double start = double.Parse(Console.ReadLine());

        Console.Write("Введите конечное значение отрезка: ");
        double end = double.Parse(Console.ReadLine());

        Console.Write("Введите количество точек для деления отрезка: ");
        int numPoints = int.Parse(Console.ReadLine());

        Console.Write("Введите требуемую точность: ");
        double precision = double.Parse(Console.ReadLine());

        // Вычисление и вывод таблицы значений функции
        Table(start, end, numPoints, precision);
    }

    static void Table(double start, double end, int numPoints, double precision)
    {
        double step = (end - start) / (numPoints - 1);

        Console.WriteLine("\nТаблица значений функции sin(x)/x:");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("|    x    |   sin(x)/x  |");
        Console.WriteLine("---------------------------------");

        for (int i = 0; i < numPoints; i++)
        {
            double x = start + i * step;
            double value = Taylor(x, precision);
            Console.WriteLine($"| {x,7:F4} | {value,10:F6} |");
        }

        Console.WriteLine("---------------------------------");
    }

    static double Taylor(double x, double precision)
    {
        // Если x = 0, sin(x)/x = 1 по определению
        if (x == 0)
            return 1;

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