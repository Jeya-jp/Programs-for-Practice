using System;
namespace Time
{
    class Program
    {
        static void time(string hour, string minuite)
        {
            int[] arr = { int.Parse(hour), int.Parse(minuite) };
            int hr = arr[0];
            int min = arr[1];
            if (hr > 0 && hr <= 12 && min > 0 && min <= 60)
            {
                int add = min + 25;
                if (add > 60)
                {
                    add = add - 60;
                    hr++;
                    Console.Write(hr + ": " + add);
                }
                else
                {
                    Console.Write(hr + ": " + add);
                }
            }
            else if (hr > 0 && hr <= 24 && min > 0 && min <= 60)
            {
                int add = min + 25;
                {
                    if (add > 60 && hr == 24)
                    {
                        add = add - 60;
                        hr = 0;
                        Console.Write(hr + ": " + add);
                    }
                    else if (add > 60)
                    {
                        add = add - 60;
                        hr++;
                        Console.Write(hr + ": " + add);
                    }
                    else
                    {
                        Console.Write(hr + ": " + add);
                    }
                }
            }
            else
            {
                Console.Write("Invalid hour format");
            }
        }
        
        static void Main(string[] args)
        {
            string hr, min;
            Console.Write("Enter the hour: ");
            hr = Console.ReadLine();
            Console.Write("Enter the minute: ");
            min = Console.ReadLine();
            time(hr, min);
            Console.ReadKey();
        }
    }
}
