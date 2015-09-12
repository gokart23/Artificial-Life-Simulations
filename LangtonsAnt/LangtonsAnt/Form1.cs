using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangtonsAnt
{
    public interface AntInterface
    {
        Image getCurrentImage(Point current);
        void updateState(Image image, Point current, Point next);
    }

    public partial class Form1 : Form, AntInterface
    {
        const int NUM_X = 10;
        const int NUM_Y = 10;
        Image White = LangtonsAnt.Properties.Resources.White;
        Image Black = LangtonsAnt.Properties.Resources.Black;
        Image Ant = LangtonsAnt.Properties.Resources.Ant;
        PictureBox[,] boxes = new PictureBox[NUM_X, NUM_Y];
        Ant myAnt;

        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("Yoohooo " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            this.holderPanel.ColumnCount = NUM_Y;
            this.holderPanel.RowCount = NUM_X;

            this.holderPanel.ColumnStyles.Clear();
            this.holderPanel.RowStyles.Clear();
            this.holderPanel.Controls.Clear();

            for (int i = 0; i < NUM_X; i++)
			{
                holderPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                for (int j = 0; j < NUM_Y; j++)
                {
                    holderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    boxes[i, j] = new PictureBox();
                    boxes[i, j].Image = Black;
                    holderPanel.Controls.Add(boxes[i,j], i, j);
                }
			}

            myAnt = new Ant(new Point(3, 3), this);
            boxes[3, 3].Image = Ant;
        }

        public Image getCurrentImage(Point current)
        {
            return boxes[current.X, current.Y].Image;
        }

        public void updateState(Image image, Point current, Point next)
        {
            boxes[current.X, current.Y].Image = image;
            boxes[next.X, next.Y].Image = Ant;
            Form1.ActiveForm.Invalidate();
            System.Threading.Thread.Sleep(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myAnt.go();
        }
    }
}