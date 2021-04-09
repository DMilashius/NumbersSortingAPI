using NumbersSortingAPI.Domain.Models;
using NumbersSortingAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersSortingAPI.Services
{
    public class BubbleSort : IAlgorithmsService
    {
        Stopwatch stopWatch = new Stopwatch();
        public Algorithm Sort(int[] input)
        {
            stopWatch.Start();
            for (int j = 0; j <= input.Length - 2; j++)
            {
                for (int i = 0; i <= input.Length - 2; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = temp;
                    }
                }
            }
            stopWatch.Stop();
            return new Algorithm { AlgorithmName = "Bubble Sort Algorithm", SortedNumbers = input, ElapsedTime = stopWatch.Elapsed};
        }
    }

    public class SelectionSort : IAlgorithmsService
    {
        Stopwatch stopWatch = new Stopwatch();
        public Algorithm Sort(int[] input)
        {
            stopWatch.Start();
            for (var i = 0; i < input.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
            stopWatch.Stop();
            return new Algorithm { AlgorithmName = "Selection Sort Algorithm", SortedNumbers = input, ElapsedTime = stopWatch.Elapsed };
        }
    }
}
