using System;
class Programm
{
    static void Main(string[] args){
        Console.WriteLine("Что это было ?");
        type_of vehicle = type_of.Aircraft;
        Console.WriteLine(vehicle); //Вывод Aircraft
        Console.WriteLine((int) vehicle); //Вывод 0 
        //! вывод всех значений enum (текст)
        string[] enum_array_string = Enum.GetNames(typeof(type_of));
        Console.WriteLine("Вывод с помощью get names");
        foreach (var item in enum_array_string)
        {
            Console.WriteLine(item);
        }
        int[] enum_array_int = (int[])Enum.GetValues(typeof(type_of));
        Console.WriteLine("Вывод с помощью get values");
        foreach (var i in enum_array_int)
        {
            Console.WriteLine(i);
        }

        
    }
    //! объявлять надо не в методе main
    enum type_of
        {
            Aircraft, //Имеет значение 0
            Car, //Имеет значение 1
            Boat = 666, //Имеет значение 2 //! также можно переобределять значения
            Helicopter //Имеет значение 3 //! тогда последующие элементы будут увеличивться относительно предыдущего 667
        }
    
}