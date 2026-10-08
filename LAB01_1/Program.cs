namespace LAB01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in second number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"((a + b) / 2) = {((a + b) / 2)}");
        }
    }
}
