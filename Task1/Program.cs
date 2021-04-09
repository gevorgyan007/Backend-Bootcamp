using System;

namespace Task1
{
    class Program
    {
        public static void MethodRandom()
        {
            Random r = new Random();
            Console.WriteLine("Random number (15,85) range is -- {0}", r.Next(15, 85));
        }
        static void Main(string[] args)
        {
            MethodRandom();

            Console.ReadKey();
        }
    }
}
