using System;
using System.Collections.Generic;
using Solutions;

// =========================
// ====== Question 1 =======
// =========================
Console.WriteLine("=== Question 1 ===");

var q1Tests = new Dictionary<string, bool>()
{
    {"()", true},
    {"([]]", false},
    {"([{}])", true},
    {"([[{}]]]", false},
    {")", false},
    {"(]}])", false},
    {"([)]", false},
    {"{", false}
};

foreach (var test in q1Tests)
{
    var q1Result = Question1.IsValid(test.Key);
    Console.WriteLine($"{test.Key} => {q1Result} (Expected: {test.Value})");
}


// =========================
// ====== Question 2 =======
// =========================
Console.WriteLine("\n=== Question 2 ===");

var input1 = new string[] { "TH19", "SG20", "TH2" };
Console.WriteLine("Input: " + string.Join(", ", input1));
Console.WriteLine("Output: " + string.Join(", ", Question2.SortStrings(input1)));

var input2 = new string[] { "TH10", "TH3Netflix", "TH1", "TH7" };
Console.WriteLine("Input: " + string.Join(", ", input2));
Console.WriteLine("Output: " + string.Join(", ", Question2.SortStrings(input2)));

// =========================
// ====== Question 3 =======
// =========================
Console.WriteLine("\n=== Question 3 ===");

var items = new string[]
{
    "Thailand", "Math", "Path", "Something", "Thesis", "Panther"
};

string search = "th";
int maxResult = 5;

Console.WriteLine($"Search: {search}");
Console.WriteLine("Items: " + string.Join(", ", items));

// Note: เรียกใช้ฟังก์ชัน AutoComplete
var autoCompleteResult = Question3.AutoComplete(search, items, maxResult);

// Note: แสดงผลลัพธ์หลังจาก filter + sort + limit
Console.WriteLine("Result: " + string.Join(", ", autoCompleteResult));


// =========================
// ====== Question 4 =======
// =========================
Console.WriteLine("=== Question 4 ===");

// ===== Int -> Roman =====
Console.WriteLine("1989 => " + Question4.IntToRoman(1989)); // MCMLXXXIX
Console.WriteLine("2000 => " + Question4.IntToRoman(2000)); // MM
Console.WriteLine("68 => " + Question4.IntToRoman(68));     // LXVIII
Console.WriteLine("109 => " + Question4.IntToRoman(109));   // CIX

// ===== Roman -> Int =====
Console.WriteLine("MCMLXXXIX => " + Question4.RomanToInt("MCMLXXXIX")); // 1989
Console.WriteLine("MM => " + Question4.RomanToInt("MM"));               // 2000
Console.WriteLine("LXVIII => " + Question4.RomanToInt("LXVIII"));       // 68
Console.WriteLine("CIX => " + Question4.RomanToInt("CIX"));             // 109

// =========================
// ====== Question 5 =======
// =========================
Console.WriteLine("\n=== Question 5 ===");

Console.WriteLine("3008 => " + Question5.SortDescending(3008)); // 8300
Console.WriteLine("1989 => " + Question5.SortDescending(1989)); // 9981
Console.WriteLine("2679 => " + Question5.SortDescending(2679)); // 9762
Console.WriteLine("9163 => " + Question5.SortDescending(9163)); // 9631

// =========================
// ====== Question 6 =======
// =========================
Console.WriteLine("\n=== Question 6 ===");

Print(Question6.Tribonacci(new int[] { 1, 3, 5 }, 5));   // [1,3,5,9,17]
Print(Question6.Tribonacci(new int[] { 2, 2, 2 }, 3));   // [2,2,2]
Print(Question6.Tribonacci(new int[] { 10, 10, 10 }, 4));// [10,10,10,30]

Print(Question6.Tribonacci(new int[] { }, 5));           // [0,0,0,0,0]
Print(Question6.Tribonacci(new int[] { 1 }, 5));         // [1,0,0,1,1]
Print(Question6.Tribonacci(new int[] { 5, 2 }, 5));      // [5,2,0,7,9]

// helper print
void Print(List<int> list)
{
    Console.WriteLine("[" + string.Join(", ", list) + "]");
}