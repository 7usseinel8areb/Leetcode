public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);
        int index = Array.FindIndex(nums, i => i > 0);
        if(nums[nums.Length-1]<1)return 1;
        if (nums[index] > 1)
        {
            return 1;
        }
        for (int i = index; i < nums.Length-1; i++)
        {
            if (nums[i] + 1 < nums[i + 1]) 
                return nums[i]+1;
        }
        return nums[nums.Length-1] + 1;
    }
}