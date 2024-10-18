using System.Globalization;
using RemoveOldNugetPackages;
// using System.Runtime.InteropServices;

// string path;
// if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
//     path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
// else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
//     path = null;
// else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
//     path = null;

// Load languages
var lang_name = CultureInfo.CurrentUICulture.Name.ToLower();
var langs = Config.Language[Config.Language.ContainsKey(lang_name) ? lang_name : "en-us"];

// Start Remove
var path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
var dir_arr = new DirectoryInfo(path).GetDirectories();
Console.WriteLine(langs[0]);
foreach (var dir in dir_arr)
{
    var sub_dir_arr = dir.GetDirectories();
    if (sub_dir_arr.Length > 1)
    {
        var max_index = sub_dir_arr.Length - 1;
        for (var i = 0; i < max_index; i++) sub_dir_arr[i].Delete(true);
    }
}

Console.WriteLine(langs[1]);
Console.ReadLine();