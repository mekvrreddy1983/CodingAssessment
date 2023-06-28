using System;
using System.Collections.Generic;
using CodingAssessment.Refactor;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(-2, 0)]
        [InlineData(-3, 0)]
        [InlineData(-10, 0)]
        public void GetPeople_ReturnNoRowsForNegativeValues(int input, int expectedCollectionCount)
        {
            BirthingUnit irthingUnit = new BirthingUnit();
            List<People> items = irthingUnit.GetPeople(input);
            Assert.Equal(items.Count, expectedCollectionCount);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(10, 10)]
        public void GetPeople_ReturnCollectionForPositiveInputValue(int input, int expectedCollectionCount)
        {
            BirthingUnit irthingUnit = new BirthingUnit();
            List<People> items = irthingUnit.GetPeople(input);
            Assert.Equal(items.Count, expectedCollectionCount);
        }
    }
}
