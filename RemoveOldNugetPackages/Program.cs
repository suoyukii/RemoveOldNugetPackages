using RemoveOldNugetPackages;

// Load language
var langs = Language.Get();
Console.Title = langs[0];

// Start remove
var path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
// string path;
// if (OperatingSystem.IsWindows()) path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
// else if (OperatingSystem.IsLinux()) path = null;
// else if (OperatingSystem.IsMacOS()) path = null;
var dir_arr = new DirectoryInfo(path).GetDirectories();
Console.WriteLine(langs[1]);
foreach (var dir in dir_arr)
{
    var sub_dir_arr = dir.GetDirectories();
    if (sub_dir_arr.Length > 1)
    {
        var max_index = sub_dir_arr.Length - 1;
        for (var i = 0; i < max_index; i++) sub_dir_arr[i].Delete(true);
    }
}

Console.WriteLine(langs[2]);
Console.ReadLine();