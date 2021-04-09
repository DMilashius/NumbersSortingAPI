using NumbersSortingAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Domain.Services
{
    public interface IAlgorithmsService
    {
        //IEnumerable<AlgorithmModel> GetLatestSavedFileData();
        Algorithm Sort(int[] numbers);
    }
}
