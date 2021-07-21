using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            double OValue;
            double NValue;
            bool x = true;

            while (x)
            {
                Console.WriteLine("Please input a measurement type. The options are inch, foot, fidget spinner, and meme. (Case sensitive)");
                type = Console.ReadLine();

                Console.WriteLine("Please input the measurement amount.");
                OValue = double.Parse(Console.ReadLine());

                if (type == "inch")
                {
                    NValue = OValue * 3.5;
                    Console.WriteLine("" + OValue + " inches is equal to " + NValue + " fidget spinners.");
                }

                else if (type == "foot")
                {
                    NValue = OValue * 5;
                    Console.WriteLine("" + OValue + " feet is equal to " + NValue + " memes.");
                }

                else if (type == "fidget spinner")
                {
                    NValue = OValue / 3.5;
                    Console.WriteLine("" + OValue + " fidget spinners is equal to " + NValue + " inches.");
                }

                else
                {
                    NValue = OValue / 5;
                    Console.WriteLine("" + OValue + " memes is equal to " + NValue + " feet.");
                }

                
                Console.WriteLine("Would you like to do another calculation? Type yes or no (case sensitive)");
                string answer;

                answer = Console.ReadLine();

                if (answer == "yes")
                {
                    x = true;
                }
                else
                {
                    x = false;
                }
            }
        }
    }
}
