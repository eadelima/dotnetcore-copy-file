using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CopyFile
{
    public static class Copy
    {
        public static void Init(string sourcePath, string targetPath)
        {
            DirectoryInfo[] directories = new DirectoryInfo(sourcePath).GetDirectories();

            string[] files = Directory.GetFiles(sourcePath);

            Directory.CreateDirectory(targetPath);

            if (Directory.Exists(targetPath))
                CopyFileToDest(files, targetPath);

            foreach (var directory in directories)
            {
                string dirPath = Path.Combine(targetPath, directory.Name);

                Init(directory.FullName, dirPath);
            }
        }
        public static void CopyFileToDest(string[] files, string targetPath)
        {
            string fileName = "";
            string destiny = "";

            foreach (string file in files)
            {
                fileName = Path.GetFileName(file);
                destiny = Path.Combine(targetPath, fileName);
                File.Copy(file, destiny, true);
            }
        }
    }
}
