internal class Program
{
    private static void Main(string[] args)
    {
        int contador, suma = 0;

        for (int i = 2; i <= 22; i++)
        {
            contador = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine(i + " es primo");
                suma = suma + i;
            }
        }

        Console.WriteLine("La suma de los primos es: " + suma);
    }
}