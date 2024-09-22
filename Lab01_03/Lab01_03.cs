using System;

class Lab01_03

{
    static void Main()
    {
        // Ввод координаты точки и радиус
        Console.Write("Введите х-координату точки: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите у-координату точки: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите радиус R: ");
        double R = Convert.ToDouble(Console.ReadLine());

        // Проверяем, находится ли точка внутри четверти окружности в третьем квадранте
        bool inThirdQuadrant = (x <= 0 && y <= 0 && (x * x + y * y <= R * R));

        // Проверяем, находится ли точка внутри заштрихованной области во втором квадранте
        bool inSecondQuadrant = (x <= 0 && y >= 0 && (x * x + y * y <= R * R) && y >= -x);

        
        if (inThirdQuadrant || inSecondQuadrant)
        {
            Console.WriteLine("Точка принадлежит заштрихованной области.");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит заштрихованной области\r\n.");
        }
        Console.ReadLine();
    }
}
