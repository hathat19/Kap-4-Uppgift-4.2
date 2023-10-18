using System;
using System.Diagnostics.Metrics;

namespace Uppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber = 0;
            string loop = "j";
            bool firstLoop = true;

            do
            {
                Console.WriteLine("Skriv in ett heltal:");
                int userInput = int.Parse(Console.ReadLine());

                
                
                if (firstLoop) //Är detta första gången som loopen skrivs? Gör då det största talet till talet som skrevs in
                {
                    biggestNumber = userInput;
                }
                else
                {
                    //Jämför nytt tal med tidigare största
                    biggestNumber = userInput > biggestNumber ? userInput : biggestNumber;
                }

                //Gör om loopen?
                Console.WriteLine("Vill du skriva in ett annat tal?"); 
                Console.WriteLine("[j]a eller [n]ej");
                loop = Console.ReadLine().ToLower();

                firstLoop = false;
            }
            while (loop != "n");

            //skriver ut det största talet
            Console.WriteLine($"Ditt största tal var {biggestNumber}");



            /*Skapa ett program där användaren ska skriva in ett heltal. Efter att hen har gjort det
ska programmet fråga om användaren vill skriva in ett heltal till eller inte.Användaren
ska fortsätta att få skriva in nya heltal ända tills hen inte vill göra det mer. När
användaren inte vill skriva in mer tal ska programmet skriva ut vilket som var det
största talet som användaren skrev in.*/
        }
    }
}