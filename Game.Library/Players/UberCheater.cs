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
            lock (lockObj)
            {
                do
                {
                    if (GuessedNumbers.Contains(UberCheaterNumber))
                        UberCheaterNumber += 1;
                } while (!GuessedNumbers.Contains(UberCheaterNumber));
                GuessedNumbers.Add(UberCheaterNumber);
                Console.WriteLine("UberCheater {0}", UberCheaterNumber);
            }
        }
    }
}
