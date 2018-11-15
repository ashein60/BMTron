using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace BM_Tron
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer moveTimer;
        private Grid grid;
        private Snake player1, player2;

        public MainForm()
        {
            InitializeComponent();
            CreateTimer();
        }

        //Start/Stop game
        private void StartGame()
        {
            startPanel.Hide();
            startPanel.Enabled = false;

            int width = (this.Size.Width - 16) / Square.Size;
            int height = (this.Size.Height - 39) / Square.Size;
            grid = new Grid(width, height); //size needs to be divisible by square size

            Snake.Grid = grid; //gives the snake access the the grid
            player1 = new Snake(Color.Red, width / 4, height / 2, 1);
            player2 = new Snake(Color.DeepSkyBlue, width - width / 4, height / 2, -1);

            moveTimer.Start(); //starts the timer
        }
        private void EndGame()
        {
            grid = null;
        }

        //Timer
        private void CreateTimer()
        {
            moveTimer = new System.Timers.Timer();
            moveTimer.Elapsed += MoveSnakes;
            moveTimer.AutoReset = true;
            moveTimer.Enabled = false;
        }
        private void MoveSnakes(object sender, ElapsedEventArgs e)
        {
            if (!(player1.Move() && player2.Move())) //if can't move
            {
                moveTimer.Stop();
                EndGame();
            }
            else
            {
                Invalidate();
            }
        }

        //Key Events
        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (grid == null)
            {
                startPanel.Show();
                startPanel.Enabled = true;
            }
            else
            {
                if (player1 != null) //Player 1
                {
                    if (e.KeyCode == Keys.W && player1.DeltaY != 1)
                    {
                        player1.DeltaX = 0;
                        player1.DeltaY = -1;
                    }
                    else if (e.KeyCode == Keys.D && player1.DeltaX != -1)
                    {
                        player1.DeltaX = 1;
                        player1.DeltaY = 0;
                    }
                    else if (e.KeyCode == Keys.S && player1.DeltaY != -1)
                    {
                        player1.DeltaX = 0;
                        player1.DeltaY = 1;
                    }
                    else if (e.KeyCode == Keys.A && player1.DeltaX != 1)
                    {
                        player1.DeltaX = -1;
                        player1.DeltaY = 0;
                    }
                }

                if (player2 != null) //Player 2
                {
                    if (e.KeyCode == Keys.Up && player2.DeltaY != 1)
                    {
                        player2.DeltaX = 0;
                        player2.DeltaY = -1;
                    }
                    else if (e.KeyCode == Keys.Right && player2.DeltaX != -1)
                    {
                        player2.DeltaX = 1;
                        player2.DeltaY = 0;
                    }
                    else if (e.KeyCode == Keys.Down && player2.DeltaY != -1)
                    {
                        player2.DeltaX = 0;
                        player2.DeltaY = 1;
                    }
                    else if (e.KeyCode == Keys.Left && player2.DeltaX != 1)
                    {
                        player2.DeltaX = -1;
                        player2.DeltaY = 0;
                    }
                }
            }
        }

        //Button Events
        private void Click_Easy(object sender, MouseEventArgs e)
        {
            moveTimer.Interval = 70;
            StartGame();
        }
        private void Click_Medium(object sender, MouseEventArgs e)
        {
            moveTimer.Interval = 50;
            StartGame();
        }
        private void Click_Hard(object sender, MouseEventArgs e)
        {
            moveTimer.Interval = 30;
            StartGame();
        }
        private void Click_Insane(object sender, MouseEventArgs e)
        {
            moveTimer.Interval = 10;
            StartGame();
        }

        //Paint
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (grid != null)
            {
                Brush emptyFill = new SolidBrush(Color.Black);

                grid.Paint(e, emptyFill);

                emptyFill.Dispose();
            }
        }
    }
}
