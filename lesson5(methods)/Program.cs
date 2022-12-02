class Programm
{
    static void Main(string[] args)
    {
    // //! возведение в степень
    // {
    //     int num = 2;
    //     Console.WriteLine(Math.Pow(num, 12));
    // }
    //! синтаксис написания метода: 
    // {
    //     //? Название метода с болшой буквы!
    //     //TODO *модфифкатор доступа* /тип возвращаемого значения/ /имя метода/ (аргумент(ы))
    //     //!{
    //     //!   Тело метода
    //     //!}
    //     //! 
    // }
    //! Пример написания метода:
    // {
    //     int GetSum(int a, int b)
    //     {
    //         int c = a + b;
    //         return c;
    //     }
    //     Console.WriteLine(GetSum(10, 20));
    // }
    //! Процедура (Метод без возвращаемого объекта)
    // {
    //     void Degree(int a, int b){
    //         int c = a * b;
    //         Console.WriteLine(c);
    //     }
    //     Degree(3, 5);
    //     //? Модификатор void отвечает за отсутвтвие возвращаемого значения
    // }
    //! Модификатор Main => аналог init в python
    //! Методы с этим модификатором исполняются при старте программы
    // {
    
    //! Список в c#
    {
        List<int> numbers = new List<int>();
        //! Добавление элементов в список
        int a = 12;
        int b = 2;
        int c = 3;
        int d = 123;
        numbers.Add(a);
        numbers.Add(b);
        numbers.Add(c);
        numbers.Add(d);
        numbers.Add(a);
        
    }
    //! Метод для демонстрации списка
    void ListShow(List<int> list){
        string res = $"{list[0]}";
        for (int i = 1; i < list.Count(); i++){
            res += $" {list[i]}";

        }
        Console.WriteLine(res);

    }
    string lol = "asdad";
    Console.WriteLine(lol.Contains("d"));
    }
}