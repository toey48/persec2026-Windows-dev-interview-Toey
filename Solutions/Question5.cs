using System;
using System.Linq;

namespace Solutions
{
    public class Question5
    {
        public static int SortDescending(int number)
        {
            //Note แปลง int → string
            string numStr = number.ToString();

            //Note แยก digit แล้ว sort จากมาก → น้อย
            var sorted = numStr
                .OrderByDescending(c => c) //Note เรียง char จากมากไปน้อย
                .ToArray();

            //Note รวมกลับเป็น string
            string resultStr = new string(sorted);

            //Note แปลงกลับเป็น int
            return int.Parse(resultStr);
        }
    }
}