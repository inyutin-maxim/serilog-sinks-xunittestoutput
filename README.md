# Serilog.Sinks.XunitTestOutput
Capture serilog log events to xUnit output

![badge](https://ci.appveyor.com/api/projects/status/github/marhoily/serilog-sinks-xunittestoutput?svg=true)

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
