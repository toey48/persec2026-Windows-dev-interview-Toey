using Xunit;
using Solutions;
using System.Collections.Generic;

namespace Solutions.Tests
{
    public class Question3Tests
    {
       
        [Fact]
        public void AutoComplete_BasicCase()
        {
            var items = new string[]
            {
                "Thailand", "Math", "Path", "Something", "Thesis", "Panther"
            };

            var result = Question3.AutoComplete("th", items, 5);

            var expected = new List<string>
            {
               "Thailand",
               "Thesis",
               "Panther",
               "Something",
               "Math"
            };

            Assert.Equal(expected, result);
        }

        // Note: จำกัดจำนวนผลลัพธ์
        [Fact]
        public void AutoComplete_MaxResult()
        {
            var items = new string[]
            {
                "Thailand", "Thesis", "Thor", "Thorn"
            };

            var result = Question3.AutoComplete("th", items, 2);

            Assert.Equal(2, result.Count);
        }

        // Note: ไม่มีคำที่ match
        [Fact]
        public void AutoComplete_NoMatch()
        {
            var items = new string[]
            {
                "Apple", "Banana", "Orange"
            };

            var result = Question3.AutoComplete("th", items, 5);

            Assert.Empty(result);
        }

        // Note: case insensitive
        [Fact]
        public void AutoComplete_CaseInsensitive()
        {
            var items = new string[]
            {
                "THAILAND", "thesis", "Thorn"
            };

            var result = Question3.AutoComplete("th", items, 5);

            Assert.Equal(3, result.Count);
        }

        // Note: search เป็น null / empty
        [Fact]
        public void AutoComplete_EmptySearch()
        {
            var items = new string[]
            {
                "Thailand", "Thesis"
            };

            var result = Question3.AutoComplete("", items, 5);

            Assert.Empty(result);
        }
    }
}