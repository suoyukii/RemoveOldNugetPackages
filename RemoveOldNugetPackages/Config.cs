namespace RemoveOldNugetPackages;

public class Config
{
    public static readonly Dictionary<string, string[]> Language = new()
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
        },
    };
}