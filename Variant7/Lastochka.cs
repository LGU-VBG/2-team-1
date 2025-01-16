namespace Train;

public static class Lastochka
{
    // Делегат для события контроля
    public delegate void ControlEventHandler(string stationName);

    // События контроля
    public static event ControlEventHandler StartControlEvent;

    public static event ControlEventHandler EndControlEvent;

    // Публичное статическое неизменяемое поле с предустановленным массивом станций
    private static string[] Stations =
    {
        "Санкт-Петербург",
        "Озерки",
        "Парголово",
        "Левашово",
        "Песочная",
        "Дибуны",
        "Белоостров",
        "Солнечное",
        "Репино",
        "Комарово",
        "Выборг - Конечная"
    };


    public static void PrintStations()
    {
        Console.WriteLine("\n\n\n\nУважаемые пассажиры! \nОт лица компании мы рады приветствовать Вас на борту скоростного поезда «Ласточка» \nЖелаем Вам приятной поездки!\n\n");


        Random random = new Random();

        int controlIndex = random.Next(0, 3);
        int controlIndex2 = controlIndex + random.Next(3, 4);

        for (int i = 0; i < Stations.Length; i++)
        {
            Console.WriteLine($"\nСтанция: {Stations[i]}\n");
            Console.WriteLine("||====||");
            Console.WriteLine("||    ||");
            Console.WriteLine("||====||");
            Console.WriteLine("||    ||");
            Console.WriteLine("||====||");

            if (i == controlIndex)
            {
                StartControlEvent(Stations[i]);
            }
            if (i == controlIndex2)
            {
                EndControlEvent(Stations[i]);
            }
        }
    }
}
