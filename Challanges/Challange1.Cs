using System;
public class Challange1
{
    public static double Triangle1()
    {
        Console.WriteLine("Write the first triangle size: ");
        double a = double.Parse(Console.ReadLine()?? "");
        double b = double.Parse(Console.ReadLine()?? "");
        double c = double.Parse(Console.ReadLine()?? "");

        double p = (a + b + c)/2;

        double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

        return area;

    }

    public static double Triangle2()
    {
        Console.WriteLine("Write the second triangle size: ");
        double a = double.Parse(Console.ReadLine()?? "");
        double b = double.Parse(Console.ReadLine()?? "");
        double c = double.Parse(Console.ReadLine()?? "");

        double p = (a + b + c)/2;

        double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

        return area;
    }

public static void Executar(){
    double area1 = Challange1.Triangle1();
    double area2 = Challange1.Triangle2();

    Console.WriteLine($"First triangle area: {area1}");
    Console.WriteLine($"Second triangle area: {area2}");

if (area1 == area2)
{
    Console.WriteLine("They both area are equals.");
}

else if(area1 < area2)
{
    Console.WriteLine("The second triangle has the biggest area.");
}

else
{
    Console.WriteLine("The first triangle has the biggest area.");
}
}
    
}


