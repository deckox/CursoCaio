using System;
using System.Globalization;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Data e Hora
             1. Pegue a hora atual do sistema, armazene numa variável e imprima na tela em qualquer formato
             2. Pegue a hora atual do sistema, armazene numa variável e imprima na tela no formato de dd/mm/aaaa
             3. Pegue a hora atual do sistema, armazene numa variável, adicione um dia e imprima na tela em qualquer formato
             4. Pegue a hora atual do sistema, armazene numa variável, subtraia 4 horas e imprima na tela em qualquer formato
             5. Dado o seguinte texto "20201021T172410" (21 de outubro de 2020, 17 horas, 24 minutos e 10 segundos), converta em uma variável do tipo DateTime e imprima na tela.
            */

           
            var dateAnyFormat = DateTime.Now;
            var dateDDMMAA = dateAnyFormat.ToString("dd/MM/yyyy");
            var datePlusOneDay = dateAnyFormat.AddDays(1);
            var dateLessFourHours = dateAnyFormat.AddHours(-4);
            var date = "20201021T172410";
           

            Console.WriteLine(dateAnyFormat);
            Console.WriteLine(dateDDMMAA);
            Console.WriteLine(datePlusOneDay);
            Console.WriteLine(dateLessFourHours);
            
        }
    }
}
