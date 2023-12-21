namespace MerryxMas;

public class MerryXmasChecker
{
    private static DateTime _dateTime;

    public MerryXmasChecker(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public MerryXmasChecker()
    {
        
    }

    public string IsMerryXmas()
    {
        return GetDate().Day == 25 && GetDate().Month == 12 ? "Today is merry xmas" : "Today is not merry xmas";
    }

    private DateTime GetDate()
    {
        return _dateTime;
    }
}