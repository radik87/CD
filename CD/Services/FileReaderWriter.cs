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

        public void Write(Dictionary<int, decimal> data, string path)
        {
            using (StreamWriter writer = new StreamWriter(string.Concat(path, @"\13-out.txt")))
            {
                foreach (var item in data)
                {
                    writer.WriteLine($"delta: {item.Key} ");
                    writer.WriteLine($"average: {item.Value} ");
                }
            }
        }

        //public void Write(int index, string path)
        //{
        //    using (StreamWriter writer = new StreamWriter(string.Concat(path, @"\13-out.txt")))
        //    {
               
        //    }
        //}
    }
}