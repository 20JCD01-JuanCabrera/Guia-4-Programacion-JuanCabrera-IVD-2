internal class Program
{
    private static void Main(string[] args)
    {
        int a , b , c, d;
        d = 0;
            for (a = 1; a <= 50; a++) {
            c = 0;
            for (b = 1; b <= a; b++) {
                if (a % b == 0) {
                    c++;
                }
            }
            if (c == 2) {
                Console.WriteLine(a);
                d = d + a;
            }

        }
        Console.WriteLine(d);
    }
}