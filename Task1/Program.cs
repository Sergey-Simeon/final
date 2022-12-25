class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        if(n < m)
        {
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        }
        else if(m < n)
        {
            for (int i = m; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        }
        Console.ReadKey();
    }
}
