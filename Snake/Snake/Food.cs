using System;
namespace Snake
{
    public class Food
    {
        public char signn;
        public ConsoleColor color;
        public Point location;

        public Food()
        {
            color = ConsoleColor.DarkGreen;
            signn = '@';
            location = new Point(5, 5);
        }

        public void RandomPosition()
        {
            int x = new Random().Next(0, Console.LargestWindowWidth - 1);
            int y = new Random().Next(0, Console.WindowHeight - 2);
            location = new Point(x, y);
                                    
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.WriteLine(signn);
        }
    }
}
