using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Domain.Services
{
    public interface IStringWorker
    {
        IEnumerable<int> ConverToIntArray(string input);
    }
}
