using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer;

            Console.Write("Skriv in ett positivt tal: ");
            nummer = int.Parse(Console.ReadLine());

            while (nummer >= 0)
            {
                Console.Write("Skriv in ett positivt tal: ");
                nummer = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Programmet avslutas.");
        }
    }
}
