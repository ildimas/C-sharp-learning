using System.Linq;
class Programm
{
    static void Main(string[] args)
    {  
        //! Цикл for 
        // {
        //     // Stopwatch stopwatch = new Stopwatch();

        //     // stopwatch.Start();

        //     for (short i = 1; i > 0 ; i++)
        //     //! данный код следует интерапритировать так:
        //     //! пока i больше 0 прибавляй + 1 за каждую иттерацию 
        //     {
        //         Console.WriteLine($"Значение {i}");
        //     }
        //     // stopwatch.Stop();
        //     // Console.WriteLine(stopwatch.ElapsedMilliseconds);
        // }
        //! Цикл while
        // {
        //     int counter = 0;
        //     while (counter < 10)
        //     {
        //         Console.WriteLine($"Значение counter = {counter}");
        //         counter += 2;
        //     }
        // }
        //! Бесконечный цикл с прерыванием
        // {
        //     int counter = 0;
        //     while (true)
        //     {
        //         Console.WriteLine(counter);
        //         counter += 1;
        //         if (counter >= 12)
        //         {
        //             break;
        //         }
        //     }
        // }
        //! опреатор continue
        // {
        //     for (int i = 0; i < 100; i++)
        //     {
        //         if (i % 2 == 0)
        //         {
        //            Console.WriteLine($"Число четное {i}");
        //         }
        //         else
        //         {
        //             continue;
        //         }
        //     }
        // }
        //! пирамида
        Console.WriteLine("Введите количество уровней пирамиды");
        int levels = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите шаг между дисками (нечетное число)");
        int step = int.Parse(Console.ReadLine());
        if (step % 2 != 0)  
        {
            Console.WriteLine("Все в порядке");
        }
        else
        {
            Console.WriteLine("Число не является нечетным !!!");
        }            
        int ground = (step * 2) * levels;
        int step_n = step;
        for (int i = 0; i < levels; i++)
        {
            // Console.WriteLine($"уровень {i} ");
            string output_center = string.Concat(Enumerable.Repeat($"{9}", step_n));
            int unused_space = ground - output_center.Length;
            if (unused_space == 0)
            {
                break;
            }
            string output_left = string.Concat(Enumerable.Repeat(" ", unused_space / 2));
            string ountput_right = string.Concat(Enumerable.Repeat(" ", unused_space / 2));
            string main = output_left + output_center + ountput_right;
            Console.WriteLine(main);
            step_n = step_n + step * 2;
        }
    }   
}