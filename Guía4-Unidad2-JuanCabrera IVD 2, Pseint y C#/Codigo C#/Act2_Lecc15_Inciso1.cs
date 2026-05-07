using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        int a , b , c , d ;
        c = 0;
        for ( a = 2; a <= 100; a++) {
            d = 0;
            for ( b = 1; b <= a; b++) {
                if (a % b == 0) {
                    d++;
                }
            }
            if (d == 2) {
                c += a;
            }
        }
        Console.WriteLine("La suma de los numero primos entre 1 y 100 es: " + c);
    }
}