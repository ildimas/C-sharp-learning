class Programm
{
    static void Main(string[] args)
    {
        //! пример программы без условных конструкций
        // {
        //     Console.WriteLine("Введите первое слогаемое: ");
        //     int a = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Введите второе слогаемое: ");
        //     int b = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine($"{a} + {b} = {a + b}");
        // }  
        //!  условный оператор 
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
        // {
        //     int a = 5, b = 6;
        //     Console.WriteLine($"{a} == {b} ? - " + (a == b));
        //     Console.WriteLine($"{a} != {b} ? - " + (a != b));
        //     Console.WriteLine($"{a} > {b} ? - " + (a > b));
        //     Console.WriteLine($"{a} < {b} ? - " + (a < b));

        //     //! работа условного оператора с типом данных string
        //     string name = "Александр";
        //     Console.WriteLine($"Тебя зовут Александр ? - " + (name == "Александр"));
        //     Console.WriteLine($"Тебя зовут Гоша ? - " + (name == "Гоша"));

        //     //! Тест на совершеннолетик
        //     Console.WriteLine("Введите свой возраст: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age < 18)
        //     {
        //         Console.WriteLine("Вы несовершеннолетний");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Вы совершеннолетний");
        //     }
        //! Логические операторы
        // {
        //     bool first = true;
        //     bool second = false;
        //     //! оператор И 
        //     Console.WriteLine($"{first && second}");
        //     //! оператор ИЛИ
        //     Console.WriteLine($"{first || second}");
        //     //! оператор отрицания
        //     Console.WriteLine("Введите число");
        //     int i = int.Parse(Console.ReadLine());
        //     bool isOdd = (i % 2 == 0);
        //     bool isEven = !isOdd;
        //     if (isOdd == true)
        //     {
        //         Console.WriteLine($"Число {i} является четным");
        //     }
        //     else if (isEven != false)
        //     {
        //         Console.WriteLine($"Число {i} является нечетным");
        //     }
        // }
        //! Тернарный оператор
        // {
        //     int a = 10;
        //     int b = 1;
            
        //     int c = b == 0
        //         ? 1
        //         : a / b;
        //     Console.WriteLine(c);
        // }
        //! Шаблон switch
        // {
        //     Console.WriteLine("Введите число: ");
        //     int num = int.Parse(Console.ReadLine());
        //     switch(num)
        //     {
        //         case 1:
        //         num += 1;
        //         Console.WriteLine("case 1");
        //         break;

        //         case 2:
        //         num += 2;
        //         Console.WriteLine("case 2");
        //         break;

        //         case 3:

        //         default:
        //             Console.WriteLine("Default case");
        //             break;
                
        //     }
        // }
        //! switch expression
        // {
        //     Console.WriteLine("Введите число от 0 до 15");
        //     int a = int.Parse(Console.ReadLine());

        //     string b = a switch
        //     {
        //         > 0 and < 10 => Convert.ToString(a),
        //         10 => "A",
        //         11 => "B",
        //         12 => "C",
        //         13 => "D",
        //         14 => "E",
        //         15 => "F",
        //         _ => "Мы не умеем переводить такие числа"
        //     };
        //     Console.WriteLine(b);
        // }
        //! классный код
        {
            double bankDeposit = Convert.ToDouble(Console.ReadLine());
            double sum = 0.0;
            
            switch(bankDeposit)
            {
                case var n when (n < 100):
                    sum = n + n * 0.05;
                    break;
                        
                case var n when ((n > 100) && (n < 200)):
                    sum = n + n * 0.07;
                    break;
                Math.Ceiling
                case var n when (n >= 200):
                    sum = n + n * 0.1;
                    break;
            }
            
            

            Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");

        }
    }

}