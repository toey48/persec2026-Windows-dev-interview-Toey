using Xunit;
using Solutions;

namespace Solutions.Tests
{
    public class Question4Tests
    {
        // =========================
        // ===== Int -> Roman ======
        // =========================

        // Note: เคสพื้นฐาน
        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        [InlineData(2000, "MM")]
        public void IntToRoman_Basic(int input, string expected)
        {
            var result = Question4.IntToRoman(input);

            Assert.Equal(expected, result);
        }

        // Note: เคสจากโจทย์
        [Fact]
        public void IntToRoman_FromQuestion()
        {
            Assert.Equal("MCMLXXXIX", Question4.IntToRoman(1989));
            Assert.Equal("LXVIII", Question4.IntToRoman(68));
            Assert.Equal("CIX", Question4.IntToRoman(109));
        }

        // =========================
        // ===== Roman -> Int ======
        // =========================

        // Note: เคสพื้นฐาน
        [Theory]
        [InlineData("I", 1)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MM", 2000)]
        public void RomanToInt_Basic(string input, int expected)
        {
            var result = Question4.RomanToInt(input);

            Assert.Equal(expected, result);
        }

        // Note: เคสจากโจทย์
        [Fact]
        public void RomanToInt_FromQuestion()
        {
            Assert.Equal(1989, Question4.RomanToInt("MCMLXXXIX"));
            Assert.Equal(68, Question4.RomanToInt("LXVIII"));
            Assert.Equal(109, Question4.RomanToInt("CIX"));
        }

        // =========================
        // ===== Edge Case =========
        // =========================

        // Note: ตัวเลขเรียงปกติ (ไม่มี subtract)
        [Fact]
        public void RomanToInt_NoSubtraction()
        {
            Assert.Equal(3, Question4.RomanToInt("III"));
        }

        // Note: มี subtract หลายจุด
        [Fact]
        public void RomanToInt_Complex()
        {
            Assert.Equal(944, Question4.RomanToInt("CMXLIV")); // 900 + 40 + 4
        }
    }
}