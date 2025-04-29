// using NUnit.Framework;
// using Prime.Services;
// using BlogManager;

namespace BlogManager.Tests.Feature;

[TestFixture]
public class BlogCreation
{
    private Manager bm;

    [SetUp]
    public void SetUp()
    {
        bm = new Manager();
    }

    [Test]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        var result = bm.IsPrime(1);
        Assert.That(result, Is.False, "1 should not be prime");
    }
}