using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Characteradventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playAgain = ("yes");


            while (playAgain.ToLower() == "yes")
            {
                Console.WriteLine("Enter the strength of your character");
                int strength = int.Parse((Console.ReadLine()));
                Console.WriteLine("Enter the agility of your character");
                double agility = double.Parse((Console.ReadLine()));
                Console.WriteLine("How much gold does your character start of with?");
                int gold = int.Parse((Console.ReadLine()));
                Console.WriteLine("What is your characters intelligence?");
                double intel = double.Parse((Console.ReadLine()));


                Console.WriteLine("Do you want explore a cave? (yes/no)");
                string choiceAdventure1 = Console.ReadLine();
                if (choiceAdventure1.ToLower()== "yes")
                {
                    strength += 4;
                    Console.WriteLine("You found a sword increasing your strength by 4!\n-");
                }
                else
                {
                    Console.WriteLine("You chose the safe option\n-");
                }
                Console.WriteLine("Do you want to train (yes/no)");
                string choiceAdventure2 = Console.ReadLine();
                if (choiceAdventure2.ToLower() == "yes")
                {
                    agility *= 1.5;
                    Console.WriteLine("You trained and increased your agility by 50%\n-");
                }
                else
                {
                    agility -= 5;
                    Console.WriteLine("Lazy... You lost agility\n-");
                }
                Console.WriteLine("Do you want to buy a potion for 40 gold (yes/no)");
                string choiceAdventure3 = Console.ReadLine();    
                if (choiceAdventure3.ToLower() == "yes")
                {
                    gold -= 40;
                    Console.WriteLine("You bought a potion for 40 gold \n-");
                    intel -= 5;
                    Console.WriteLine("The potion did not taste nice...You lost 5 intelligence\n-");
                }
                else
                {
                    intel += 5;
                    Console.WriteLine("Smart choice, Intelligence plus 5\n");
                }
                Console.WriteLine("Do you want to fight in a duel for money? (yes/no)");
                string choiceAdventure4 = Console.ReadLine();
                if (choiceAdventure4.ToLower() == "yes")
                {
                    gold *= 2;
                    Console.WriteLine("You won a duel and doubled your gold\n-");
                }
                else
                {
                    Console.WriteLine("You chose not to take the risk\n-");
                }

                gold -= 5;
                Console.WriteLine("You unfortunately cant make a choice here. Lose 5 gold for tax\n-");



                double avgStats = (strength + agility + intel) / 3;

                Console.WriteLine($"Final stats:\nStrength: {strength}\nAgility: {agility}\nGold: {gold}\nYour intelligence is now {intel}\nYour Average stats combined in total are: {avgStats}");

                var stats = new List<double> { strength, agility, intel };
                double minStat = stats.Min();
                double maxStat = stats.Max();

                Console.WriteLine($"Your best stat value is {maxStat}\nYour worst stat value is: {minStat}");

                Console.WriteLine("\nDo you want to play again (yes/no)");
                playAgain = Console.ReadLine();

            }
            Console.WriteLine("Thanks for playing");

            

        }
    }
}
