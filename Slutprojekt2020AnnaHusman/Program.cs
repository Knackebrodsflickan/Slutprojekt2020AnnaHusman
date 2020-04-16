using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020AnnaHusman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! To the game of Raccoon in Hedges: the Game");
            Console.WriteLine("The game where you do absolutley nothing and yet everything, with no conlusive plot at all ");
            Console.ReadKey();

            Console.WriteLine("Choose one of the following classes:");
            Console.WriteLine("Wizard or Human");
            Console.WriteLine("Write your elected class:");
            string Class = Console.ReadLine(); // i knooow its better to make them write 1 or 2 but its more fun this way!!!!! ( and im to lazy to change it ) 
            if (Class != "Wizard" && Class != "Human") //den här säger att om du inte skriver in någon av klasserna utan skriver in fel eller försöker trolla får du en "oh no" thats wrong". 
            {
                Console.WriteLine("Uh oh! thats not one of the classes avaliable, please try again");
                Console.ReadKey();
            }
            if(Class == "Wizard")
            {
                Console.WriteLine("You have chosen: Wizard!");
                Console.WriteLine("Please choose a sub class: Necromancer or Magician");
                String SubClassWizard = Console.ReadLine();
                if(SubClassWizard == "Necromancer")
                {
                    Console.WriteLine("You have chosen the subclass Necromancer!");
                }
            }

            /*List<string> nameList = new List<string>();

            nameList.Add("Stephan");
            nameList.Add("Carl");
            nameList.Add("Bob");
            nameList.Add("Karl");
            nameList.Add("Yuan");

            Console.WriteLine("Choose a name from this list"); */
        }
    }
}
