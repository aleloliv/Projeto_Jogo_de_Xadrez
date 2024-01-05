using System;
using System.Collections.Generic;
using System.Globalization;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);

            Console.WriteLine("Posição: " + p);

            Console.ReadLine();
        }
    }
}
