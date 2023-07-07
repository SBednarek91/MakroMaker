using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakroMaker
{
    internal class Messages
    {
        public void Welcomemessage()
        {
            Console.WriteLine("**********************");
            Console.WriteLine(" Witaj w Makro Maker!");
            Console.WriteLine("**********************");
            Console.WriteLine();
            Console.WriteLine("Ten program ma za zadanie dobrać odpowiednie makro składniki do Twojego zapotrzebowania.");
            Console.WriteLine("Aby przejść do kwestionariusza wciśnij ENTER");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
