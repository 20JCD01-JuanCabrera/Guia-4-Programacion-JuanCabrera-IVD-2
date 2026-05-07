internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Numeros impares ====");

        int a = 1;

        do { 
            Console.WriteLine(a);
            a += 2;
        } while (a < 100);
    }
}