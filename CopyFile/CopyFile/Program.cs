using System;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\data\src\genciador-de-arquivos\public";
            string targetPath = @"D:\data\src\genciador-de-arquivos\private";

            Copy.Init(sourcePath, targetPath);
        }
    }
}
