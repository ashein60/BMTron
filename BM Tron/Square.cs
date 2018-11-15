using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BM_Tron
{
    public class Square
    {
        private static int size = 10;

        private int x, y;
        private string status; //empty or snake
        private Brush snakeFill;

        public static int Size
        {
            get { return size; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Brush SnakeFill
        {
            set { snakeFill = value; }
        }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;

            status = "empty";
        }

        public void Paint(PaintEventArgs e, Brush emptyFill)
        {
            if (status == "empty")
            {
                e.Graphics.FillRectangle(emptyFill, x, y, size, size);
            }
            else
            {
                e.Graphics.FillRectangle(snakeFill, x, y, size, size);
            }
        }
    }
}
