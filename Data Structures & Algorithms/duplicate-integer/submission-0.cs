public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool checkTrue = false;
        for (int i = 0; i < nums.Length; i++) 
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == nums[i] && j != i)
                {
                    checkTrue = true;
                    break;
                }
                
            }
            if (checkTrue)
            {
                break;
            }

        }
        if (checkTrue)
            {
                return true;
            }
        return false;
    }
}

