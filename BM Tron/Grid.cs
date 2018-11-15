using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BM_Tron
{
    public class Grid
    {
        private Square[,] squares;
        public Square[,] Squares
        {
            get { return squares; }
        }

        private int width, height;

        public int Width
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }

        public Grid(int numX, int numY)
        {
            squares = new Square[numX, numY];

            for (int x = 0; x < numX; x++)
            {
                for (int y = 0; y < numY; y++)
                {
                    squares[x, y] = new Square(x * Square.Size, y * Square.Size);
                }
            }

            width = numX;
            height = numY;
        }

        public void Paint(PaintEventArgs e, Brush emptyFill)
        {
            foreach (Square square in squares)
            {
                square.Paint(e, emptyFill);
            }
        }
    }
}
