using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LAB3_W2
{

    class MainClass
    {
        static bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }
        public static void Main(string[] args)
        {
            StreamReader SR = new StreamReader(@"/Users/adilsaidagali/Desktop/example/input1.txt");
            string s = SR.ReadLine();
            string[] x = s.Split();
            int[] arr = new int[x.Length];
            int j = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (IsPrime(int.Parse(x[i])))
                {
                    arr[j] = int.Parse(x[i]);
                    j++;
                }
            }

            int mn = arr[0];
            for (int i = 0; i < j; i++)
            {
                if (mn > arr[i]) mn = arr[i];
            }

            StreamWriter SRR = new StreamWriter(@"/Users/adilsaidagali/Desktop/example/input2.txt", true);
            SRR.Write(mn);
            SRR.Close();

        }
    }
}

