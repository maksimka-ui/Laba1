using System;

class Lab01_04
{
    static void Main()
    {
        Console.WriteLine("Задание № 4");

        // Ввод данных
        Console.Write("Введите начальное значение x: ");
        double xStart = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение x: ");
        double xEnd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество разбиений: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double step = (xEnd - xStart) / n;

        // Выводим заголовок таблицы
        Console.WriteLine("Таблица значений функции y = f(x)");
        Console.WriteLine(" x\t\t f(x)");
        Console.WriteLine("------------------------");

        for (int i = 0; i <= n; i++)
        {
            double x = xStart + i * step;
            double y = CalculateFunction(x);

            // Выводим x и f(x)
            Console.WriteLine($"{x:F3}\t\t {y:F3}");
        }
        Console.ReadLine();
    }

    static double CalculateFunction(double x)
    {
        // Определяем значение функции в зависимости от участка
        if (x >= -7 && x <= -5)
        {
            return 1;  // Первый участок: горизонтальная линия
        }
        else if (x > -5 && x <= -3)
        {
            // Линейная функция на отрезке [-5, -3]
            // Уравнение прямой: y = (x + 5) / 2 + 1
            return (x + 5) / 2 + 1;
        }
        else if (x > -3 && x <= 0)
        {
            // Окружность с радиусом R2
            // Уравнение окружности: (x + 1)^2 + (y - 1)^2 = R2^2
            double R2 = 2;
            return Math.Sqrt(R2 * R2 - (x + 1) * (x + 1)) + 1;
        }
        else if (x > 0 && x <= 1)
        {
            // Окружность с радиусом R1
            double R1 = 1;
            return -Math.Sqrt(R1 * R1 - (x - 1) * (x - 1));
        }
        else if (x > 1 && x <= 2)
        {
            // Линейная функция на отрезке [1, 2]
            return -x + 1;
        }

        // Если x не попадает ни в один из диапазонов, возвращаем 0
        return 0;
    }
}
