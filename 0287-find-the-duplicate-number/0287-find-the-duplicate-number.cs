public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int, int> numCount = new Dictionary<int, int>();
        
        // Count occurrences of each number
        foreach(int num in nums){
            if(!numCount.ContainsKey(num)){
                numCount[num] = 1;
            } else {
                numCount[num]++;
            }
        }
        
        foreach(var i in numCount){
            if(i.Value > 1){
                return i.Key;
            }
        }
        
        return -1;
    }
}
