namespace Katas.TimeConversion;

public static class TimeConversionProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Digite um horário no formato hh:mm:ssAM/PM: ");
        string? time = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(time))
        {
            Console.WriteLine("Informe um horário.");
            return;
        }

        Console.WriteLine($"Horário em formato militar: {TimeConversion(time)}");
    }

    public static string TimeConversion(string time)
    {
        int hora = Convert.ToInt32(time[..2]);
        bool ehAm = time.EndsWith("AM", StringComparison.OrdinalIgnoreCase);

        if (hora == 12)
        {
            hora = ehAm ? 0 : 12;
        }
        else if (!ehAm)
        {
            hora += 12;
        }

        return $"{hora:D2}{time[2..8]}";
    }
}
