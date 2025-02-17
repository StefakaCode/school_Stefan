using System.Security.Principal;

namespace school_Stefan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 1;
            Print(n++);
        }

        static void Print(int n) {
            Console.WriteLine($"{n} {Console.ReadLine()}");
        }
    }
}
