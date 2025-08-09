// Start Blazor app
using System.Diagnostics;

Console.WriteLine("Starting Blazor app...");
var blazorProcess = new Process
{
    StartInfo = new ProcessStartInfo
    {
        FileName = "dotnet",
        Arguments = "run --project ../BlazorNethereum.SPA/BlazorNethereum.SPA.csproj",
        UseShellExecute = false
    }
};
blazorProcess.Start();

// Wait for Blazor to exit
await blazorProcess.WaitForExitAsync();