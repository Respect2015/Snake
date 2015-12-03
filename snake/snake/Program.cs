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

            Walls Walls = new Walls(80, 25);
            Walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake Snake = new Snake(p, 4, Direction.RIGHT);
            Snake.Draw();

            FoodCreator FoodCreator = new FoodCreator(80, 25, '$');
            Point Food = FoodCreator.CreateFood();
            Food.Draw();

            while (true)
            {
                if (Walls.IsHit(Snake) || Snake.IsHitTail())
                {
                    break;
                }
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
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Snake.HandleKey(Key.Key);
                }
            }
        }

        static void Draw(Figure Figure) 
        {
            Figure.Draw();
        }
    }
}
