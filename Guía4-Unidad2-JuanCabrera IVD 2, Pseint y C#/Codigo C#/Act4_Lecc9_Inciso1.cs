using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Tablas de multiplicar====");

        int a, b = 1, c;

        Console.WriteLine("Ingrese el numero de la tabla de multiplicar que desea ver: ");
        a = int.Parse(Console.ReadLine());

        while (b <= 10) 
        {
            c = a * b;
            Console.WriteLine(+a+" Multiplicado por " +b+ " Es: "+c);
            b = b+1;


        }
    }
}