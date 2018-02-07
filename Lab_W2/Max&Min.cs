using System;
using System.IO;

namespace LAB_W2
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            StreamReader SR = new StreamReader(@"/Users/adilsaidagali/Desktop/example/input.txt");
            string s = SR.ReadLine();
            // Console.WriteLine(s);
            //string x = Console.ReadLine();
            string[] x = s.Split();
            int mx = int.Parse(x[0]);
            for (int i = 1; i < x.Length; i++)
            {
                if (mx < int.Parse(x[i])) mx = int.Parse(x[i]);
            }

            int mn = int.Parse(x[0]);
            for (int i = 1; i < x.Length; i++)
                {
                    if (mn > int.Parse(x[i]))
                        mn = int.Parse(x[i]);
                }    
            Console.WriteLine(mx);
            Console.WriteLine(mn);
            Console.ReadKey();
        }
    
    }
}
