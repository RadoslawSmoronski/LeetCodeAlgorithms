namespace LeetCodeAlgorithms
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> RomanDic = new Dictionary<char, int>();

            RomanDic.Add('I', 1);
            RomanDic.Add('V', 5);
            RomanDic.Add('X', 10);
            RomanDic.Add('L', 50);
            RomanDic.Add('C', 100);
            RomanDic.Add('D', 500);
            RomanDic.Add('M', 1000);

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int currentVal = RomanDic[s[i]];

                if (i + 1 < s.Length && RomanDic[s[i + 1]] > currentVal)
                {
                    result -= currentVal;
                }
                else
                {
                    result += currentVal;
                }
            }

            return result;
        }
    }
}