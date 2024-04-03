public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        string s = string.Join("", digits);
        string x = (BigInteger.Parse(s)+1).ToString();
        int[] result = x.Select(x=>int.Parse(x.ToString())).ToArray();
        return result;

    }
}