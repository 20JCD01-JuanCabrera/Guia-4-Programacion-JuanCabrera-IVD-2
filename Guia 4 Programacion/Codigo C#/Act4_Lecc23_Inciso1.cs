internal class Program
{
    private static void Main(string[] args)
    {
        int a , b , c;
        Console.WriteLine("Que tabla de multiplicar desea ver?: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = 1;
        c = 1;

        while (c <= 10)
        {
            b = a * c;
            Console.WriteLine($"{a} x {c} = {b}");
            c++;
        }
    }
}