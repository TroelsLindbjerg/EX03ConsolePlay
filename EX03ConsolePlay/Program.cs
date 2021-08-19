using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03ConsolePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Farven på baggrund tekst
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            //Console størrelse            
            Console.WindowHeight = 30;
            Console.WindowWidth = 100;
            //Spil en lyd første tal=Hz andet tal=millisekunder
            Console.Beep(9000, 1000);





        }
    }
}
