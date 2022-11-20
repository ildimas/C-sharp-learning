
class Programm
{
    static void Main(string[] args)
    {
        //? Десятичные дроби

        //! несмотря на тип double значение остается целочисленым
        double x = 5 / 2;
        Console.WriteLine($"x = {x}");
        //! Если хотя бы один из элементов имеет точку после целой части, то результат будет десятичной дробью
        double y = 5.0 / 2;
        Console.WriteLine($"y = {y}");
        //! Также мы можем использовать явное переопределение типов данных указывая какием будет поученный результат
        double f = (double) 5/2;
        Console.WriteLine($"f = {f}");

        //? Переполнение

        //! Переменна типа int имеет промежуток значения от -2 147 483 648 до 2 147 483 647,
        //! при переполнении этого промежутка с одной стороны числа продолжают свое движение с другой
        int z = -2_147_483_648;
        z = z - 1;
        int e = 2_147_483_647;
        e = e + 1;
        Console.WriteLine($"z = {z} e = {e}");

        //? Инкримент

        //! Существует два типа инкримента префиксный и постфиксный (++x и x++) делают они одно и тоже прибаляют к x еденицу
        //! Их отлтичие заключается в том то префикс сначала прибавит 1 а потом совершатся другие мат действия,
        //!  а постфикс сначала совершит все действия а после прибавит 1

        int postfix = 5;
        postfix = postfix++ / 2;
        int prefix = 5;
        prefix = ++prefix / 2;
        Console.WriteLine($"prefix = {prefix} postfix = {postfix}");

        //? Строки

        //! Сложение строк
        string hello = "Привет";
        string world = "Мир!";

        string result = hello + ' ' + world;
        Console.WriteLine($"result = {result}");
        //! Аналог f-cтроки 2 
        string lantern = "Фонарь";
        string bowl = "Миска";
        Console.WriteLine("Что вы возьмете: <{0}> или <{1}>", lantern, bowl);
        
        //? char
        //! К charАМ можно применять энкримент он будет менять букву на соответствующую в таблице кодировки
        char l = 'a';
        l++;
        Console.WriteLine($"char = {l}");

        //? var
        //! можно не объявлять тип данных, а применять var
        var stringName = "Маша";
        var intCounter = 1;
        var doubleNumber = 1.16;

        Console.WriteLine($"это varЫ: {stringName}, {intCounter}, {doubleNumber}");

        //? Математические операции и их приоритет

        //!Базовые математические операции
        //! Математические операторы могут применяться между разными типами данных
        double a = 5;
        int b = 2;

        Console.WriteLine($"операция сложения a + b = {a + b}");
        Console.WriteLine($"операция вычитания a - b = {a - b}");
        Console.WriteLine($"операция умножения a * b = {a * b}");
        Console.WriteLine($"операция целочисленого деления a / b = {a / b}");
        Console.WriteLine($"операция деления с остатком a % b = {a % b}");

        //! мы можем приводить один тип данных к другмоу типу, применяя явное присваивание
        double dd = 1.11111;
        // - так нельзя int dd_int = dd;
        int dd_int = (int) dd;
        Console.WriteLine($"это явное переопределение типа данных {dd} => {dd_int}");

        //! C# поддерживает таки операции как += -= *= /= %=

        //? Ввод в консоль

        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        int intNum = int.Parse(input);

        intNum += 2;

        Console.WriteLine($"Измененное значение: {intNum}");
    }   
}


