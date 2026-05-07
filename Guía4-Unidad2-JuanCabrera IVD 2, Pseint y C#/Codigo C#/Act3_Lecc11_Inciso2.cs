internal class Act3_Lecc11_Inciso2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====Sumas====");

        int a , b ;
        b = 0 ;

        do
        {
            Console.WriteLine("Escriba un numero (9 para finalizar): ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a == 9)
            {
                Console.WriteLine("La suma total es: " + b);
                break;
            }
            else
            {
                b = b + a;
            }
        }
        while (a != 9);    
    }
}