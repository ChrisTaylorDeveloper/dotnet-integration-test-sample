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
    public void AddBlogExpectingSuccess()
    {
        var result = bm.IsPrime(1);
        Assert.That(result, Is.False, "1 should not be prime");
    }
}