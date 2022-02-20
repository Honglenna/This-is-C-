namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            System.Console.WriteLine(a.HasValue);
            System.Console.WriteLine(a != null);

            a = 3;
            System.Console.WriteLine(a.HasValue);
            System.Console.WriteLine(a != null);
            System.Console.WriteLine(a.Value);

        }
    }
}

