internal class Program
{
    private static void Main(string[] args)
    {
        int tipo, boletosAdulto = 0, boletosNino = 0;
        double totalDinero = 0;

        do
        {
            Console.WriteLine("¿Es niño o adulto? (1=Adulto / 2=Niño / 0=Terminar):");
            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                boletosAdulto++;
                totalDinero += 15;
                Console.WriteLine("Boletos vendidos: " + (boletosAdulto + boletosNino) + " | Total: $" + totalDinero);
            }
            else if (tipo == 2)
            {
                boletosNino++;
                totalDinero += 10;
                Console.WriteLine("Boletos vendidos: " + (boletosAdulto + boletosNino) + " | Total: $" + totalDinero);
            }

        } while (tipo != 0);

        Console.WriteLine("===== REPORTE FINAL =====");
        Console.WriteLine("Boletos adulto: " + boletosAdulto);
        Console.WriteLine("Boletos niño: " + boletosNino);
        Console.WriteLine("Total boletos: " + (boletosAdulto + boletosNino));
        Console.WriteLine("Total cobrado: $" + totalDinero);
        Console.ReadKey();
    }
}
