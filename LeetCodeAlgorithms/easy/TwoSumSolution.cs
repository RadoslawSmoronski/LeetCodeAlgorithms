namespace LeetCodeAlgorithms
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int numToFind = target - nums[i];

                for (int g = i + 1; g < nums.Length; g++)
                {
                    if (nums[g] == numToFind)
                    {
                        output[0] = i;
                        output[1] = g;
                        return output;
                    }
                }
            }

            return [];
        }
    }
}