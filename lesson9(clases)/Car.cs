class Car //! тип (при сосздании экземпляра по этому типу он будет содержать все поля из типа)
{
    public string Producer; //! Поля
    public string FullName;
    public int Power;
    public Color Color; //! тип enum 
    public double Consumption;
    public double VolumeTank;
    public double FuelSupply;
    public List<string> PassangerNames;
    //! напишем метод для чтения полей экземпляра класса Car

    //todo Если метод объявлен внутри класса не нужно использовать переменную для доступа к полям
    public void PrintCarInfo(){
        Console.WriteLine($"Полное название машины: {FullName}");
        Console.WriteLine($"Производитель: {Producer}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Лошадиные силы: {Power}");
        Console.WriteLine($"Расход на 100 км: {Consumption}");
        Console.WriteLine($"Емкость топливного бака: {VolumeTank}");
        Console.WriteLine($"Остаток топлива: {FuelSupply}");
        Console.WriteLine($"Пасажиры: {PassangerNames[0]}");
    }
}

