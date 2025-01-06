using Keillogs;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.Debug;
using Xunit;

namespace Keillogs.Functionality.Tests;

public class Console_Log
{
    [Fact]
    public void Test()
    {
        ILoggerFactory factory = LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Trace).AddConsole());
        ILogger logger = factory.CreateLogger<Console_Log>();

        "trace".LogTrace(logger);
        "debug".LogDebug(logger);
        "info".LogInformation(logger);
        "warning".LogWarning(logger);
        "error".LogError(logger);
        "critical".LogCritical(logger);
    }
}
