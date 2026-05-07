internal class Act2_Lecc24_Inciso1
{
    private static void Main(string[] args)
    {
        int a, b, c = 1;
        Console.WriteLine("Ingrese la tabla de multiplicar que desea: ");
        a = Convert.ToInt32(Console.ReadLine());
        for (b = a; b <= 20 ; b++) {
            c = a * b;
            Console.WriteLine( +a + " x " + b + " = " + c);

        }

    }
}