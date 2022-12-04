class Programm
{
    static void Main(string[] args)
    {
        // Car variable = new Car(); //! Создаем экземпляр класса Car
        // var variable2 = new Car(); //? другой метод создания экземпляра
        // Car variable3 = new(); //? и ещё один метод

        // //! определяем поля экземпляра 
        // variable.Producer = "Ford";
        // variable.FullName = "Mustang";
        // variable.Color = Color.White; //! синтаксис урока про enum
        // variable.Power = 200;
        // variable.Consumption = 8.1;
        // variable.VolumeTank = 65;
        // variable.FuelSupply = variable.VolumeTank; //! также можем брать значения с других полей

        // variable.PrintCarInfo(); //todo Вызываем метод который объявлен в классе
        // ChangeColour(variable, Color.Red); //todo Вызываем Метод который НЕ объявлен в классе
        // variable.PrintCarInfo();
        var new_car = CreateCar("new_car");
        new_car.PassangerNames.Add("Dmitriy");
        new_car.PrintCarInfo();
    }
    //! Метод для смены цвета у экземпляра класса
    static void ChangeColour(Car variable, Color color){
        variable.Color = color;
    }
    //! Метод создания нового экземпляра класса с заданным именем
    static Car CreateCar(string name){
        var car = new Car
        {
            FullName = name,
            PassangerNames = new List<string>(),
        };
        return car;
    }
}
