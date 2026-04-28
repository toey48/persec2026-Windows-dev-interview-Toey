namespace Solutions
{
    public class Question1
    {
        public static bool IsValid(string input)
        {
            //Note ใช้ Stack เพื่อเก็บวงเล็บเปิด (LIFO: ล่าสุดต้องปิดก่อน)
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                //Note ถ้าเป็นวงเล็บเปิด → push เข้า stack
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    //Note ถ้าเจอวงเล็บปิด แต่ไม่มีตัวเปิด → invalid ทันที
                    if (stack.Count == 0) return false;

                    //Note ดึงตัวเปิดล่าสุดออกมาเพื่อ match
                    char top = stack.Pop();

                    //Note ตรวจว่าคู่กันถูกต้องไหม เช่น ( ต้องคู่กับ )
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            //Note ถ้ายังมีค้างใน stack แปลว่าเปิดไม่ครบ → invalid
            return stack.Count == 0;
        }
    }
}