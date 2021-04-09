using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Domain.Models
{
    public class Algorithm
    {
        public string AlgorithmName { get; set; }
        public int[] SortedNumbers { get; set; }
        public TimeSpan ElapsedTime { get; set; }

        public string GetSortedNumbersString()
        {
            if (SortedNumbers == null)
                return "There are no sorted numbers";

            return string.Join(" ", SortedNumbers);
        }

        public string GetElapsedMilliseconds()
        {
            if (ElapsedTime.Ticks == 0)
                return "Time wasn't measured";

            string elapsedMS = $"Algorithm duration: {ElapsedTime.TotalMilliseconds.ToString()} ms.";

            return elapsedMS;
        }
    }
}
