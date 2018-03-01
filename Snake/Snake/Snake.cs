using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
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
                body[0].x = Console.LargestWindowWidth - 1;
            if (body[0].x == Console.LargestWindowWidth)
                body[0].x = 0;
            if (body[0].y == -1)
                body[0].y = Console.WindowHeight - 2;
            if (body[0].y == Console.WindowHeight - 1)
                body[0].y = 0;
        }

        public bool Eat(Food food)
        {
            if (body[0].x == food.location.x && body[0].y == food.location.y)
            {
                body.Add(new Point(body[body.Count() - 1].x, body[body.Count() - 1].y));
                return true;
            }
            return false;
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

    }
}