using System;

namespace Speed_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed: ");
            int spd = int.Parse(Console.ReadLine());
            speed(spd);
            Console.ReadKey();
        }

        static void speed(int speed)
        {
            if (speed <= 10)
            {
                Console.Write("\nSlow");
            }
            else if ((speed > 10) && (speed <= 40))
            {
                Console.Write("\nAverage");
            }
            else if ((speed > 40) && (speed <= 100))
            {
                Console.Write("\nFast");
            }
            else if ((speed > 100) && (speed <= 180))
            {
                Console.Write("\nVery Fast");
            }
            else if (speed > 180)
            {
                Console.Write("\nExtremely Fast");
            }
        }

    }
}
