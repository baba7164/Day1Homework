using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace ProductLibrary.Tests
{
    [TestClass()]
    public class CountSumTests
    {
        [TestMethod()]
        public void GetResultSetTest_Cost()
        {
            //arange
            var groupSum = new CountSum();
            var groupCount = 3;
            var groupNumber = new int[] { 6, 15, 24, 21 };

            //act
            var result = groupSum.GetResultSet(groupCount);

            //assert
            groupNumber.ToExpectedObject().ShouldEqual(result);
        }

        [TestMethod()]
        public void GetResultSetTest_Revenue()
        {
            //arange
            var groupSum = new CountSum();
            var groupCount = 4;
            var groupNumber = new int[] { 50, 66, 60 };

            //act
            var result = groupSum.GetResultSet(groupCount);

            //assert
            groupNumber.ToExpectedObject().ShouldEqual(result);
        }
    }
}