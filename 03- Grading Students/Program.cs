namespace Katas.GradingStudents;

public static class GradingStudentsProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Digite a quantidade de estudantes: ");

        if (!int.TryParse(Console.ReadLine(), out int studentCount) || studentCount < 0)
        {
            Console.WriteLine("Informe uma quantidade válida de estudantes.");
            return;
        }

        List<int> grades = new(studentCount);

        for (int student = 1; student <= studentCount; student++)
        {
            Console.Write($"Nota do estudante {student}: ");

            if (!int.TryParse(Console.ReadLine(), out int grade) || grade is < 0 or > 100)
            {
                Console.WriteLine("Informe uma nota inteira entre 0 e 100.");
                return;
            }

            grades.Add(grade);
        }

        Console.WriteLine("Notas finais:");
        foreach (int grade in GradingStudents(grades))
        {
            Console.WriteLine(grade);
        }
    }

    public static List<int> GradingStudents(List<int> grades) => 
        [.. grades.Select(ObtemMultiploDe5MaisProximo)];


    public static int ObtemMultiploDe5MaisProximo(int numeroOrignial)
    {
        int novoMultiplo = numeroOrignial;

        if (numeroOrignial < 38)
            return numeroOrignial;

        while(novoMultiplo % 5 != 0)
            novoMultiplo++;

        return (novoMultiplo - numeroOrignial) <= 2 ? novoMultiplo : numeroOrignial;
    }
}
