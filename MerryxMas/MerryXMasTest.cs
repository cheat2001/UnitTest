namespace MerryxMas;

public class Tests
{
    private MerryXmasChecker _merryXmasChecker;

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Today_is_not_merry_xmas()
    {
        _merryXmasChecker= new MerryXmasChecker();
        Assert.That(_merryXmasChecker.IsMerryXmas(), Is.EqualTo("Today is not merry xmas"));
        Assert.Pass();
    }
}

public class MerryXmasChecker
{
    public string IsMerryXmas()
    {
        return DateTime.Now.Day == 25 && DateTime.Now.Month == 12 ? "Today is merry xmas" : "Today is not merry xmas";
    }
}