public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1) return 0; // If k <= 1, no subarray will have a product less than k

        int count = 0;
        int product = 1;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            product *= nums[right];
            while (product >= k)
            {
                product /= nums[left++];
            }
            count += right - left + 1; // Adding the count of subarrays ending at 'right' index
        }
        return count;
    }
}