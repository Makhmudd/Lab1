using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]

    public class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;
        
        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.DarkYellow;
            body = new List<Point>();
            body.Add(new Point(5, 10));
        }

        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

            if (body[0].x == -1)
                body[0].x = 62;
            if (body[0].x == 63)
                body[0].x = 0;
            if (body[0].y == -1)
                body[0].y = 21;
            if (body[0].y == 22)
                body[0].y = 0;
        }

        public void AddToBody()
        {
            Point p = new Point(body[body.Count - 1].x, body[body.Count - 1].y);
            body.Add(p);
        }

        public void Draw()
        {
            for (int i = 1; i < body.Count; i++)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.WriteLine(sign);

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(body[0].x, body[0].y);
            Console.WriteLine(sign);



        }
        public bool CheckGame(List<Point> body1)
        {
            for (int i = 1; i < body.Count; i++)
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            for (int i = 0; i < body1.Count; i++)
                if (body[0].x == body1[i].x && body[0].y == body1[i].y)
                    return true;
            return false;
        }
    }
}