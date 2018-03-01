using System;

namespace Snake
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Snake snake = new Snake();
            Food food = new Food();
            Wall wall = new Wall();
            wall.Levels(2);

            Console.Clear();
            wall.Draw();
            snake.Draw();
            food.Draw();


            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (key.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (key.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (key.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (snake.Eat(food) == true) food.RandomPosition();
                Console.Clear();
                wall.Draw();
                snake.Draw();
                food.Draw();

            }
        }
    }
}

