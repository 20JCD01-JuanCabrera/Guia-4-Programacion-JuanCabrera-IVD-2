internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Escriba el numero final de el ciclo: ");
        a = Convert.ToInt32(Console.ReadLine());

        if (a <= 2)
        {
            Console.WriteLine("Escriba un numero mayor a 2");
        }
        else
        {
            for (b = 2; b <= a; b += 2 )
            {
                Console.WriteLine(b);
            }
        }
    }
}