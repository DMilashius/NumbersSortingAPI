using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NumbersSortingAPI.Domain.Models;
using NumbersSortingAPI.Domain.Services;
using NumbersSortingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortingAlgorithmsController : ControllerBase
    {
        private readonly IOptions<FileWorker> _fileWorkerOptions;
        private readonly IEnumerable<IAlgorithmsService> _algorithmsService;
        private readonly IStringWorker _stringWorkerService;
        private readonly IFileWorker _fileWorkerService;
        public SortingAlgorithmsController
            (IOptions<FileWorker> fileWorkerOptions,
            IEnumerable<IAlgorithmsService> algorithmsService,
            IStringWorker stringWorkerService,
            IFileWorker fileWorkerSerivce)
        {
            _fileWorkerOptions = fileWorkerOptions;
            _algorithmsService = algorithmsService;
            _stringWorkerService = stringWorkerService;
            _fileWorkerService = fileWorkerSerivce;
        }

        [HttpGet]
        public List<string> Get()
        {
            var data = _fileWorkerService.GetLatestFileData(_fileWorkerOptions.Value.FileDirectory);

            return data;
        }

        [HttpPost]
        public IEnumerable<Algorithm> Sort(string input)
        {
            List<Algorithm> algorithmModels = new List<Algorithm>();

            var numbInputArray = _stringWorkerService.ConverToIntArray(input).ToArray();

            foreach( var service in _algorithmsService)
            {
                algorithmModels.Add(service.Sort(numbInputArray));
            }

            _fileWorkerService.SaveToFile(_fileWorkerOptions.Value.FileDirectory, algorithmModels);
            
            return algorithmModels; 
        }
    }
}
