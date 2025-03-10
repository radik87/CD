using CD.Constants_Models;
using System;
using System.Diagnostics;
using System.IO;

namespace CD.Services
{
    public class FileReaderWriter
    {
        Stopwatch stopwatch = new Stopwatch();

        public string[] GetFile(string path, string extension)
        {
            return Directory.GetFiles(path, extension);
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
        public void Write(Stats stats, int [] blockValues, string path)
        {
            using (StreamWriter writer = new StreamWriter(string.Concat(path, @"\13-out.txt")))
            {
                writer.WriteLine($"delta: {stats.Delta} [0-{stats.Delta - 1}] indexes from Cd-in file has minimal average bits");
                writer.WriteLine($"average: {stats.Average} bits");
                writer.WriteLine("block data:");
                for (int i = 0; i < stats.Delta; i++)
                {
                    writer.WriteLine(blockValues[i]);
                }
            }
        }
    }
}