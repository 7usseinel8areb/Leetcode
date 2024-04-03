
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        string s = string.Join("", digits);

        BigInteger incrementedBigInt = BigInteger.Parse(s) + 1;
        
        string incremented = incrementedBigInt.ToString();

        int[] result = incremented.Select(c => int.Parse(c.ToString())).ToArray();
        
        return result;
    }
}
