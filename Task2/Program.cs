using System;

namespace Task2
{
    class Program
    {
        public static void CheckPointCircle(float x, float y)
        {
            float circle_x = 3;
            float circle_y = 5;
            float rad = 4;

            if ((x - circle_x) * (x - circle_x) +
            (y - circle_y) * (y - circle_y) < rad * rad)
                Console.WriteLine("Point B({0},{1}) inside the circle!", x, y);
            else if ((x - circle_x) * (x - circle_x) +
           (y - circle_y) * (y - circle_y) > rad * rad)
                Console.WriteLine("The point B({0},{1}) outside the circle!", x, y);
            else
                Console.WriteLine("The point B({0},{1}) is on the circle", x, y);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the point B(x,y) x coordinate!");
            string px = Console.ReadLine();
            Console.WriteLine("Enter the point B(x,y) y coordinate!");
            string py = Console.ReadLine();

            float x = Convert.ToSingle(px);
            float y = Convert.ToSingle(py);

            Console.WriteLine(new string('-', 40));

            CheckPointCircle(x, y);

            Console.ReadKey();
        }
    }
}
