// ReSharper disable once CheckNamespace

using System;
using System.IO;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;
using Xunit.Abstractions;

// ReSharper disable once CheckNamespace
namespace Serilog.Sinks.XunitTestOutput
{
    /// <summary>
    ///     Captures serilog log events to xUnit output
    /// </summary>
    public class XUnitTestOutputSink : ILogEventSink
    {
        private readonly ITestOutputHelper _output;
        private readonly ITextFormatter _textFormatter;

        /// <summary>ctor</summary>
        public XUnitTestOutputSink(ITestOutputHelper testOutputHelper, ITextFormatter textFormatter)
        {
            if (testOutputHelper == null) throw new ArgumentNullException("testOutputHelper");
            if (textFormatter == null) throw new ArgumentNullException("textFormatter");

            _output = testOutputHelper;
            _textFormatter = textFormatter;
        }

        /// <inheritdoc />
        public void Emit(LogEvent logEvent)
        {
            if (logEvent == null) throw new ArgumentNullException("logEvent");

            var renderSpace = new StringWriter();
            _textFormatter.Format(logEvent, renderSpace);
            _output.WriteLine(renderSpace.ToString());
        }
    }
}