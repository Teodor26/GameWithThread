using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library.Players
{
    public class Uber : BasePlayer
    {
        private int UberNumber = 0;        
        public override void Go(HashSet<int> GuessedNumbers)
        {
            UberNumber += 1;           
            GuessedNumbers.Add(UberNumber);
            Console.WriteLine("Uber {0}",UberNumber);
        }
    }
}
