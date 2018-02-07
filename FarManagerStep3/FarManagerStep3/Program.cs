using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarManagerStep3
{
    class MainClass  
    {
        
        static void ShowDirectoryInfo(DirectoryInfo directory, int cursor, int first)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            int index = 0;
            foreach(FileSystemInfo f in fs)
            {
                if (index == cursor)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(f.Name);
                }
                else if (f.GetType() == typeof(DirectoryInfo))
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
                 
                index++;
            }

        }

        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DirectoryInfo directory = new DirectoryInfo(@"/Users/adilsaidagali/Desktop/example");

            int cursor = 0;
            int first = 0;
            ShowDirectoryInfo(directory, cursor, first);
            int n = directory.GetFileSystemInfos().Length;
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                }
                if (cursor < 0)
                {
                    cursor = n - 1;

                }
                
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                }
              
                if (cursor == n)
                {
                    first = 0;
                    cursor = 0;
                }
              
                if (keyinfo.Key == ConsoleKey.Escape)
                {
                    if (directory.Parent != null)
                    {
                        directory = directory.Parent;
                        cursor = 0;
                        n = directory.GetFileSystemInfos().Length;
                        first = 0;
                    }
                    else
                        break;
                }
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    if (directory.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        directory = (DirectoryInfo)directory.GetFileSystemInfos()[cursor];
                        cursor = 0;
                        n = directory.GetFileSystemInfos().Length;
                        first = 0;
                    }
                    else 
                    {
                        StreamReader d = new StreamReader(directory.GetFileSystemInfos()[cursor].FullName);
                        string z = d.ReadToEnd();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(z);
                        Console.ReadKey();
                    }
                }
                ShowDirectoryInfo(directory, cursor, first);
            }

        }
    }
}
