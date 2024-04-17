internal class Program
{
    private static void Main(string[] args)
    {
        int n, i;
        Console.WriteLine("Informe uma quantidade: ");
        n = int.Parse(Console.ReadLine());
        for (i = 1; i <= n; i++)
        {
            Console.WriteLine($"Os primeiros {n} números pares são: {i * 2}");        
        }
        for (i = 1; i <= n; i++)
        {
            Console.WriteLine($"Os primeiros {n} números impares são: {i * 2 - 1}");        
        }

}
}