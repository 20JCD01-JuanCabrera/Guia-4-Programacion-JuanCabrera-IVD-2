internal class Program
{
    private static void Main(string[] args)
    {
        int  tipo, badulto, bnino, totalb;
        double totald;

        badulto = 0;
        bnino = 0;
        totald = 0;

        do
        {
            Console.WriteLine("Tipo de boleto (1=Adulto, 2=Niñom 0=Terminar)");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo ==1)
            {
                totald = totald + 15;
                badulto = badulto + 1;
            }
            else if (tipo == 2)
            {
                totald = totald + 10;
                bnino = bnino + 1;
            }
        }
        while (tipo != 0);
        totalb = badulto + bnino;

        Console.WriteLine("Boletos de adulto vendidos: " + badulto);
        Console.WriteLine("Boletos de niño vendidos: " + bnino);
        Console.WriteLine("Total de boletos vendidos: " + totalb);
        Console.WriteLine("Total de dinero vendido: Q." + totald);
    }
}