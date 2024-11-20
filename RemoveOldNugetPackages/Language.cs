using System.Globalization;

namespace RemoveOldNugetPackages;

internal static class Language
{
    public static string[] Get() => CultureInfo.CurrentUICulture.Name switch
    {
        "zh-CN" =>
        [
            "清除旧版 Nuget 包",
            "清除中...",
            "清除结束，这个窗口可以关闭了"
        ],
        _ =>
        [
            "Remove Old Nuget Packages",
            "Removing...",
            "Remove is complete, the window can be closed."
        ]
    };
}