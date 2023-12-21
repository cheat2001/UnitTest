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
        _merryXmasChecker= new MerryXmasCheckerImpl();
        Assert.That(_merryXmasChecker.IsMerryXmas(), Is.EqualTo("Today is not merry xmas"));
        Assert.Pass();
    }
    
    [Test]
    public void Today_is_merry_xmas()
    {
        _merryXmasChecker= new MerryXmasCheckerImpl(new DateTime(2023,12,25));
        Assert.That(_merryXmasChecker.IsMerryXmas(), Is.EqualTo("Today is merry xmas"));
        Assert.Pass();
    }
}