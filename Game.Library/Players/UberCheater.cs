using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library.Players
{
   public class UberCheater : BasePlayer
    {
        private int UberCheaterNumber=0;
        public override void Go(HashSet<int> GuessedNumbers)
        {
            UberCheaterNumber += 1;
            if (GuessedNumbers.Contains(UberCheaterNumber))
            {
                UberCheaterNumber += 1;
            }
            GuessedNumbers.Add(UberCheaterNumber);
            Console.WriteLine("UberCheater {0}", UberCheaterNumber);
            Console.WriteLine();
        }
    }
}
