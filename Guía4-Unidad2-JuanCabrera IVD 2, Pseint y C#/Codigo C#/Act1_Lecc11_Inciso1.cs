using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Cupos de estacionamiento =====");

        int a = 201;

        do 
        {
            a --; 
            Console.WriteLine("Cupos disponibles: " + a);
        } while (a > 1);
        Console.WriteLine("Ya no hay cupos disponibles");
    }
}