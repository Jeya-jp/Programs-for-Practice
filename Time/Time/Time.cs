using System;
namespace Time
{
    class Program
    {
        static void time(string hour, string minuite)
        {
            string[] arr = {hour, minuite };
            int hr = int.Parse(arr[0]);
            int min = int.Parse(arr[1]);
            if (hr >= 0 && hr <= 11 && min >= 0 && min <= 59)
            {
                int add = min + 25;
                if (add > 59)
                {
                    add = add - 59;
                    hr++;
                    if (add <= 9)
                    {
                        Console.Write(hr + ":0" + add);
                    }
                    else
                    {
                        Console.Write(hr + ":" + add);
                    }
                }
                else
                {
                    Console.Write(hr + ":" + add);
                }
            }
            else if (hr >= 0 && hr <= 23 && min >= 0 && min <= 59)
            {
                int add = min + 25;
                {
                    if (add > 59 && hr == 23)
                    {
                        add = add - 60;
                        hr = 0;
                        if (add <= 9)
                        {
                            Console.Write(hr + ":0" + add);
                        }
                        else
                        {
                            Console.Write(hr + ":" + add);
                        }
                    }
                    else if (add > 59)
                    {
                        add = add - 59;
                        hr++;
                        if (add <= 9)
                        {
                            Console.Write(hr + ":0" + add);
                        }
                        else
                        {
                            Console.Write(hr + ":" + add);
                        }
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
