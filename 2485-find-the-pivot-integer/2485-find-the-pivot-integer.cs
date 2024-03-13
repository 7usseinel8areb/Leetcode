public class Solution {
    public int PivotInteger(int n)
    {
        List<int> lst1 = new List<int>() {0};
        List<int> lst2 = new List<int>() { n};

        for(int i = 1; i <= n; i++)
        {
            lst1.Add(i + lst1[i-1]);
        }

        int c = 0;
        for(int i = n-1; i >= 1; i--)
        {
            lst2.Add(i + lst2[c]);
            c++;
        }
        lst2.Reverse();
        lst1.Remove(0);

        for(int i = n-1; i>=0; i--)
        {
            if (lst1[i] == lst2[i])
            {
                return i+1;
            }
        }
        return -1;
    }
}