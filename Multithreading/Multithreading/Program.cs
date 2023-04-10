using System.Diagnostics;
using System.IO;

namespace Multithreading
{
    internal class Program
    {
        static void Main()
        {
            File.WriteAllText(SaveAsThread.path, string.Empty);

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] arr3 = { 7, 8, 9 };

            Thread t1 = new Thread(() => SaveAsThread.SaveArrayToFile(arr1, 1000));
            Thread t2 = new Thread(() => SaveAsThread.SaveArrayToFile(arr2, 300));
            Thread t3 = new Thread(() => SaveAsThread.SaveArrayToFile(arr3, 500));

            t1.Start();
            t2.Start();
            t3.Start();

            Thread.Sleep(2000);

            Console.WriteLine("\nAll arrays have been saved to file. Press any button to open file");
            Console.ReadKey();

            Process.Start("notepad.exe", SaveAsThread.path);
        }
    }
}