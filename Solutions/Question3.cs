using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public class Question3
    {
        public static List<string> AutoComplete(string search, string[] items, int maxResult)
        {
            //Note ป้องกัน null
            if (string.IsNullOrEmpty(search) || items == null)
                return new List<string>();

            search = search.ToLower();

            var results = items
                //Note เตรียม lower เพื่อลดการ ToLower ซ้ำ
                .Select(item => new
                {
                    Original = item,
                    Lower = item.ToLower()
                })

                //Note filter เฉพาะคำที่มี search
                .Where(x => x.Lower.Contains(search))

                //Note กำหนด priority
                .Select(x =>
                {
                    int priority;

                    if (x.Lower.StartsWith(search))
                        priority = 0; // ขึ้นต้น
                    else if (x.Lower.EndsWith(search))
                        priority = 2; // ท้าย
                    else
                        priority = 1; // กลาง

                    return new { x.Original, priority };
                })

                //Note เรียงตาม priority แล้วตามตัวอักษร
                .OrderBy(x => x.priority)
                .ThenBy(x => x.Original, StringComparer.OrdinalIgnoreCase)

                //Note จำกัดจำนวน
                .Take(maxResult)

                //Note เอาเฉพาะ string
                .Select(x => x.Original)
                .ToList();

            return results;
        }
    }
}