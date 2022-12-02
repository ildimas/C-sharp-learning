class Programm
{
    static void Main(string[] args)
    {
        //! Значимые и ссылочные переменные (стек и куча)
        // {
        //     int a = 10;
        //     //? значимая переменная находится в стеке

        //     int[] array = {1, 2, 4}; 
        //     //? переменная array - значимая и содержит в себе ссылку на область памяти в которой храняться данные массива (куче)

        // }
        //! Демострация того как работают ссылки на переменные
        // {
        //     void ChangeNum(int a)
        //     {
        //         a = 777;
        //     }
        //     //! запускаем код
        //     int x = 111;
        //     ChangeNum(x);
        //     Console.WriteLine(x);
        //     //TODO Вывод 111, метод ChangeNum не влияет на значение значимой переменной, а меняет её лишь локально

        //     //! попытка №2
        //     void ChangeNum2(ref int a)
        //     {
        //         a = 777;
        //     }
        //     int b = 111;
        //     ChangeNum2(ref b);
        //     Console.WriteLine(b);
        //      //TODO Вывод 777
             
        //      //TODO Теперь в фукнцию ChangeNum2 мы передаем не просто копию переменной а ссылку на переменную, поэтому все операции проведенные над переменной отобразяться вне зоны видимости метода.
        // }
        //! как работают методы со ссылчными типами данных ?
        // {
        //     void ChangeFirstElement(int[] array){
        //         array[0] = 12345;
        //     }
        //     int[] storage = {1, 2, 3, 4, 5};
        //     ChangeFirstElement(storage);
        //     for (int i = 0; i < storage.Length; i++)
        //     {
        //         Console.WriteLine(storage[i]);
        //     }
        //     //TODO тут все работает и без моификатор ref, так как массивы имеют другую природу хранения данных
        // }
        //! Попробуем создать копию массива a и изменить в ней некотырые значения
        // {
        //     int[] a = {1, 2, 3, 4, 5};
        //     int[] b = a; //тут мы не создаем новый массив, а кладем в переменную b ссылку на массив а 

        //     for (int i = 0; i < b.Length; i++)
        //     {
        //         b[i] = b[i] + 5;
        //         Console.WriteLine($"элемент массива b - {b[i]} элемент массива а - {a[i]}");
        //     }
        //     //todo значения в массивах а и b идентичны потому что b слдержит ссылку на переменную а, поэтому они принимают общие значения
        // }
        //! Разделение массива на 2 сепарированых объекта
        // {
        //     static void AddToM(ref int[] array, int to_add)
        //     {
        //         int[] new_array = new int[array.Length + 1];
        //         for (int i = 0; i < array.Length; i++)
        //         {
        //             new_array[i] = array[i];
        //         }
        //         new_array[array.Length] = to_add;
        //         array = new_array; 
        //     }
        //     static void Show_m(int[] array)
        //     {
        //         string res =  $"{array[0]}";
        //         for (int i = 1; i < array.Length; i++)
        //         {
        //             res = res + " " + $"{array[i]}";
        //         }
        //         Console.WriteLine(res);
        //     }
        //     int[] arr = {1, 2, 3, 4, 5};
        //     Show_m(arr);
        //     AddToM(ref arr, 6);
        //     Show_m(arr);
        // }
        //todo *ref* используется для того чтобы разблокировать возможность переопределять ссылку на данные у ссылочных переменных
        //! Создаем метод который може т возвращать два значения
        // {
        //     static (int, int) JustPrint(int a, int b)
        //     {
        //         a = a * 5;
        //         b = b * 5;
        //         return (a, b);
        //     }
        //     int a = 150;
        //     int b = 25;
        //     Console.WriteLine(JustPrint(a, b));

        // }
        //! Работа модификатора out
        //? Перепишем предыдущий метод JustPrint но с использованием модификатора out
        // {
        //     static void JustPrint(int def, out int a)
        //     {
        //         a = 0;
        //         if (def % 2 == 0)
        //             a = def * 5;
                
        //     }
        //     JustPrint(25, out int a);
        //     Console.WriteLine(a);
        // }
        //! Перегрузки 
        //? Используются когда не понятно какого типа данные поступят в метод
        // {
        //     SayType('1');
        //     SayType(1);
        //     SayType("lmao");
        // }
        //! Лямбда-выражения
        // {
        //     static int Sum(int a, int b) => a *  b;
        //     Console.WriteLine(Sum(1, 9));
        // }
    }
    //! перегрузку писать не в init (Main)
    static void SayType(int num)
        {
                Console.WriteLine("Это int");
        }
        static void SayType(char str)
        {
            Console.WriteLine("Это char");
        }
        static void SayType(string str)
        {
            Console.WriteLine("Это string");
        }   
}