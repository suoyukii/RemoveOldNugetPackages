// using System.Runtime.InteropServices;

// string path;
// if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
//     path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
// else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
//     path = null;
// else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
//     path = null;

var path = Environment.GetEnvironmentVariable("userprofile") + "/.nuget/packages";
var dir_arr = new DirectoryInfo(path).GetDirectories();
Console.WriteLine("Removing...");
foreach (var dir in dir_arr)
{
    var sub_dir_arr = dir.GetDirectories();
    if (sub_dir_arr.Length > 1)
    {
        var max_index = sub_dir_arr.Length - 1;
        for (var i = 0; i < max_index; i++) sub_dir_arr[i].Delete(true);
    }
}

Console.WriteLine("Remove is complete, the window can be closed.");
Console.ReadLine();