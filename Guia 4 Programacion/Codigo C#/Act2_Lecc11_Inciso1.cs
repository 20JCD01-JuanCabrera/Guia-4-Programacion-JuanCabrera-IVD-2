internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Factorial =====");

        int a , b , c;

        Console.WriteLine("Ingrese un numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        b = 1;
        c = a;

        do
        {
            b = b * c;
            c = c - 1;
        }
        while (c > 0);
        
        Console.WriteLine("El factorial es: " + b);
    }
}