using System;
using System.Collections.Generic;

namespace RestrictionGenerics.Services
{
    class CalculationService
    {
        public int Max(List<int> lista)
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia!");
            }

            int max = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > max)
                {
                    max = lista[i];
                }
            }
            return max;
        }
    }
}
