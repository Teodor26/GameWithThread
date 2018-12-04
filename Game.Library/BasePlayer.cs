using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library
{
    public abstract class BasePlayer
    {
        
        public abstract void Go(HashSet<int> GuessedNumbers);
    }
}
