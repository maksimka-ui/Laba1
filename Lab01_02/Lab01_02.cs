using System;

class Lab01_02
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        // Переменная для результата 
        double y = 0;

        //Условия для различных участков функции 
        if (x >= -7 && x <= -6)
        {
            y = 2;

        }
        else if (x > -6 && x <= -4)
        {
            //Линейная функция на участке [-6,-4]
            //Определяем угловой коэффицент и сдвиг 
            y = (0.5 * x) + 5; //Примерное выражение
        }
        else if (x > -4 && x <= 0)
        {
            //Верхняя полусфера окружности с центром в (-2,0) и радиусом 2 
            y = Math.Sqrt(4 - Math.Pow(x + 2, 2));
        }
        else if (x > 2 && x <= 3)
        {
            //Линейная функция на участке [2,3]
            y = -x + 3;
        }
        else
        {
            Console.WriteLine("Значение х вне допустимого диапазона");
            return;
        }



        Console.WriteLine($"Значение функции у при х = {x} равно {y}");



        Console.ReadLine();

    }

}