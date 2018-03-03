using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food
    {
        public int x, y;
        public char sign;
        public ConsoleColor color;

        public Food()
        {
            color = ConsoleColor.DarkGreen;
            sign = '@';
            int x = new Random().Next(1, 63);
            int y = new Random().Next(1, 22);
        }


        public void NewPosition(List<Point> body, List<Point> body1)
        {
            while (true)
            {
                bool k = false;
                x = new Random().Next(1, 63);
                y = new Random().Next(1, 22);
                foreach (Point b in body)
                {
                    if (x == b.x && y == b.y)
                        k = true;

                }
                foreach (Point b in body1)
                {
                    if (x == b.x && y == b.y)
                        k = true;
                }
                if (k == false)
                    break;
            }    
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x , y);
            Console.WriteLine(sign);
        }
    }
}
