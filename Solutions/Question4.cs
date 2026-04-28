using System;
using System.Collections.Generic;

namespace Solutions
{
    public class Question4
    {
    
        // Function 1: Int -> Roman
        public static string IntToRoman(int num)
        {
            //Note map ค่าตัวเลขกับ Roman (เรียงจากมาก → น้อย)
            var map = new (int value, string symbol)[]
            {
                (1000, "M"),
                (900, "CM"),
                (500, "D"),
                (400, "CD"),
                (100, "C"),
                (90, "XC"),
                (50, "L"),
                (40, "XL"),
                (10, "X"),
                (9, "IX"),
                (5, "V"),
                (4, "IV"),
                (1, "I")
            };

            string result = "";

            //Note วน loop เอาค่าที่มากที่สุดก่อน
            foreach (var item in map)
            {
                //Note ถ้า num ยังมากกว่าค่า map ให้ลบออกและต่อ string
                while (num >= item.value)
                {
                    result += item.symbol;
                    num -= item.value;
                }
            }

            return result;
        }

        
        // Function 2: Roman -> Int
        public static int RomanToInt(string s)
        {
            //Note map Roman → ค่า int
            var map = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int current = map[s[i]];

                //Note เช็คกรณีพิเศษ เช่น IV, IX
                if (i + 1 < s.Length && current < map[s[i + 1]])
                {
                    total -= current; //Note ลบแทนบวก
                }
                else
                {
                    total += current;
                }
            }

            return total;
        }
    }
}