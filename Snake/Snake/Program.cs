using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace Snake
{
    class MainClass
    {
        public static int x = 1, y = 0, maxlevel, score, levelorder, speed = 200;
        public static Snake snake = new Snake();
        public static Food food = new Food();
        public static Wall wall = new Wall();
        public static bool PlayGame = true;
        public static ConsoleKeyInfo key;
        public static void Function()
        {
            score = 0;
            levelorder = 1;
            wall.Levels(levelorder);
            food.x = 10;
            food.y = 5;
            Console.Clear();
           
            while (PlayGame)
            {
                snake.Move(x, y);
                if (snake.CheckGame(wall.body))
                {
                    Console.Clear();
                    PlayGame = false;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, but you lose");
                    Console.ReadKey();

                }

                if (snake.body[0].x == food.x && snake.body[0].y == food.y)
                {
                    snake.AddToBody();
                    food.NewPosition(snake.body, wall.body);
                    score++;
                    speed = Math.Max(100, speed - 10);
                }

                if (score != 0 && score % 5 == 0 && levelorder < maxlevel)
                {
                    Console.Clear();
                    levelorder++;
                    wall.Levels(levelorder);
                    snake.body.Clear();
                    wall.Draw();
                    snake.body.Add(new Point(4, 3));
                    score = 0;
                    x = 1;
                    y = 0;
                }

                if (score != 0 && score % 5 == 0 && levelorder == maxlevel)
                {
                    Console.Clear();
                    Console.WriteLine("Your maximal score is" + " " + (levelorder * 5));
                    Console.ReadKey();
                }

                Console.Clear();
                snake.Draw();
                food.Draw();
                wall.Draw();
                Console.WriteLine("Score" + " " + (score + levelorder * 5 - 5));
                Thread.Sleep(speed);
            }
        }
        public static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Адиль\Desktop\KBTU\PP2_Snake\Snake\Levels");
            maxlevel = directory.GetFiles().Length;
            Console.CursorVisible = false;
            Thread t = new Thread(Function);
            t.Start();
            while (PlayGame)
            {
                 key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow && y != 1)
                {
                    x = 0;
                    y = -1;
                }

                if (key.Key == ConsoleKey.DownArrow && y != -1)
                {
                    x = 0;
                    y = 1;
                }
                if (key.Key == ConsoleKey.LeftArrow && x != 1)

                {
                    x = -1;
                    y = 0;
                }
                if (key.Key == ConsoleKey.RightArrow && x != -1)

                {
                    x = 1;
                    y = 0;
                }
                  
            }
                   
        }
    }

}

