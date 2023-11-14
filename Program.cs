using System;
using System.IO;
namespace provodnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Проводник");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            ShowPapka("C:\\");
            void ShowPapka(string p)
            {
                Console.Clear();
                string[] paths = Directory.GetDirectories(p);
                string[] pathFiles = Directory.GetFiles(p);
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach ((string path, DriveInfo drive) in paths.Zip(allDrives, (p, d) => (p, d)))
                {
                    Console.Write("  " + allDrives);
                    Console.Write($"  {drive.AvailableFreeSpace / (1024 * 1024 * 1024):N2} Гб свободно из {drive.TotalSize / (1024 * 1024 * 1024):N2} Гб");
                }

                int pos = Menu.Show(0, paths.Length - 1);
                if (pos == -1)
                    return;
                ShowPapka(paths[pos]);
            }
        }
    }
}