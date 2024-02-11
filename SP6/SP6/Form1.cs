using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SP6
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        bool emblem;
        bool olimpia;
        bool game;
        int[,] mas;
        bool turn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new List<Button>
            {
                task1,
                task2,
                task3,
            };

        }
        private static void DrawEmblem(Button button)
        {
            var e = Graphics.FromHwnd(button.Handle);
            e.FillEllipse(new SolidBrush(Color.Green), 5, 5, 30, 30);
            e.FillRectangle(new SolidBrush(Color.LightPink), 10, 10, 20, 20);
            e.DrawPolygon(new Pen(Color.LightGoldenrodYellow, 2), new Point[] { new Point(10, 10), new Point(30, 30) });
            e.DrawPolygon(new Pen(Color.LightGoldenrodYellow, 2), new Point[] { new Point(30, 10), new Point(10, 30) });
        }

        private void task1_Click(object sender, EventArgs e)
        {
            emblem = true;
            if (emblem)
                foreach (var x in buttons)
                    x.TextAlign = ContentAlignment.MiddleRight;
            olimpia = game = false;
            label1.Text = "";
            Refresh();
            DrawEmblem(buttons[0]);            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (emblem)
                foreach (var x in buttons)
                    DrawEmblem(x);
        }

        private void task2_Click(object sender, EventArgs e)
        {
            emblem = game = false;
            olimpia = true;
            label1.Text = "";
            Refresh();
        }

        private void task3_Click(object sender, EventArgs e)
        {
            emblem = olimpia = false;
            game = true;
            mas = new int[5, 5];
            label1.Text = "Ход первого игрока";
            label1.ForeColor = Color.Black;
            turn = false;
            Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (olimpia)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), new Rectangle(20, 50, 50, 50));
                e.Graphics.DrawEllipse(new Pen(Color.Yellow, 3), new Rectangle(50, 80, 50, 50));
                e.Graphics.DrawEllipse(new Pen(Color.Black, 3), new Rectangle(80, 50, 50, 50));
                e.Graphics.DrawEllipse(new Pen(Color.Green, 3), new Rectangle(110, 80, 50, 50));
                e.Graphics.DrawEllipse(new Pen(Color.Red, 3), new Rectangle(140, 50, 50, 50));
            }
            if (game)
            {
                var blackPen = new Pen(Color.Black, 1);
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(1, 1, 255, 255));
                for (var i = 0; i < 6; i++)
                {
                    e.Graphics.DrawLine(blackPen, 50 * i + i, 0, 50 * i + i, 254);
                    e.Graphics.DrawLine(blackPen, 0, 50 * i + i, 254, 50 * i + i);
                }
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!game) return;

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            new Point(0, 10),
            new Point(255, 10),
            Color.FromArgb(255, 255, 0, 0),
            Color.FromArgb(255, 0, 0, 255));

            Bitmap image1 = (Bitmap)Image.FromFile(@"D:/Programming/5 cеместр/SP/flowers.bmp", true);
            TextureBrush texture = new TextureBrush(image1);

            var xPos = e.X / 51;
            var yPos = e.Y / 51;
            var dc = pictureBox1.CreateGraphics();
            if (turn)
            {
                if (mas[yPos, xPos] != 2 && mas[yPos, xPos] != 1)
                {
                    dc.FillRectangle(linGrBrush,
                        new Rectangle(xPos * 51 + 1,
                            yPos * 51 + 1,
                            50, 50));
                    mas[yPos, xPos] = 1;
                    label1.Text = "Ход первого игрока";
                    label1.ForeColor = Color.Black;
                    turn = !turn;
                }
            }
            else
            {
                if (mas[yPos, xPos] != 2 && mas[yPos, xPos] != 1)
                {
                    dc.FillRectangle(texture,
                        new Rectangle(xPos * 51 + 1,
                            yPos * 51 + 1,
                            50, 50));
                    mas[yPos, xPos] = 2;
                    label1.Text = "Ход второго игрока";
                    label1.ForeColor = Color.Purple;
                    turn = !turn;
                }
            }

            var str = CheckWinner();
            if (str != -1)
            {
                if (str == 0)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Ничья!";
                }
                else
                {
                    label1.ForeColor = Color.ForestGreen;
                    if (str == 1)
                        label1.Text = "Первый победил!";
                    else
                        label1.Text = "Второй победил!";
                }

                game = false;
            }            
        }

        private bool CheckForDraw()
        {
            for (var i = 0; i < 5; i++)
                for (var j = 0; j < 5; j++)
                    if (mas[i, j] == 0)
                        return false;
            return true;
        }

        private int CheckWinner()
        {
            if (CheckForDraw()) return 0;

            for (var i = 0; i < 5; i++)
                for (var j = 0; j < 2; j++)
                    if (mas[i, j] > 0)
                        for (var k = j + 1; k < 5; k++)
                            if (mas[i, k] == mas[i, j])
                                switch (k - j)
                                {
                                    case 3 when mas[i, j] == 1:
                                        {
                                            return 2;
                                        }
                                    case 3:
                                        {
                                            return 1;
                                        }
                                }
                            else
                                break;
            for (var i = 0; i < 2; i++)
                for (var j = 0; j < 5; j++)
                    if (mas[i, j] > 0)
                        for (var k = i + 1; k < 5; k++)
                            if (mas[k, j] == mas[i, j])
                                switch (k - i)
                                {
                                    case 3 when mas[i, j] == 1:
                                        {
                                            return 2;
                                        }
                                    case 3:
                                        {
                                            return 1;
                                        }
                                }
                            else
                                break;

            return -1;
        }

        private void task1_MouseEnter(object sender, EventArgs e)
        {
            //task1.Refresh();
            if (emblem)
            {
                task1.Refresh();
                DrawEmblem(buttons[0]);
            }
        }

        private void task1_MouseLeave(object sender, EventArgs e)
        {
            //task1.Refresh();
            if (emblem)
            {
                task1.Refresh();
                DrawEmblem(buttons[0]);
            }
        }

        private void task1_Leave(object sender, EventArgs e)
        {
            //task1.Refresh();
            if (emblem)
            {
                task1.Refresh();
                DrawEmblem(buttons[0]);
            }
        }

        private void task2_MouseEnter(object sender, EventArgs e)
        {
            //task2.Refresh();
            if (emblem)
            {
                task2.Refresh();
                DrawEmblem(buttons[1]);
            }
        }

        private void task2_MouseLeave(object sender, EventArgs e)
        {
            //task2.Refresh();
            if (emblem)
            {
                task2.Refresh();
                DrawEmblem(buttons[1]);
            }
        }

        private void task1_Paint(object sender, PaintEventArgs e)
        {
            if (emblem)
            {
                //task1.Refresh();
                DrawEmblem(buttons[0]);
            }
        }

        private void task2_Paint(object sender, PaintEventArgs e)
        {
            if (emblem)
            {
                //task2.Refresh();
                DrawEmblem(buttons[1]);
            }
        }

        private void task3_Paint(object sender, PaintEventArgs e)
        {
            if (emblem)
            {
                //task3.Refresh();
                DrawEmblem(buttons[2]);
            }
        }

        private void task2_Leave(object sender, EventArgs e)
        {
            //task2.Refresh();
            if (emblem)
            {
                task2.Refresh();
                DrawEmblem(buttons[1]);
            }
        }

        private void task3_MouseEnter(object sender, EventArgs e)
        {
            if (emblem)
            {
                task3.Refresh();
                DrawEmblem(buttons[2]);
            }
        }

        private void task3_MouseLeave(object sender, EventArgs e)
        {
            if (emblem)
            {
                task3.Refresh();
                DrawEmblem(buttons[2]);
            }
        }
    }
}