class Programm
{
    static void Main(string[] args)
    {
        //! массивы
        // {
        //     string[] listik = new string[1000];
        //     for (int i = 0; i < 1000; i++)
        //     {
        //         listik[i] = $"{i}";
        //     }
        //     Console.WriteLine(listik[89]);
        // }
        //! Обработка студентов
        // Console.WriteLine("Укажите кол-во студентов: ");
        // int students_count = int.Parse(Console.ReadLine());
        // string[] main_list = new string[students_count];
        // for (int i = 0; i < students_count; i++)
        // {
        //     Console.WriteLine("Укажите имя студента: ");
        //     string students_name = Console.ReadLine();
        //     Console.WriteLine("Оценку студента: ");
        //     int students_mark = int.Parse(Console.ReadLine());
        //     string main_info = $"Имя: {students_name}, оценка: {students_mark}";
        //     main_list[i] = main_info;
        // }
        // for (int a = 0; a < students_count; a++)
        // {
        //     Console.WriteLine(main_list[a]);
        // }
        //! Строка - список
        // {
        //     string s = "Абу-даби";
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         Console.WriteLine(s[i]);
        //     }
        // }
        //! Цикл foreach
        // {
        //     int[] list = {1, 2, 3, 4, 5, 6, 7};
        //     foreach (int x in list)
        //         Console.WriteLine(x * x);
        // }
        //! Максимально значение в списке
        // {
        //     int[] list = {12, 34, 56, 0, -33, 105, 564, 100};
        //     int max_num = int.MinValue;
        //     foreach (int a in list)
        //     {
        //         if (max_num < a)
        //         {
        //             max_num = a;
        //         }
        //     }
        //     Console.WriteLine($"Максимальное число: {max_num}");
            
        // }
        //! двумерный список
        // int[,] list = new int[3, 3];

        // Random random = new Random();

        // for (int a = 0; a < 3; a++)
        // {
        //     for (int b = 0; b < 3; b++)
        //     {
        //         list[a, b] = random.Next(1, 15);
        //         Console.WriteLine("{0}\t", list[a, b]);
        //     }
        //     Console.WriteLine();
        // }
        // {
        //     char[] list = {'а', 'б'};
        //     string a = Console.ReadLine();
        //     if (list.Contains(a))
        //     {
        //         Console.WriteLine("на месте");
        //     }
        // }
        string[] array = {"12", "24", "3", "2"};
        for (int i = 0; i < array.Length; i++)
        {
            for (int n = 0; n < array.Length - 1; n++)
            {
                if (int.Parse(array[n]) > int.Parse(array[n+1]))
                {
                    var buffer = array[n];
                    array[n] = array[n+1];
                    array[n+1] = buffer;
                }
            }
  
        }
        string answ = $"{array[0]}";
        for (int a = 1; a < array.Length; a++)
        {
            answ += $" {array[a]}";
        }    
        Console.WriteLine(answ);
        
    }   
}