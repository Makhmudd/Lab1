using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_manager
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            DirectoryInfo directory = new DirectoryInfo(@"/Users/adilsaidagali/Desktop/example");
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            foreach(FileSystemInfo f in fs)
            {
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(f.Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(f.Name);
                }
                    
            }
            Console.ReadKey();
        }
    }
}
