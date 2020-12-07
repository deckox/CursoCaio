using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Texto
                1. Junte as palavras "programinha" e "maneiro" de forma que o resultado seja "programinha maneiro" e imprima o resultado na tela.
                2. Dada a palavra "PROGRAMÃO" (em maiúsculo mesmo), imprima na tela com todas a letras minúsculas.
                3. Junte as seguintes variáveis em 1 variável do tipo string e imprima o resultado na tela.
                int numero = 10;
                string texto = "texto";
                string resultado = numero + texto; (será que funciona assim?)
                4. Escreva uma palavra qualquer, pegue o primeiro caracter dela, coloque dentro de uma variável e imprima na tela.
                5. Compare as palavras "texto" e "TEXTO" para ver se elas são iguais, de uma forma que o resultado seja falso.
                6. Compare as palavras "texto" e "TEXTO" para ver se elas são iguais, de uma forma que o resultado seja verdadeiro. Dica: ignore o case sensitive

            */

            //1
            var programinha = "programinha";
            var maneiro = "maneiro";

            //2
            var programao = "PROGRAMÃO";

            //3
            int numero = 10;
            var texto = "texto";
            var resultado = numero + texto;

            //4
            var palavra = "tricolor";

            //5
            var textoMin = "texto";
            var textoMax = "TEXTO";
            bool resultadoTextoMaxMin;

           

            Console.WriteLine("1 - " +  programinha + " " + maneiro + "\n");
            Console.WriteLine("2 - " +  programao.ToLower() + "\n");
            Console.WriteLine("3 - " + resultado + "\n");
            Console.WriteLine("4 - " + palavra.Substring(0,1) + "\n");
          
            if (textoMin != textoMax)
            {
               resultadoTextoMaxMin = false;
               Console.WriteLine("5 - " + resultadoTextoMaxMin + "\n");

            }

            if (textoMin == textoMax.ToLower())
            {
                resultadoTextoMaxMin = true;
                Console.WriteLine("6 - " + resultadoTextoMaxMin + "\n");
            }
        }
    }
    
}
