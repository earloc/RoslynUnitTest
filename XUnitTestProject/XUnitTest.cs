using ConsoleApp1;

namespace XUnitTestProject;

public class XUnitTest
{
    [Fact]
    public async Task Test1()
    {
        await App.RunAsync("../../../../ClassLibrary1/ClassLibrary1.csproj");
    }
}