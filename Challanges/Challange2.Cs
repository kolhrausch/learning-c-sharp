using System.Formats.Asn1;

public class Challange2
{
    public static double Circulo()
    {
        Console.WriteLine("Enter the circle diameter: ");
        double diameter = double.Parse(Console.ReadLine() ?? "");

        double pi = 3.14159;

        double raio = diameter / 2;

        double area = pi * Math.Pow(raio, 2);

        return area;
    }

    public static void Executar()
    {
        double area = Challange2.Circulo();
        Console.WriteLine($"Area is: {area.ToString("N")}");
    }
}