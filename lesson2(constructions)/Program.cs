class Programm
{
    static void Main(string[] args)
    {
        //! 1) пример программы без условных конструкций
        // {
        //     Console.WriteLine("Введите первое слогаемое: ");
        //     int a = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Введите второе слогаемое: ");
        //     int b = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine($"{a} + {b} = {a + b}");
        // }  
        //! 2) условный оператор 
        // {
        //     Console.WriteLine("Сегодня солнечно Y/N/NS");
        //     var user_choise = Console.ReadLine();
        //     if (user_choise == "Y")
        //     {
        //         Console.WriteLine("Тогда я одену пляжную одежду");
        //     }
        //     else if (user_choise == "NS")
        //     {
        //         Console.WriteLine("Ладно услышал");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Тогда я оденусь теплее");
        //     }
        // }  
        //! Операторы сравнения
        {
            int a = 5, b = 6;
            Console.WriteLine($"{a} == {b} ? - " + (a == b));
            Console.WriteLine($"{a} != {b} ? - " + (a != b));
            Console.WriteLine($"{a} > {b} ? - " + (a > b));
            Console.WriteLine($"{a} < {b} ? - " + (a < b));

            //! работа условного оператора с типом данных string
            string name = "Александр";
            Console.WriteLine($"Тебя зовут Александр ? - " + (name == "Александр"));
            Console.WriteLine($"Тебя зовут Гоша ? - " + (name == "Гоша"));

        }

    }
}