public class Solution
{
    public int DayOfYear(string date)
    {
        string[] dateArr = date.Split('-');
        int y = int.Parse(dateArr[0]);
        int m = int.Parse(dateArr[1]);
        int d = int.Parse(dateArr[2]);

        DateOnly dateOnly = new DateOnly(y,m,d);
        DateOnly dateOnly1 = new DateOnly(y, 1, 1);
        int dif = dateOnly.DayOfYear - dateOnly1.DayOfYear;
        return dif+1;
    }
}