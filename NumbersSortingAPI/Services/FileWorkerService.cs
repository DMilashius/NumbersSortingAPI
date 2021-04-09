using NumbersSortingAPI.Domain.Models;
using NumbersSortingAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Services
{
    public class FileWorkerService : IFileWorker
    {
        public List<string> GetLatestFileData(string directory)
        {
            if (!File.Exists(Path.Combine(directory, "result.txt")))
                return null;

            List<string> readData = new List<string>();

            using (StreamReader reader = File.OpenText(Path.Combine(directory, "result.txt")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    readData.Add(line);
                }
            }
            return readData;
        }

        public async Task SaveToFile(string directory, IEnumerable<Algorithm> algorithmModels)
        {
            using StreamWriter outputFile = new StreamWriter(Path.Combine(directory, "result.txt"));
            {
                foreach(var algorithmData in algorithmModels)
                {
                    string line = $"{algorithmData.AlgorithmName}: {algorithmData.GetSortedNumbersString()}. {algorithmData.GetElapsedMilliseconds()}";
                    await outputFile.WriteLineAsync(line);
                }
            }
        }
    }
}
