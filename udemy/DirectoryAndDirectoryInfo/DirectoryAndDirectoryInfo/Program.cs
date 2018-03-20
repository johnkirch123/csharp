using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"C:\Users\dubsk\Desktop\programming\csharp\udemy", "*.sln", SearchOption.AllDirectories);
            foreach(var file in files)
                System.Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\dubsk\Desktop\programming\csharp\udemy", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
