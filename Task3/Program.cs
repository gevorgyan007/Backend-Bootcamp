using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number");

            int _case = Convert.ToInt32(Console.ReadLine());

            switch (_case)
            {
                case int n when (n < 45 && n >= 0):
                    Console.WriteLine("number is in 0 -> 45 range:");
                    break;
                case int n when (n < 90 && n >= 45):
                    Console.WriteLine("number is in 45 -> 90 range:");
                    break;
                case int n when (n <= 135 && n >= 90):
                    Console.WriteLine("number is in 90 -> 135  range: ");
                    break;
                default:
                    Console.WriteLine("number is in other range");
                    break;
            }

        }
    }
}
