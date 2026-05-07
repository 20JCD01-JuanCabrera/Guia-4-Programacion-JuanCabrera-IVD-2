internal class Program
{
    private static void Main(string[] args)
    {
        int i, j, c, tp, sp;
        tp = 0;
        sp = 0;
        for(i= 300; i>=1; i--){
            if (i % 2 == 0) {
                sp = sp + i;
            }
            c = 0;
            for (j=1; j<=i; j++){
                if (i % j == 0) {
                    c++;
                }
            }
            if (c == 2) {
                tp = tp + 1;
            }
        }
        Console.WriteLine("La suma de los números primos es: " + tp);
        Console.WriteLine("La suma de los números pares es: " + sp);
    }
}