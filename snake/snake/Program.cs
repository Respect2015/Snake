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
            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake Snake = (Snake) fSnake;

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> Figures = new List<Figure>();
            Figures.Add(fSnake);
            Figures.Add(vl);
            Figures.Add(hl);

            foreach (var f in Figures)
            {
                f.Draw();
            }
        }

        static void Draw(Figure Figure) 
        {
            Figure.Draw();
        }
    }
}
