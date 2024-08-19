using System;

namespace MiniProjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Which MiniProject you want to run\n");
                Console.WriteLine("1.Tables Calculation");
                Console.WriteLine("2.Fizz Buzz Game");
                Console.WriteLine("3.Exit");

                Console.Write("Type Your Choice: ");
                string num = Console.ReadLine();
                int choice;
                bool success = int.TryParse(num, out choice);

                if (success)
                {
                    switch (choice)
                    {
                        case 1:
                            MiniProjects.Table.TimesTableCalculation();
                            break;
                        case 2:
                            MiniProjects.FizzBuzzGame.BuzzFizz();
                            break;
                        case 3:
                            Console.WriteLine("Thank you!!!");
                            return;
                            break;
                        default:
                            Console.WriteLine("Wrong Input. OverFlow Exception");
                            break;
                    }
                }
                else
                {
                    return;
                }
            } while (true);
            

            
            
        }
    }
   
}