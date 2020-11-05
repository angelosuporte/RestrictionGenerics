using System;
using System.Collections.Generic;
using RestrictionGenerics.Services;
using RestrictionGenerics.Entities;
using System.Globalization;

namespace RestrictionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Informe a quantidade de Números: ");
            int quantidadeNumero = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeNumero; i++)
            {
                string[] vetor = Console.ReadLine().Split(',');
                string nome = vetor[0];
                double preco = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                lista.Add(new Produto(nome, preco));
            }

            CalculationService calculationService = new CalculationService();

            Produto max = calculationService.Max(lista);

            Console.Write("Max: ");
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
