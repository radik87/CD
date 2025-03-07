using System.IO;

namespace CD.Service
{
    internal class Alghoritm
    {
        public void Write(int[,] arr, string path)
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
