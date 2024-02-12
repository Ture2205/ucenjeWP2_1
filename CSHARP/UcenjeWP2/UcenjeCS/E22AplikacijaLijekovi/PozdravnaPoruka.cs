using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E22AplikacijaLijekovi
{
    internal class PozdravnaPoruka
    {
        public static void Poruka()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("██░░░░░██░░░░░██░░░████░░░██░░██░░░░░░");
            Console.WriteLine("██░░░░░██░░░░░██░░░██░░░░░██░█░░░░░░░░");
            Console.WriteLine("██░░░░░██░░░░░██░░░████░░░██░░░░░░░░░░");
            Console.WriteLine("██░░░░░██░░█░░██░░░██░░░░░██░█░░░░░░░░");
            Console.WriteLine("█████░░██░░█████░░░████░░░██░░██░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("******************************* LIJEK APP *************************************");
            Console.ResetColor(); // Dodano: resetiranje boje pozadine

            GlavniIzbornik.Izbornik();

        }
    }
}
