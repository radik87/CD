using System;
using System.IO;

namespace CD.Services
{
    internal class FileReaderWriter
    {
        internal int[] Read(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            int[] block = Array.ConvertAll(lines, s => int.Parse(s));
            return block;
        }

        internal void Write(int[,] arr, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j == arr.GetLength(1) - 1)
                        {
                            writer.Write(arr[i, j]);
                        }
                        else
                        {
                            writer.Write(arr[i, j] + ",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
