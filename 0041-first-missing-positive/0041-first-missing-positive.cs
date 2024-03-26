public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);
        int smallestPositive = 1;

        foreach (var num in nums)
        {
            if (num == smallestPositive)
                smallestPositive++;
            else if (num > smallestPositive)
                return smallestPositive;
        }

        return smallestPositive;
    }
}
