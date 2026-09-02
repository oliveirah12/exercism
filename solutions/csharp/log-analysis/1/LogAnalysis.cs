public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        var message = str.Substring(str.IndexOf(delimiter) + delimiter.Length);
        return message;
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        var startIndexDelimiter = str.IndexOf(startDelimiter) + startDelimiter.Length;
        var endIndexDelimiter = str.IndexOf(endDelimiter);
        var result = str.Substring(startIndexDelimiter, endIndexDelimiter - startIndexDelimiter);
        return result;
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        var message = str.SubstringAfter("]: ");
        return message;
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        var logLevel = str.SubstringBetween("[", "]");
        return logLevel;
    }
}