public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output  = [0, 0];
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target && i != j)
                {
                output  = [j, i];
                }

            }

        }
        return output;
    }

}
