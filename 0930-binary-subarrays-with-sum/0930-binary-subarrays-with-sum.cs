public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        int ans = 0;
        int arLen = nums.Length;
        for (int i = 0; i < arLen; i++) 
        {
            int sum = nums[i];
            if (sum == goal)
                ans++;
            for (int j = i+1; j < arLen; j++)
            {
                sum += nums[j];
                if (sum == goal) 
                    ans++;
                else if (sum > goal)
                    break;
            }
        }
        return ans;
    }
}