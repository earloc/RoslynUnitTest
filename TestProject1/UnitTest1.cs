using ConsoleApp1;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        await App.RunAsync("../../../../ClassLibrary1/ClassLibrary1.csproj");
    }
}