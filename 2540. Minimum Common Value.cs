public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int[] lst = nums1.Intersect(nums2).ToArray();
        return lst.Length!=0 ? lst.Min() : -1;
    }
}