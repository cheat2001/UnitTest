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

    protected virtual DateTime GetDate()
    {
        return _dateTime;
    }
}

class MerryXmasCheckerImpl : MerryXmasChecker
{
    private readonly DateTime _dateTime;

    public MerryXmasCheckerImpl(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public MerryXmasCheckerImpl()
    {
        
    }
    protected override DateTime GetDate()
    {
        return _dateTime;
    }
}