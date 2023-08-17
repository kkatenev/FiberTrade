using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество этажей: ");
        int floors = int.Parse(Console.ReadLine());

        Console.Write("Введите количество подъездов: ");
        int entrances = int.Parse(Console.ReadLine());

        Console.Write("Введите номер квартиры: ");
        int apartmentNumber = int.Parse(Console.ReadLine());

        int apartmentsPerEntrance = 4 * floors;
        int apartmentsTotal = apartmentsPerEntrance * entrances;

        bool isApartmentValid = apartmentNumber >= 1 && apartmentNumber <= apartmentsTotal;

        int entranceNumber = (apartmentNumber - 1) / apartmentsPerEntrance + 1;
        int floorInEntrance = ((apartmentNumber - 1) / 4) % floors + 1;

        string position = ((apartmentNumber - 1) % 4) switch
        {
            0 => "ближняя слева",
            1 => "дальняя слева",
            2 => "дальняя справа",
            3 => "ближняя справа",
            _ => "",
        };

        if (isApartmentValid)
        {
            Console.WriteLine($"Квартира находится в подъезде номер {entranceNumber}");
            Console.WriteLine($"Этаж: {floorInEntrance}");
            Console.WriteLine($"Положение на лестничной площадке: {position}");
        }
        else
        {
            Console.WriteLine("Квартиры с таким номером нет в доме.");
        }
    }
}
