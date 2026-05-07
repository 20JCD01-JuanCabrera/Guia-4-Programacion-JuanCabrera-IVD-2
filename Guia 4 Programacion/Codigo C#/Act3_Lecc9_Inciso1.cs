internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Numero impares entre 20 y un numero x =====");

        double a = 21, b;

        Console.Write("Ingrese un numero final: ");
        b = Convert.ToDouble(Console.ReadLine());

        while (a<=b) {
            Console.WriteLine(a);
            a = a + 2;
        }
    }
}