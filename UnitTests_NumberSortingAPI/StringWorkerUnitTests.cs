using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NumbersSortingAPI.Domain.Services;
using NumbersSortingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests_NumberSortingAPI
{
    [TestClass]
    public class StringWorkerUnitTests
    {
        [TestMethod]
        public void ConverToIntArray_ShouldReturnIntArray()
        {
            string input = "1 20 m50 cg 600 -40";
            int[] array = new int[] { 1, 20, 600, -40 };
            StringWorkerService stringWorkerService = new StringWorkerService();

            var returned = stringWorkerService.ConverToIntArray(input);
            
            CollectionAssert.AreEqual(array, returned.ToArray());
        }
    }
}
