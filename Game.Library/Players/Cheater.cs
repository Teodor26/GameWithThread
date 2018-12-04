using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library.Players
{
    public class Cheater : BasePlayer
    {
        private int CheaterNumber;
        public override void Go(HashSet<int> GuessedNumbers)
        {
            
                Random rand = new Random();
               CheaterNumber = rand.Next(1, 1000);
                do
                {
                if (GuessedNumbers.Contains(CheaterNumber))
                    CheaterNumber = rand.Next(1, 1000);
                else
                    break;
                } while (!GuessedNumbers.Contains(CheaterNumber));

                GuessedNumbers.Add(CheaterNumber);
                Console.WriteLine("Cheater {0}", CheaterNumber);           

           
        }
    }
}
