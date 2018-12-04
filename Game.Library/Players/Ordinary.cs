using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library.Players
{
    public class Ordinary : BasePlayer
    {        
        public override void Go(HashSet<int> GuessedNumbers)
        {
            Random rand = new Random();
            lock (lockObj)
            {                
                int result = rand.Next(1, 1000);
                GuessedNumbers.Add(result);
                Console.WriteLine("Ordinary {0}", result);
            }
        }
    }
}
