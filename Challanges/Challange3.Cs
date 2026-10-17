public class Challange3
{
    public static int Diferenca()
    {
        Console.WriteLine("Informe 4 valores inteiros: ");
        int a = int.Parse(Console.ReadLine()?? "");
        int b = int.Parse(Console.ReadLine()?? "");
        int c = int.Parse(Console.ReadLine()?? "");
        int d = int.Parse(Console.ReadLine()?? "");

        int diferenca = (a * b) - (c * d);

        Console.WriteLine($"A: {a}\nB: {b}\nC: {c}\nD: {d}");

        return diferenca;
    }

    public static void Executar()
    {
        int diferenca = Diferenca();
        Console.WriteLine($"Diferença = {diferenca}");
    }
}