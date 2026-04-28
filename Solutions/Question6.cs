using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public class Question6
    {
        public static List<int> Tribonacci(int[]? seed, int n)
        {
            // Note: ถ้า n = 0 → ไม่มีข้อมูล → return list ว่าง
            if (n == 0)
                return new List<int>();

            // Note: ถ้า seed เป็น null → ให้ถือว่าเป็น empty array
            if (seed == null)
                seed = new int[] { };

            List<int> result = new List<int>();

            // Note: ใส่ค่า seed เข้าไปก่อน (แต่ไม่เกิน n)
            for (int i = 0; i < seed.Length && i < n; i++)
            {
                result.Add(seed[i]);
            }

            // 🔥 Note: FIX สำคัญ
            // Tribonacci ต้องมี "3 ค่าเริ่มต้นเสมอ"
            // ถ้า seed ไม่ครบ → เติม 0 ให้ครบ 3 ตัว
            while (result.Count < 3 && result.Count < n)
            {
                result.Add(0);
            }

            // Note: คำนวณค่าที่เหลือจนถึง n
            while (result.Count < n)
            {
                // Note: เอา 3 ตัวล่าสุดมาบวกกัน
                int sum = result[^1] + result[^2] + result[^3];

                result.Add(sum);
            }

            // Note: return ผลลัพธ์ทั้งหมด
            return result;
        }
    }
}