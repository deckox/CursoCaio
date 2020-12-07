using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    public class KeyboardAmp : Equalizer
    {
        public string Marca;
        public string Modelo;
        public int Voltagem;
        public int Watts;

        public void HiMid()
        {
            Console.WriteLine("HiMid Adicionado!");
        }

        public void Reverb()
        {
            Console.WriteLine("Reverb Adicionado!");
        }
    }
}
