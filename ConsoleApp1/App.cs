using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.MSBuild;

namespace ConsoleApp1;
public class App
{
    public static async Task RunAsync(string projectPath)
    {
        if (!MSBuildLocator.IsRegistered)
        {
            MSBuildLocator.RegisterDefaults();
        }

        using var worspace = MSBuildWorkspace.Create();
        var project = await worspace.OpenProjectAsync(projectPath);

        var compilation = await project.GetCompilationAsync();

        if (compilation is null)
        {
            throw new Exception("compilation is null");
        }

        var diagnostics = compilation.GetDiagnostics();

        if (diagnostics.Any(x => x.Severity == Microsoft.CodeAnalysis.DiagnosticSeverity.Error))
        {
            //everything works fine when just running via ConsoleApp1
            //however, when running via either of the test-projects 'MsTestProject' / 'NUnitTestProject' / 'XUnitTestProject', diagnostics contains several errors
            throw new Exception("Project contains errors");
        }
    }
}
