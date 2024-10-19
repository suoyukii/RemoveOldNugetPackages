using System.Globalization;

namespace RemoveOldNugetPackages;

internal static class Language
{
    private static readonly Dictionary<string, string[]> Strings = new()
    {
        {
            "en-us",
            [
                "Removing...",
                "Remove is complete, the window can be closed."
            ]
        },
        {
            "zh-cn",
            [
                "清除中...",
                "清除结束，这个窗口可以关闭了"
            ]
        }
    };

    public static string[] Get()
    {
        var lang_name = CultureInfo.CurrentUICulture.Name.ToLower();
        return Strings[Strings.ContainsKey(lang_name) ? lang_name : "en-us"];
    }
}