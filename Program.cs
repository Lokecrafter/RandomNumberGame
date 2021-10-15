using System;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNumb;

            //Förklaringar till hur spelet fungerar
            Console.WriteLine("Välkommen till Slumpspelet");
            Console.WriteLine("Ditt mål är att gissa dig till ett tal som jag skapar slumpmässigt");
            Console.WriteLine("Talet jag väljer är ett tal mellan 1 och 100");
            Console.WriteLine("Får du rätt tal så vinner du spelet och du får veta hur många försök som krävdes.");
            Console.WriteLine("Spelet börjar nu...");

            randNumb = random.Next(1, 100);
            int tries = 1;

            //Programmets loop som fortsätter tills användaren har rätt tal
            while (true){
                Console.Write("Gissa ett heltal mellan 1 och 100: ");
                string usrGuess = Console.ReadLine();
                int numbGuess;
                //Säger till användaren, om den har skrivit in något annat än ett heltal, att den måste skriva in ett heltal
                if(!int.TryParse(usrGuess, out numbGuess)){
                    Console.WriteLine("Det där var inte ett heltal försök igen!");
                    continue;
                }

                if(numbGuess == randNumb){
                    //Här vinner man
                    break;
                }
                else if(numbGuess > randNumb){
                    Console.WriteLine("Fel svar! Din gissning är för hög.");
                }
                else{
                    Console.WriteLine("Fel svar! Din gissning är för låg.");
                }

                tries++;
            }

            //Vinstmeddelanden
            Console.Write("Grattis! Du gissade rätt. Du behövde ");
            Console.Write(tries);
            Console.WriteLine(" försök för att klara spelet.");
        }
    }
}
