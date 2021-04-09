using NumbersSortingAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Services
{
    public class StringWorkerService : IStringWorker
    {
        public IEnumerable<int> ConverToIntArray(string input)
        {
            if (String.IsNullOrEmpty(input))
                yield break;

            foreach (var s in input.Split(' '))
            {
                int num;
                if (int.TryParse(s, out num))
                    yield return num;
            }
        }
    }
}
