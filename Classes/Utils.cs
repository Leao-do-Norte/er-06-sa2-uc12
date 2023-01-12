using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog_backend.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto, int repeticao, string simbolo, string frase){
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write($"{texto} ");
            for (var i = 0; i < repeticao; i++)
            {
                Console.Write($"{simbolo}");
                Thread.Sleep(300);
            }
            Console.WriteLine($" {frase}");
            Thread.Sleep(300);
            Console.ResetColor();
            Console.Clear();
        }
    }
}