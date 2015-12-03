using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> WallsList;

        public Walls(int mapWidth, int mapHeight)
        {
            WallsList = new List<Figure>();

            HorizontalLine UpLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine LeftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            WallsList.Add(UpLine);
            WallsList.Add(DownLine);
            WallsList.Add(LeftLine);
            WallsList.Add(RightLine);
        }

        internal bool IsHit(Figure Figure)
        {
            foreach (var Wall in WallsList)
            { 
                 if(Wall.IsHit(Figure))
                 {
                     return true;
                 }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var Wall in WallsList)
            {
                Wall.Draw();
            }
        }
    }
}
