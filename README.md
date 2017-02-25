# Serilog.Sinks.XunitTestOutput
Capture serilog log events to xUnit output

[![NuGet](https://img.shields.io/nuget/v/Serilog.Sinks.XunitTestOutput.svg)](https://www.nuget.org/packages/Serilog.Sinks.XunitTestOutput)

[![build](https://ci.appveyor.com/api/projects/status/github/marhoily/serilog-sinks-xunittestoutput?svg=true)](https://ci.appveyor.com/project/marhoily/serilog-sinks-xunittestoutput)


```csharp
public void ConfigureLogging(Xunit.Abstractions.ITestOutputHelper output)
{
    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.XunitTestOutput(output)
        .CreateLogger();
}
```

See the [playground project](https://github.com/davetimmins/serilog-sinks-xunittestoutput/blob/master/src/playground/Tests.cs) for an example

![alt tag](https://raw.githubusercontent.com/davetimmins/serilog-sinks-xunittestoutput/master/example.PNG)
