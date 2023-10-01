using System.IO.Compression;

namespace UnZip
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2) return;

            string zipPath = args[0];
            string extractPath = args[1];

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
