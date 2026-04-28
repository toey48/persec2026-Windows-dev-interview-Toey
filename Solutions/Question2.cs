using System.Text.RegularExpressions;

namespace Solutions
{
    public class Question2
    {
        public static List<string> SortStrings(string[] input)
        {
            return input
                .Select(str =>
                {
                    //Note ใช้ Regex แยก string เป็น 3 ส่วน:
                    // prefix (ตัวอักษร) + number (ตัวเลข) + suffix (ที่เหลือ)
                    var match = Regex.Match(str, @"([A-Za-z]+)(\d+)(.*)");

                    string prefix = match.Groups[1].Value;   //Note ตัวอักษร เช่น "TH"
                    int number = int.Parse(match.Groups[2].Value); //Note ตัวเลข เช่น 19
                    string suffix = match.Groups[3].Value;   //Note ส่วนท้าย เช่น "Netflix"

                    //Note เก็บไว้เพื่อใช้ sort หลายเงื่อนไข
                    return new { original = str, prefix, number, suffix };
                })

                //Note เรียงตาม prefix ก่อน (A-Z)
                .OrderBy(x => x.prefix)

                //Note ถ้า prefix เหมือนกัน → เรียงตามตัวเลข (numeric sort)
                .ThenBy(x => x.number)

                //Note ถ้ายังเท่ากันอีก → เรียง suffix
                .ThenBy(x => x.suffix)

                //Note เอากลับเป็น string เดิม
                .Select(x => x.original)

                .ToList();
        }
    }
}