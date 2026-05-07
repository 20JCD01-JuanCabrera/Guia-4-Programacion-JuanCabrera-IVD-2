internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Programa que sume los primeros 20 multiplos de 7 y cuantos de esos son pares con for");
        int sumaMultiplos = 0;
        int cantidadPares = 0;
        for (int i = 1; i <= 20; i++)
        {
            int multiplo = i * 7;
            sumaMultiplos += multiplo;
            if (multiplo % 2 == 0)
            {
                cantidadPares++;
            }
        }

        Console.WriteLine($"La suma de los primeros 20 múltiplos de 7 es: {sumaMultiplos}");
        Console.WriteLine($"Cantidad de múltiplos pares: {cantidadPares}");
    }
}