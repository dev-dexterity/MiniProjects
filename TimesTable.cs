using System;

namespace MiniProjects
{
    public class Table
    {
        public static void TimesTableCalculation()
        {
            Console.Write("Type the number you want the table of: ");
            string value = Console.ReadLine();
            int tableNum;
            bool success = int.TryParse(value, out tableNum);

            if (success)
            {
                Console.WriteLine("Successful, {0} ", tableNum);
            }
            else
            {
                Console.WriteLine("Error Conversion Exception");
            }

            

            for(int i = 1;i <= 10; i++)
            {
                int result = tableNum * i;
                Console.WriteLine("{0} * {1} = {2} ", tableNum, i, result);
            }
        }
    }
}