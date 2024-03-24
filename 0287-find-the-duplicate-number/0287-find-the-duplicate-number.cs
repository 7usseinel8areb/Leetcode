public class Solution {
    public int FindDuplicate(int[] nums) {
        return nums.GroupBy(x => x)
                   .Where(g => g.Count() > 1)
                   .Select(g => g.Key)
                   .FirstOrDefault();
    }
}
