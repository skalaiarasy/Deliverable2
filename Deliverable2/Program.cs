using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputString;
            bool status = true;
            int helloCount = 0;
            int supCount = 0;
            int thereCount = 0;

            while (status)
            {
                Console.WriteLine("\nPlease enter the input to the bot");
                string inputString = Console.ReadLine();
                string convertedString = inputString.ToLower();
                if (convertedString == "hello")
                {
                    helloCount += 1;

                    if (helloCount == 1)
                    {
                        outputString = "\nHi Good to see you.";
                        Console.WriteLine(outputString);
                    }
                    else
                    {
                        Console.WriteLine("\nI'm  sorry  but you have already said that.");

                    }
                }
                else if (convertedString == "bye")
                {
                    outputString = "\nGood bye.";
                    Console.WriteLine(outputString);
                    break;
                }

                else if (convertedString == "sup")
                {
                    supCount += 1;

                    if (supCount == 1)
                    {
                        outputString = "\nI am good.";
                        Console.WriteLine(outputString);
                    }
                    else
                    {
                        Console.WriteLine("\nI'm  sorry  but you have already said that.");
                    }
                }
                else if (convertedString == "hello there")
                {
                    thereCount += 1;
                    if (thereCount == 1)
                    {
                        outputString = "\nGeneral kenobi.";
                        Console.WriteLine(outputString);
                    }
                    else
                    {
                        Console.WriteLine("\nI'm  sorry  but you have already said that.");
                    }
                }

                else
                {
                    Console.WriteLine("\nSorry wrong input : not in the list.");
                }

                Console.WriteLine("\nIf you want to say something else to the bot press 'yes' or 'y' otherwise press 'any key' to exit.  ");
                string respond = Console.ReadLine();
                if ((respond == "yes") || (respond == "y"))                                                    
                  
              
                {
                    status = true;                    
                }
                else
                {
                    status = false;
                }
            }
        }
    }
}
   

