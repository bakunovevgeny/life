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

        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            bStart.Enabled = false;
            res = (int)nudResolution.Value;
            rows = pictureBox1.Height / res;
            cols = pictureBox1.Width / res;
            field = new bool[cols, rows];

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

        private void nextGen()
        {
            graphics.Clear(Color.Gray);

            var newField = new bool[cols, rows];

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextGen();
        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }
    }
}
