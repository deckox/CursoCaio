using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    public class BassAmp : Equalizer
    {
        public string Marca;
        public string Modelo;
        public int Voltagem;
        public int Watts;

        public void Active()
        {
            Console.WriteLine("Modo baixo ativo ligado!");
        }

        public void Passive()
        {
            Console.WriteLine("Modo baixo passivo ligado!");
        }

    }
}
