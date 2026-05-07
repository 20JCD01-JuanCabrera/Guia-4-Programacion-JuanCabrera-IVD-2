internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Niveles de videojuego====");
        double a = 0 , b;

        while (a < 350)
        {
            Console.WriteLine("Digite la cantidad de monedas que tiene: ");
            b = double.Parse(Console.ReadLine());
            a = a + b;
        }
        Console.WriteLine("¡¡¡Ya tiene "+ a +" monedas!!! Ya es nivel 5");
    }
}