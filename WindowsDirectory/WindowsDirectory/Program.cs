using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = GetFolder("A");
            var files = GetFiles(folder, "3422B60", "3422B61");
            MoveFiles(files, "A", "B");
        }

        private static string GetFolder(string folderName)
        {
            var folder = new DirectoryInfo(folderName).Name;

            return folder;
        }

        private static string[] GetFiles(string folderName, string from, string to)
        {
            string[] files = Directory.GetFiles(folderName, "*.*", SearchOption.AllDirectories)
                .OrderBy(f => f).Where(f => f.Contains(folderName)).ToArray();
            return files;
        }

        private static void MoveFiles(Array filesList, string rootFolderPath, string destinationPath)
        {
            try
            {
                foreach(string file in filesList)
                {
                    var fileToMove = rootFolderPath + file;
                    var moveTo = destinationPath + file;
                    File.Move(fileToMove, moveTo);
                }
            } catch (FileNotFoundException e)
            {
                throw new ArgumentException(e.Message);
            }
        }
    }
}
