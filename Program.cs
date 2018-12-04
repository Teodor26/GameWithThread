using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Game.Library;

namespace GameWithThread
{    

    class Program
    {

        static void Main()
        {
            
            Console.WriteLine("Let's play a game. Input numbers from 1 to 1000");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number < 1 || number > 1000)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong range. You can input nubmers from 1 to 1000.");
                    Main();
                }
                else
                {
                    GameField game = new GameField(number);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That is not a number.Try again.");
                Main();
            }
            Console.ReadLine();
        }
    }
}
