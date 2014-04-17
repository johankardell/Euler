using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    public class CalculatorEngine
    {
        private int _maxValue;

        public CalculatorEngine(int maxValue)
        {
            _maxValue = maxValue;
        }

        public int GetSumMultiplesOf(params int[] multiples)
        {
            return GetMultiplesOf(multiples).Sum();
        }

        /// <summary>
        /// Classic style
        /// </summary>
        public List<int> GetMultiplesOf(params int[] multiples)
        {
            var values = new List<int>();
            for (int h = 0; h < multiples.Count(); h++)
            {
                for (int i = 1; i < _maxValue; i++)
                {
                    if (i % multiples[h] == 0)
                        values.Add(i);
                }
            }
            // Avoid numbers that are multiples of both 3 and 5 to be returned twice
            return values.Distinct().ToList();
        }
    }
}
