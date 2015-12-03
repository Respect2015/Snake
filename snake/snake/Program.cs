using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            DownLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake Snake = new Snake(p, 4 , Direction.RIGHT);
            Snake.Draw();

            FoodCreator FoodCreator = new FoodCreator( 80, 25,'$');
            Point Food = FoodCreator.CreateFood();
            Food.Draw();

            while (true)
            {
                if (Snake.Eat(Food))
                {
                    Food = FoodCreator.CreateFood();
                    Food.Draw();
                }
                else 
                {
                    Snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.HandleKey(key.Key);
                }
            }
        }
    }
}
