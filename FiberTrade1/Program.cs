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

        if (apartmentNumber < 1 || apartmentNumber > apartmentsTotal)
        {
            Console.WriteLine("Квартиры с таким номером нет в доме.");
        }
        else
        {
            // Рассчитываем номер подъезда и этажа
            int entranceNumber = (apartmentNumber - 1) / apartmentsPerEntrance + 1;
            int floorNumber = ((apartmentNumber - 1) % apartmentsPerEntrance) / 4 + 1;

            // Рассчитываем положение квартиры на лестничной площадке
            int positionIndex = (apartmentNumber - 1) % 4;
            string position = positionIndex switch
            {
                0 => "ближняя слева",
                1 => "дальняя слева",
                2 => "дальняя справа",
                3 => "ближняя справа",
                _ => "",
            };

            Console.WriteLine($"Квартира находится в подъезде номер {entranceNumber}");
            Console.WriteLine($"Этаж: {floorNumber}");
            Console.WriteLine($"Положение на лестничной площадке: {position}");
        }
    }
}
