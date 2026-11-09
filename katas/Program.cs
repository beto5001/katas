using Katas.BirthdayCakeCandles;

(string Name, Action Run)[] katas =
{
    ("Birthday Cake Candles", BirthdayCakeCandlesProgram.Run)
};

while (true)
{
    Console.WriteLine("\n=== Katas ===");

    for (int index = 0; index < katas.Length; index++)
    {
        Console.WriteLine($"{index + 1}. {katas[index].Name}");
    }

    Console.WriteLine("0. Sair");
    Console.Write("Escolha um kata: ");

    string? input = Console.ReadLine();

    if (input is null || input.Trim() == "0")
    {
        break;
    }

    if (!int.TryParse(input, out int choice) || choice < 1 || choice > katas.Length)
    {
        Console.WriteLine("Opção inválida.");
        continue;
    }

    katas[choice - 1].Run();
}