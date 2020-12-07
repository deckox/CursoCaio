using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Números
            1. Imprima o resultado das operações soma, divisão e subtração entre os seguintes números:
            a) 1 e 9
            b) 109 e 90
            c) 1,87 e 9,12
            d) 9223372036854775807 e -9223372036854775808*/

            var one = 1;
            var nine = 9;
            var somaOneNine = one + nine;
            var divisaoOneNine = one / nine;
            var subOneNine = one - nine;

            var onehundrednine = 109;
            var ninety = 90;
            var soma10990 = onehundrednine + ninety;
            var divisao10990 = onehundrednine / ninety;
            var sub10990 = onehundrednine - ninety;

            double onepointeightyseven = 1.87;
            double ninepointtwelve = 9.12;
            var soma187912 = onepointeightyseven + ninepointtwelve;
            var divisao187912 = onepointeightyseven / ninepointtwelve;
            var sub187912 = onepointeightyseven - ninepointtwelve;

            var d1 =  9223372036854775807;
            var d2 = -9223372036854775808;
            var somad12 = d1 + d2;
            var divisaod12 = d1 / d2;
            var subd12 = d1 - d2;




            Console.WriteLine(one + " + " + nine + " = " + somaOneNine);
            Console.WriteLine(one + " / " + nine + " = " + divisaoOneNine);
            Console.WriteLine(one + " - " + nine + " = " + subOneNine + "\n");
            Console.WriteLine(onehundrednine + " + " + ninety + " = " + soma10990);
            Console.WriteLine(onehundrednine + " / " + ninety + " = " + divisao10990);
            Console.WriteLine(onehundrednine + " - " + ninety + " = " + sub10990 + "\n");
            Console.WriteLine(onepointeightyseven + " + " + ninepointtwelve + " = " + soma187912);
            Console.WriteLine(onepointeightyseven + " / " + ninepointtwelve + " = " + divisao187912);
            Console.WriteLine(onepointeightyseven + " - " + ninepointtwelve + " = " + sub187912 + "\n");
            Console.WriteLine(d1 + " + " + d2 + " = " + somad12);
            Console.WriteLine(d1 + " / " + d2 + " = " + divisaod12);
            Console.WriteLine(d1 + " - " + d2 + " = " + subd12 + "\n");

        }
    }
}
