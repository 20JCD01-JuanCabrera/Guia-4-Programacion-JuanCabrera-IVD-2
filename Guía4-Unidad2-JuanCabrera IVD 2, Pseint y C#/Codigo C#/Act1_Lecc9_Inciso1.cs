internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Peso de manzanas====");
        double p=0, pm=0;

        while (p < 1) 
        { 
            Console.WriteLine("Ingrese el peso de la manzana: ");
            pm = double.Parse(Console.ReadLine());
         
            p = p + pm;
        }
        Console.WriteLine("Ya tienes un kilo de manzanas ");
    }
}