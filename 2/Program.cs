using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2. Obtenha o resto da divisão entre os números e imprima na tela:
             a) 1 e 1
             b) 2 e 29173

             */

            var one = 1;
            var um = 1;
            var restoOne = one % um;

            var two = 2;
            var two9173 = 29173;
            var restoTwo = two % two9173;

            Console.WriteLine(one + " % " + um + " = " + restoOne);
            Console.WriteLine(two + " % " + two9173 + " = " + restoTwo);
        }
    }
}
