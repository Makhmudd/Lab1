using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Snake
{
    public class Wall
    {
        public List<Point> body;

        public Wall()
        {
            body = new List<Point>();
        }

        public void Levels(int level)
        {
            string path = @"/Users/adilsaidagali/Desktop/example/level";
            path += level.ToString() + ".txt";
            StreamReader sr = new StreamReader(path);
            for (int i = 0; i < 23; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '#')
                        body.Add(new Point(j, i));
            }
            sr.Close();
        }

        public void Draw()
        {
            foreach(Point point in body)
            {
                if (point.x > 0 && point.y > 0)
                    Console.SetCursorPosition(point.x, point.y);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("#");

            }
        }
    }


}
