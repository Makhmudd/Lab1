using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace training
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("a.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Complex c = bf.Deserialize(fs) as Complex;
            Console.WriteLine(c);
            /*
             * string s = Console.ReadLine();
            string[] x = s.Split();
            int k = 0;
            Complex ans = new Complex();
            foreach (string z in x)
            {
                string[] Com = z.Split('/');
                Complex a = new Complex(int.Parse(Com[0]), int.Parse(Com[1]));
                if (k == 0)

                    ans = a;
                else
                    ans = ans + a;
                k = 1;

                ans.Simplify();

            }
            try
            {
                bf.Serialize(fs, ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            finally
            {
                fs.Close();
            }

            */


            //Console.WriteLine(ans);

        }
    }
}
