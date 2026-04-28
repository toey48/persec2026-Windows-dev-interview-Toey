using Xunit;
using Solutions;
using System.Collections.Generic;

namespace Solutions.Tests
{
    public class Question2Tests
    {
        // Note: ทดสอบเคสพื้นฐานตามโจทย์
        [Fact]
        public void SortStrings_BasicCase1()
        {
            var input = new string[] { "TH19", "SG20", "TH2" };

            var result = Question2.SortStrings(input);

            var expected = new List<string> { "SG20", "TH2", "TH19" };

            Assert.Equal(expected, result);
        }

        // Note: มี suffix (เช่น Netflix)
        [Fact]
        public void SortStrings_WithSuffix()
        {
            var input = new string[] { "TH10", "TH3Netflix", "TH1", "TH7" };

            var result = Question2.SortStrings(input);

            var expected = new List<string> { "TH1", "TH3Netflix", "TH7", "TH10" };

            Assert.Equal(expected, result);
        }

        // Note: prefix ต่างกัน + number เท่ากัน
        [Fact]
        public void SortStrings_DifferentPrefix()
        {
            var input = new string[] { "AB10", "AA10", "AC10" };

            var result = Question2.SortStrings(input);

            var expected = new List<string> { "AA10", "AB10", "AC10" };

            Assert.Equal(expected, result);
        }

        // Note: number ต่างกัน
        [Fact]
        public void SortStrings_NumberOrder()
        {
            var input = new string[] { "TH100", "TH2", "TH50" };

            var result = Question2.SortStrings(input);

            var expected = new List<string> { "TH2", "TH50", "TH100" };

            Assert.Equal(expected, result);
        }
    }
}