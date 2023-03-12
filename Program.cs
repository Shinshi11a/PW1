using System;

public class Car
{
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int TopSpeed { get; set; }

    public Car(string name, string make, string model, int topSpeed)
    {
        Name = name;
        Make = make;
        Model = model;
        TopSpeed = topSpeed;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Автомобиль {Name}, максимальная скорость: {TopSpeed} км/ч");
    }
}

class Program
{
    static void Main()
    {
        // Создаем 4 автомобиля
        var car1 = new Car("BMW M5", "BMW", "M5", 305);
        var car2 = new Car("Audi RS7", "Audi", "RS7", 305);
        var car3 = new Car("Mercedes-AMG E63 S", "Mercedes-Benz", "E63 S", 300);
        var car4 = new Car("Porsche Panamera Turbo S", "Porsche", "Panamera Turbo S", 315);

        // Выводим информацию о каждом автомобиле
        car1.PrintInfo();
        car2.PrintInfo();
        car3.PrintInfo();
        car4.PrintInfo();

        // Определяем победителя гонки
        var winner = car1;
        if (car2.TopSpeed > winner.TopSpeed) winner = car2;
        if (car3.TopSpeed > winner.TopSpeed) winner = car3;
        if (car4.TopSpeed > winner.TopSpeed) winner = car4;

        Console.WriteLine($"Победил автомобиль {winner.Name}!");
    }
}