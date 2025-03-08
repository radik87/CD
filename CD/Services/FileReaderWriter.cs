using CD.Constans;
using System;
using System.IO;

namespace CD.Services
{
    internal class FileReaderWriter
    {
        internal static string[] GetFile(string path, string extension)
        {
            return Directory.GetFiles(Folder.Current, extension);
        }
        internal int[] Read(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            int[] block = Array.ConvertAll(lines, s => int.Parse(s));

            return block;
        }

        internal void Write(object text, string path)
        {
            using (StreamWriter writer = new StreamWriter(string.Concat(path, @"\13-out.txt")))
            {
                writer.Write(text);
                //writer.WriteLine();
            }
        }
    }
}
