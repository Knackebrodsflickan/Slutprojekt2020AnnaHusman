using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020AnnaHusman
{
    class Human : CharacterClass
    {
        // The max hp for any character should probs be like, 100 hp7
        // olika mekanik

        public Human()
        {

            hp = 100;

        }
        public int Mischief()
        {
            //return generator.Next(0, 15); // Mischief is a trait that basically means that sometimes the humans disobeys your order? or depending on the number the human can unlock new alternative ways to handle a situation. 
            return 0;
        }
    }
}
