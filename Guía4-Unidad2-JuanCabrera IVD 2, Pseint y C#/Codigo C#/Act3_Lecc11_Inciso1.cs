internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Sumas ====");

        int a, b, menor, mayor, c, suma;

        Console.WriteLine("Digite un numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite otro numero: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            mayor = a;
            menor = b;
        }
        else
        {
            mayor = b;
            menor = a;
        }
        c = menor;
        suma = 0;

        do
        {
            suma = suma + c;
            c = c + 1;
        }
        while (c<=mayor);
        Console.WriteLine("La suma es: " + suma);
    }
}