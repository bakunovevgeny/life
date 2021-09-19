using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life_UI
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int res;
        private bool [,] field;
        private int rows, cols;
        private int generation = 0, time = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame() 
        {
            if (timer1.Enabled)
                return;

            bPause.Enabled = true;
            bProceed.Enabled = true;
            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            res = (int)nudResolution.Value;
            rows = pictureBox1.Height / res;
            cols = pictureBox1.Width / res;
            field = new bool[cols, rows];
            time = generation = 0;
            Text = $"Gen {generation}";

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nudDensity.Value) == 0;
                }
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            timer1.Start();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            else
                timer1.Stop();

            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
            bPause.Enabled = false;
            bProceed.Enabled = false;

        }

        private void nextGen()
        {
            graphics.Clear(Color.Gray);

            var newField = new bool[cols, rows];

            Text = $"Gen {++generation}";

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var Neightbours = NeightboursCount(x, y);
                    var life = field[x, y];

                    if(Neightbours == 3 && !life)
                        newField[x, y] = true;
                    else if ((Neightbours < 2 || Neightbours > 3) && life)
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];

                    if (life)
                        graphics.FillRectangle(Brushes.Crimson, x * res, y * res, res, res);

                }
            }

            field = newField;
            pictureBox1.Refresh();
        }

        private int NeightboursCount(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;
                    bool selfCheck = col == x && row == y;
                    bool haslife = field[col, row];

                    if (haslife && !selfCheck)
                    {
                        count++;
                    }
                }

            return count;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var validate = MousePositionCheck(x, y);
                if (validate)
                    field[x, y] = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var validate = MousePositionCheck(x, y);
                if(validate)
                    field[x, y] = false;
            }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                return;
            else
                timer1.Stop();
        }

        private void bProceed_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            else
                timer1.Start();
        }

        private bool MousePositionCheck(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time % (int)nudSpeedGame.Value == 0)
                nextGen();
            time++;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
    }
}
