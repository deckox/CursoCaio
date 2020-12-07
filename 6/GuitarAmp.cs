using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    public class GuitarAmp : Equalizer
    {
        public string Marca;
        public string Modelo;
        public string Cor;
        public int Voltagem;
        public int Watts;

        public void LigarDistorcao()
        {
            Console.WriteLine("Distorcao Ligada!");
        }

        public void DesligarDistorcao()
        {
            Console.WriteLine("Distorcao Desligada!");
        }

        public void LigarOverdrive()
        {
            Console.WriteLine("Overdrive Ligado!");
        }

        public void DesligarOverdrive()
        {
            Console.WriteLine("Overdrive Desligado!");
        }
    }
}
