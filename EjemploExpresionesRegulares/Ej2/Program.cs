using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //encontrar todas las subcadenas que contengan digitos no numericos 
            //y la posición de cada coincidencia.
            string texto = "2356ab45623FG523DC23C64223EFD47";

            //letras[a-z,A-Z] que se repiten al menos una vez {1,}
            string patron = "[a-z,A-Z]{1,}";
            // se podría escribir tambien
            //string patron = "([a-z,A-Z]{1,})";

            Match m = Regex.Match(texto, patron);

            Console.WriteLine($"{"coincidencia",20}:{"posición",10}");
            while (m.Success)
            {
                Console.WriteLine($"{m.ToString(),20}:{m.Index,10}");
                m = m.NextMatch();
            }
            /*
        coincidencia:  posición
                  ab:         4
                  FG:        11
                  DC:        16
                   C:        20
                 EFD:        26
            */

            Console.ReadKey();
        }
    }
}
