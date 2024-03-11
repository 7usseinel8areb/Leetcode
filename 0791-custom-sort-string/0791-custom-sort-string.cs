public class Solution
{
    public string CustomSortString(string order, string s)
    {            
        Dictionary<char,int> charPos = order.Select((i,j) => (i,j))
                                       .ToDictionary(p => p.i, p => p.j);
        char[] newS = s.ToCharArray()
                        .OrderBy(c => charPos.ContainsKey(c) ?
                        charPos[c]: int.MaxValue)
                        .ToArray();
        return string.Join("",newS);

    }
}