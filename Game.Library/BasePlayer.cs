using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library
{
    public abstract class BasePlayer
    {
        public static object lockObj = new object();
        public abstract void Go(HashSet<int> GuessedNumbers);
    }
}
