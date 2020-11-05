using System;
using System.Collections.Generic;
using RestrictionGenerics.Services;

namespace RestrictionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Console.Write("Informe a quantidade de Números: ");
            int quantidadeNumero = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeNumero; i++)
            {
                int cadaNumero = int.Parse(Console.ReadLine());
                lista.Add(cadaNumero);
            }

            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(lista);

            Console.Write("Max: ");
            Console.WriteLine(max);


        }
    }
}
