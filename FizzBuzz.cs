using System;

namespace MiniProjects
{
    public class FizzBuzzGame()
    {
        public static void BuzzFizz()
        {
            Console.Write("Type the last number of the range staring from one: ");
            string num = Console.ReadLine();
            int rangeNum;
            bool success = int.TryParse(num, out rangeNum);
            if (success) 
            {
                for (int i = 1; i <= rangeNum; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Great! This is a FIZZBUZZ!!! {0} " +
                            "is divisible by both the numbers 3 & 5", i);
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("This is a FIZZ! {0} is divisible by 3", i);
                    }
                    else if (i % 5 == 0)
                    {

                        Console.WriteLine("This is a BUZZ! {0} is divisible by 5", i);
                    }
                    else
                    {
                        Console.WriteLine("This number: {0} is not divisible by both the numbers", i);
                    }
                    
                }
            }
            
        }
    }
}