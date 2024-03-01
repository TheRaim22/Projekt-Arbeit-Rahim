using System;

namespace Projekt_Arbeit_Rahim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int userInput;

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Willkommen zum The Binding of Isaac Wiki.");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                Console.WriteLine("----------------------------------------");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("1. Item Namen Liste \n2. Item Info \n3. Clear \n4. Beenden");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Eingabe:");


                if (int.TryParse(Console.ReadLine(), out userInput))

                {
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("Option 1 ausgewählt");
                            break;
                        case 2:
                            Console.WriteLine("Option 2 ausgewählt");
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            
                            Console.WriteLine("Ungültige Eingabe. Kein Item gefunden.\n bitte einde taste drücken zum fortfahren");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
            }
        }
    }
}
