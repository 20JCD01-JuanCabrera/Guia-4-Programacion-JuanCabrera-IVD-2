using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b , c ,d ,e ;
        e = 0;
        Console.Write("Ingrese un numero: " );
        a = Convert.ToInt32(Console.ReadLine());

        if (a <= 1)
        {
            Console.WriteLine("Ingrese un numero mayor a 1");
        }
        else {
            for (b = a; b >= 1; b--) {
                Console.WriteLine(b);
                d = b + 1;
                e = e + b;
            }
            Console.WriteLine("La suma de los numeros es: " + e);
        }

    }
}