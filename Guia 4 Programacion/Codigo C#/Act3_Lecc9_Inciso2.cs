internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Numeros primos ====");

        int a= 0, b , c=1;
        Console.WriteLine("Digite un numero");
        b = int.Parse(Console.ReadLine());

        while (c <= b) 
        {
            if (b%c == 0)
                a = a + 1;

            c++;
        }
        if (a == 2)
            Console.WriteLine(+b+" es primo");
        else
            Console.WriteLine(+b+" no es primo");
    }
}