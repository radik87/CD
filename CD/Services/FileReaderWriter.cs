using CD.Constans;
using CD.Constants_Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CD.Services
{
    public class FileReaderWriter
    {
        Stopwatch stopwatch = new Stopwatch();

        public string[] GetFile(string path, string extension)
        {
            return Directory.GetFiles(Folder.Current, extension);
        }
        public int[] Read(string fileName)
        {
            stopwatch.Start();

            string[] lines = File.ReadAllLines(fileName);
            int[] block = Array.ConvertAll(lines, s => int.Parse(s));

            stopwatch.Stop();
            TotalTime.Reading = stopwatch.Elapsed;

            return block;
        }

        public void Write(List<Tuple<int, double>> data, string path)
        {
            using (StreamWriter writer = new StreamWriter(string.Concat(path, @"\13-out.txt")))
            {
                writer.Write($"block size: {data.Count}");
                writer.WriteLine();

                foreach (Tuple<int, double> item in data)
                {
                    writer.Write($"delta: {item.Item1} ");
                    writer.Write($"average: {item.Item2} ");
                    writer.WriteLine();
                }
                
            }
        }
    }
}
