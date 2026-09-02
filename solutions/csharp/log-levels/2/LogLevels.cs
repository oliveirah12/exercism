using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

static class LogLine
{
    public static string Message(string logLine)
    {
        var message = logLine.Substring(logLine.IndexOf(":") + 1).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        var message = logLine.Substring(1, logLine.IndexOf("]") - 1);
        return message.ToLower();
    }

    public static string Reformat(string logLine)
    {
        var message = $"{Message(logLine)} ({LogLevel(logLine)})";
        return message;
    }
}
