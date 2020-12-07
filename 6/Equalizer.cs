using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    public class Equalizer : Mixer
    {
        public string Marca;
        public string Modelo;
        public int Voltagem;
        public int Watts;

        public void Bass()
        {
            Console.WriteLine("Bass Aumentado");
        }

        public void Middle()
        {
            Console.WriteLine("Middle Aumentado");
        }

        public void Treble()
        {
            Console.WriteLine("Treble Aumentado");
        }
    }
}
