using System;

class Lab01_05
{
    static void Main()
    {
        // Ввод радиуса R и количества выстрелов
        Console.Write("Введите радиус R мишени: ");
        double R = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество выстрелов: ");
        int numShots = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        for (int i = 0; i < numShots; i++)
        {
            // Генерация случайных координат выстрела (x, y)
            double x = random.NextDouble() * 2 * R - R; // диапазон от -R до R
            double y = random.NextDouble() * 2 * R - R; // диапазон от -R до R

            Console.WriteLine($"Выстрел {i + 1}: Точка ({x:F2}, {y:F2})");

            // Проверка попадания в третью четверть круга
            bool inThirdQuadrant = (x <= 0 && y <= 0 && (x * x + y * y <= R * R));

            // Проверка попадания во вторую четверть круга (сектор)
            bool inSecondQuadrant = (x <= 0 && y >= 0 && (x * x + y * y <= R * R) && y >= -x);

            // Сообщение о попадании
            if (inThirdQuadrant || inSecondQuadrant)
            {
                Console.WriteLine("Попадание в мишень!");
            }
            else
            {
                Console.WriteLine("Промах.");
            }

        }
        Console.ReadLine();
    }
}