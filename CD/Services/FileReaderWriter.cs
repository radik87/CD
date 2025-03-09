using CD.Constans;
using CD.Constants_Models;
using System;
using System.Diagnostics;
using System.IO;

namespace CD.Services
{
    public class FileReaderWriter
    {
        private readonly Stopwatch _stopwatch;
        public FileReaderWriter(Stopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }
        public string[] GetFile(string path, string extension)
        {
            return Directory.GetFiles(Folder.Current, extension);
        }
        public int[] Read(string fileName)
        {
            _stopwatch.Start();

            string[] lines = File.ReadAllLines(fileName);
            int[] block = Array.ConvertAll(lines, s => int.Parse(s));

            _stopwatch.Stop();
            TotalTime.Reading += _stopwatch.Elapsed;

            return block;
        }

        public void Write(object text, string path)
        {
            using (StreamWriter writer = new StreamWriter(string.Concat(path, @"\13-out.txt")))
            {
                writer.Write(text);
            }
        }
    }
}
