namespace Train;

class Program
{
    static Controllers controllers = new Controllers();

    static void Main(string[] args)
    {
        // Подписываемся на событие контроля с использованием лямбда-выражений
        Lastochka.StartControlEvent += (stationName) =>
        {
            controllers.StartTicketCheck(); 
            Console.WriteLine($"Контроль начат на станции: {stationName}");
        };

        Lastochka.EndControlEvent += (stationName) =>
        {
            controllers.EndTicketCheck(); 
            Console.WriteLine($"Контроль закончен на станции: {stationName}");
        };

        Lastochka.PrintStations();
    }
}