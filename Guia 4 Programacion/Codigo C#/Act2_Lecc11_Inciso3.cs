internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== multiplos de 4 ====");

        int a1, b1, mayor, menor, c;

        Console.WriteLine("Escriba un numero: ");
        a1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba otro numero: ");
        b1 = Convert.ToInt32(Console.ReadLine());

        if (a1 > b1)
        {
            mayor = a1;
            menor = b1;

        }
        else
        {
            mayor = b1;
            menor = a1;
        }

        c = menor;

        do
        {
            if (c % 4 == 0)
            {
                Console.WriteLine(c);
            }
            
            c++;
        }
        while (c <= mayor);
    }
}