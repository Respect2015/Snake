using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> pList;

        public  void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure Figure)
        {
            foreach (var p in pList)
            {
                if (Figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point Point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(Point))
                    return true;
            }
            return false;
        }
    }
}
