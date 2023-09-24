using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //encontrar todas las coincidencias y la posición.
            string texto = "235645623523236422347";
            
            string patron = "23[0-9]";
            
            Match m=Regex.Match(texto, patron);

            Console.WriteLine($"{"coincidencia",20}:{"posición",10}");
            while (m.Success)
            {
                Console.WriteLine($"{m.ToString(),20}:{m.Index,10}");
                m =m.NextMatch();
            }
            /*
                 coincidencia:  posición
                 235:         0
                 235:         7
                 232:        10
                 234:        17
            */

            Console.ReadKey();
        }
    }
}
