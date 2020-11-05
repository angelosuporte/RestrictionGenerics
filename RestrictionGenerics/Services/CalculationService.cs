using System;
using System.Collections.Generic;

namespace RestrictionGenerics.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> lista) where T : IComparable 
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia!");
            }

            T max = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].CompareTo(max) > 0)
                {
                    max = lista[i];
                }
            }
            return max;
        }
    }
}
