using Xunit;
using Solutions;

namespace Solutions.Tests
{
    public class Question1Tests
    {
        // Note: ใช้ Theory เพื่อทดสอบหลายเคสในฟังก์ชันเดียว
        [Theory]

        // Note: เคสวงเล็บถูกต้อง
        [InlineData("()", true)]

        // Note: ปิดวงเล็บผิด
        [InlineData("([]]", false)]

        // Note: ซ้อนกันถูกต้อง
        [InlineData("([{}])", true)]

        // Note: ปิดเกิน
        [InlineData("([[{}]]]", false)]

        // Note: เริ่มด้วยปิดเลย
        [InlineData(")", false)]

        // Note: รูปแบบมั่ว
        [InlineData("(]}])", false)]

        // Note: cross pair ผิด
        [InlineData("([)]", false)]

        // Note: เปิดแต่ไม่ปิด
        [InlineData("{", false)]

        public void Test_IsValid(string input, bool expected)
        {
            // Note: เรียกฟังก์ชันที่ต้องการทดสอบ
            var result = Question1.IsValid(input);

            // Note: ตรวจสอบว่าผลลัพธ์ตรงกับที่คาดไว้
            Assert.Equal(expected, result);
        }
    }
}