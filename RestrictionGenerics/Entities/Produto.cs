﻿using System;
using System.Globalization;

namespace RestrictionGenerics.Entities
{
    class Produto : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Erro de comparação: o argumento não é Produto");
            }
            Produto outro = obj as Produto;
            return Preco.CompareTo(outro.Preco);

        }
    }
}
