public class Solution
{
    public bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        string xStringPalindrome = string.Empty;

        for (int i = xString.Length - 1; i >= 0; i--)
        {
            xStringPalindrome += xString[i];
        }

        return xString == xStringPalindrome;
    }
}