using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IExecute
    {
        public void Execute()
        {
            CountCapitalsLetters();
        }

        public static void CountCapitalsLetters()
        {
            Console.WriteLine("Please enter your sentence:");
            string userInput = Console.ReadLine();
            int countOfCapitalLetters = 0;

            foreach (char capitals in userInput)
            {
                if (char.IsLetter(capitals) && char.IsUpper(capitals))
                {
                    countOfCapitalLetters++;
                }
            }

            Console.WriteLine($"There are {countOfCapitalLetters} Letters are in the sentence...\n");
        }
    }
}