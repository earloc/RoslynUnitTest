using ConsoleApp1;

namespace NUnitTestProject;

public class NUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        await App.RunAsync("../../../../ClassLibrary1/ClassLibrary1.csproj");
    }
}