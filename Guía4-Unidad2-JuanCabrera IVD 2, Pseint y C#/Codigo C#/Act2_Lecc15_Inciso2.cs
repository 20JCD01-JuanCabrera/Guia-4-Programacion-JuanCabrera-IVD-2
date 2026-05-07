internal class Program
{
    private static void Main(string[] args)
    {
        int i , billete, b100, td;
        b100 = 0;
        td = 0;

        for (i = 1; i <= 1000; i++) {
            Console.WriteLine("Ingrese el valor del billete: "+i+ " (Q.20, Q.50, Q.100) ");
            billete = Convert.ToInt32(Console.ReadLine());

            if(billete == 20 || billete == 50 || billete == 100) {
                td = td + billete;
                if (billete == 100) {
                    b100 = b100 + 1;
                }
            } else {
                Console.WriteLine("Valor del billete no válido. Por favor, ingrese Q.20, Q.50 o Q.100.");
            }

        }
        Console.WriteLine("Billetes de Q.100 ingresados: " + b100);
        Console.WriteLine("Total de dinero ingresado: Q." + td);
    }
}