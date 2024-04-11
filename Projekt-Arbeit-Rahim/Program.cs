
using Projekt_Arbeit_Rahim.Database;
using System;

namespace Projekt_Arbeit_Rahim
{
    internal class Program
    {
        static DatabaseDefiner dbContext = new DatabaseDefiner();
        static void Main(string[] args)
        {
            while (true)
            {
                int input;

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Willkommen zum The Binding of Isaac Wiki.");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                Console.WriteLine("----------------------------------------");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("1. Item suchen\n2. Item hinzufügen\n3. Clear\n4. Beenden");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Eingabe:");
                int selec;
                if (int.TryParse(Console.ReadLine(), out selec))
                {
                    switch (selec)
                    {
                        case 1:
                            Console.WriteLine("Geben Sie den Namen des Items ein, nach dem Sie suchen möchten:");
                            string itemName = Console.ReadLine();
                            BaseItem? foundItem = dbContext.BaseItems.FirstOrDefault(x => x.Name == itemName);
                            if (foundItem != null)
                            {
                                Console.WriteLine($"Name: {foundItem.Name}, Effekt: {foundItem.Effekt}");
                            }
                            else
                            {
                                Console.WriteLine("Das gesuchte Item wurde nicht gefunden.");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Geben Sie den Namen des neuen Items ein:");
                            string newItemName = Console.ReadLine();
                            Console.WriteLine("Geben Sie den Effekt des neuen Items ein:");
                            string newItemEffect = Console.ReadLine();
                            dbContext.ModItems.Add(new ModItem { Name = newItemName, Effekt = newItemEffect });
                            dbContext.SaveChanges();
                            Console.WriteLine("Das neue Item wurde hinzugefügt.");
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine der verfügbaren Optionen ein.");
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
