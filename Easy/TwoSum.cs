public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var output = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int g = 0; g < nums.Length; g++)
            {
                if (i == g) continue;

                if (nums[i] + nums[g] == target)
                {
                    output[0] = i;
                    output[1] = g;
                    return output;
                }
            }
        }

        return output;
    }
}