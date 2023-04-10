using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Multithreading
{
    public static class SaveAsThread
    {
        public static string path = "arrays.txt";
        
        public static void SaveArrayToFile(int[] arr, int sec)
        {
            lock (path)
            {
                Thread.Sleep(sec);
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (int num in arr)
                    {
                        sw.Write(num + " ");
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                    sw.WriteLine();
                }
            }
        }
    }
}
