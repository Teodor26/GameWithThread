using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Library.Players
{
    public class Note : BasePlayer
    {
        private HashSet<int> NoteList = new HashSet<int>();
        private int NoteNumber;
        public override void Go(HashSet<int> GuessedNumbers)
        {
            int NoteNumber;
            Random rand = new Random();
            do
            {
                NoteNumber = rand.Next(1, 1000);
            } while (!NoteList.Contains(NoteNumber));

            GuessedNumbers.Add(NoteNumber);
            Console.WriteLine("NotePlayer {0}", NoteNumber);
        }
    }
}
