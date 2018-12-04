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
                Random rand = new Random();
                do
                {
                    NoteNumber = rand.Next(1, 1000);
                if (NoteList.Contains(NoteNumber))
                {
                    NoteNumber = rand.Next(1, 1000);
                }
                else
                {
                    NoteList.Add(NoteNumber);
                    break;
                }
                } while (!NoteList.Contains(NoteNumber));

                GuessedNumbers.Add(NoteNumber);
                Console.WriteLine("NotePlayer {0}", NoteNumber);
            
        }
    }
}
