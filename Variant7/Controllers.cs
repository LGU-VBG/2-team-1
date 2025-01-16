namespace Train;

public class Controllers
{
    // Свойство с лямбда-выражением для начала проверки билетов
    public void StartTicketCheck () => 
        Console.WriteLine("\nКонтроллеры: Начали проверку билетов");

    // Свойство с лямбда-выражением для завершения проверки билетов
    public void EndTicketCheck () => 
        Console.WriteLine("\nКонтроллеры: Закончили проверку билетов");
}