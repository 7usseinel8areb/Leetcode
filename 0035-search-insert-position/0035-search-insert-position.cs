public class Solution {
    public int SearchInsert(int[] nums, int target) {
        bool f=false;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] >= target)
    {                    
        f=true;
        return i;
    }
}
if (!f)
{
    return nums.Length;
}
        return 0;
    }
}