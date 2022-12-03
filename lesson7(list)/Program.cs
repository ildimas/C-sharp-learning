using System.Collections.Generic
class Programm
{
    static void Main(string[] args)
    {
    //! Синтаксис списка:
    // {
    //     //? в <> указывается тип переменных которые будут хранитсья в этом списке
    //     var list_ = new List<int>();
    //     Console.WriteLine($"Размер списка: {list_.Count}");
    //     Console.WriteLine($"Емкость {list_.Capacity}");
    //     //! Добавление элемента в список:
    //     list_.Add(111);
    //     Console.WriteLine($"Размер списка: {list_.Count}");
    //     Console.WriteLine($"Емкость {list_.Capacity}");
    //     //! создадим спсиок с заданной емкостью
    //     int capacity = 10;
    //     var list2 = new List<int>(capacity);
    //     Console.WriteLine($"Размер списка: {list2.Count}");
    //     Console.WriteLine($"Емкость {list2.Capacity}");
    // }  
    
    //! из массивов можно создавать списки следюущим образом:
    // {
    //     var list = new List<int>();
    //     int[] a = new int[] {1, 2, 3};
    //     list = new List<int>(a);
    //     list.Add(2);
    //     Console.WriteLine(list.Count);
    // }        
    //! Методы списков:
    {
        var listik = new List<int>(20);
        int[] b = {1, 2, 3, 4, 5, 6, 7, 8 , 9};
        listik = new List<int>(b);
        //! добавление элемента
        listik.Add(100500);
        Show(listik);
        //! добавление нескольких элементов
        listik.AddRange(new[] {666, 777, 888});
        Show(listik);
        //! проверка есть ли объект в списке 
        Console.WriteLine(listik.Contains(666));
        //! удаление по значению
        listik.Remove(777);
        Show(listik);
        //! удаление по индексу (быстрее)
        listik.RemoveAt(0);
        Show(listik);
        //! выполнить действия над всеми эементами (аналог map)
        listik.ForEach(Console.WriteLine);
        Console.WriteLine(listik.Capacity);
        listik.Clear();
        Console.WriteLine(listik.Capacity);

    } 
    // var list1 = new List<int>(){1,2,3,4,5};
    // Console.WriteLine(list1.Capacity);
    }
    static void Show(List<int> list){
        string stroke = $"{list[0]}";
        for (int i = 1; i < list.Count; i++){
            stroke = stroke + " " + $"{list[i]}";
        }
        Console.WriteLine(stroke);
    }
}