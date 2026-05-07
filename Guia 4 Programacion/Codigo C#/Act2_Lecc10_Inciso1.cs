internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Tablas de multiplicar====");
        
        int a , b ;

        for (a = 1; a <= 20; a++) {
            b = 4 * a;
            Console.WriteLine($"4 x {a} = {b}");
        }
    }
}