using NumbersSortingAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Domain.Services
{
    public interface IFileWorker
    {
        List<string> GetLatestFileData(string directory);
        Task SaveToFile(string directory, IEnumerable<Algorithm> algorithmModels);
    }
}
