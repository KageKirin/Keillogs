using Microsoft.Extensions.Logging;

namespace Keillogs;

public static class StringExtension
{
    public static void LogTrace(this string message, ILogger logger) => logger.LogTrace(message);

    public static void LogTrace(this string message, ILogger logger, params object[] args) => logger.LogTrace(message, args);

    public static void LogDebug(this string message, ILogger logger) => logger.LogDebug(message);

    public static void LogDebug(this string message, ILogger logger, params object[] args) => logger.LogDebug(message, args);

    public static void LogInformation(this string message, ILogger logger) => logger.LogInformation(message);

    public static void LogInformation(this string message, ILogger logger, params object[] args) => logger.LogInformation(message, args);

    public static void LogWarning(this string message, ILogger logger) => logger.LogWarning(message);

    public static void LogWarning(this string message, ILogger logger, params object[] args) => logger.LogWarning(message, args);

    public static void LogError(this string message, ILogger logger) => logger.LogError(message);

    public static void LogError(this string message, ILogger logger, params object[] args) => logger.LogError(message, args);

    public static void LogCritical(this string message, ILogger logger) => logger.LogCritical(message);

    public static void LogCritical(this string message, ILogger logger, params object[] args) => logger.LogCritical(message, args);
}
