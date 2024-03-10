public class Solution {
    public int LengthOfLastWord(string s) {
        
        string[] Lst = s.TrimEnd().Split(' ').ToArray();
        int Lastlen = Lst[Lst.Length - 1].Length;

        return Lastlen;
    }
}