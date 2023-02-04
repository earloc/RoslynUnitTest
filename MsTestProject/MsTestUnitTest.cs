using ConsoleApp1;

namespace MsTestProject;

[TestClass]
public class MsTestUnitTest
{
    [TestMethod]
    public async Task Test1()
    {
        await App.RunAsync("../../../../ClassLibrary1/ClassLibrary1.csproj");
    }
}