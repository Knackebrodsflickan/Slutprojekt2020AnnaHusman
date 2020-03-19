using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020AnnaHusman
{
    class CharacterClass
    {
        static Random generator = new Random();

        public int hp;
        public string name;
        public int minDamage;
        public int maxDamage;

       public void getName()
        {
            Console.WriteLine("Name: {0}", name);
        }


        
    }
}
