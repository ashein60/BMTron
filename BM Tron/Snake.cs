using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BM_Tron
{
    public class Snake
    {
        private static Grid grid;

        private Brush snakeBrush;
        private int x, y, deltaX, deltaY; //delta is the direction and speed

        public static Grid Grid
        {
            set { grid = value; }
        }

        public int DeltaX
        {
            get { return deltaX; }
            set { deltaX = value; }
        }
        public int DeltaY
        {
            get { return deltaY; }
            set { deltaY = value; }
        }

        public Snake(Color snakeColor, int startX, int startY, int deltaX)
        {
            snakeBrush = new SolidBrush(snakeColor);
            x = startX;
            y = startY;

            this.deltaX = deltaX;
            deltaY = 0;
            FillSquare();
        }

        public bool Move()
        {
            bool canMove = false;

            if (x + deltaX >= 0 && x + deltaX < grid.Width)
            {
                if (y + deltaY >= 0 && y + deltaY < grid.Height)
                {
                    x += deltaX;
                    y += deltaY;

                    canMove = FillSquare();
                }
            }

            return canMove;
        }

        private bool FillSquare() //adds the snake to the new square
        {
            bool canMove;

            if (grid.Squares[x,y].Status == "empty")
            {
                grid.Squares[x, y].Status = "snake";
                grid.Squares[x, y].SnakeFill = snakeBrush;
                canMove = true;
            }
            else
            {
                canMove = false;
            }

            return canMove;
        }
    }
}
