using System;

namespace Bonus_Score
{
    class Bonus_Score
    {      
        static void bonus(double score)
        {
            double bonus_per = 0, new_score = 0;
            string tostr = score.ToString();
            if (score <= 100)
            {
                new_score = score + 10;
                if (tostr.EndsWith("5") == true)
                {
                    new_score = new_score + 5;
                    Console.Write("\nBonus: 15");
                    Console.Write("\nNew Score: " + new_score);
                }
                else if (new_score % 2 == 0) 
                {
                    new_score = new_score + 4;
                    Console.Write("\nBonus: 14");
                    Console.Write("\nNew Score: " + new_score);
                }                 
                else
                {
                    Console.Write("\nBonus: 10");
                    Console.Write("\nNew Score: " + new_score);
                }
            }
            else if ((score > 100) && (score <= 1000))
            {
                bonus_per = 0.30 * score;
                new_score = score + bonus_per;
                Console.Write("\nBonus: " + bonus_per);
                Console.Write("\nNew Score: " + new_score);
            }
            else
            {
                bonus_per = 0.20 * score;
                new_score = score + bonus_per;
                Console.Write("\nBonus: " + bonus_per);
                Console.Write("\nNew Score: " + new_score);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the score: ");
            double score = double.Parse(Console.ReadLine());
            bonus(score);
            Console.ReadKey();
        }
    }
}
