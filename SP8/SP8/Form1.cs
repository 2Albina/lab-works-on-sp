using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace SP8
{
    public partial class Form1 : Form
    {
        Thread Th0, Th1, Th2;
        Bitmap b0, b1;
        Stopwatch t0, t1;
        TimeSpan ts0, ts1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainTh = Thread.CurrentThread;
            tB1.Text = "Имя домена: " + Thread.GetDomain().FriendlyName +
                       "\nИдентификатор контекста : " + Thread.CurrentContext.ContextID +
                       "\nСтатус выполнения текущего потока: " + mainTh.IsAlive +
                       "\nУровень приоритета потока: " + mainTh.Priority +
                       "\nСостояние текущего потока: " + mainTh.ThreadState +
                       "\nID: " + mainTh.ManagedThreadId +
                       "\nBackground:" + mainTh.IsBackground +
                       "\nThread Pool: " + mainTh.IsThreadPoolThread;

            Th0 = new Thread(func_Task0);
            Th1 = new Thread(func_Task1);
            Th2 = new Thread(func_SystemInfo);
        }

        //подпрограмма определения областей квадратов при разбиении на части
        public void F_square(int j, Bitmap b0, out int x0, out int y0, out int x1, out int y1)
        {
            x0 = 0; y0 = 0; x1 = 0; y1 = 0;

            if ((j >= 0) && (j <= 2))
            {
                y0 = 0;
                y1 = (int)(b0.Height / 3);
            }
            else if ((j >= 3) && (j <= 5))
            {
                y0 = (int)(b0.Height / 3);
                y1 = (int)(2 * b0.Height / 3);
            }
            else if ((j >= 6) && (j <= 8))
            {
                y0 = (int)(2 * b0.Height / 3);
                y1 = b0.Height;
            }
            if (j % 3 == 0)
            {
                x0 = 0;
                x1 = (int)(b0.Width / 3);
            }
            else if (j % 3 == 1)
            {
                x0 = (int)(b0.Width / 3);
                x1 = (int)(2 * b0.Width / 3);
            }
            else if (j % 3 == 2)
            {
                x0 = (int)(2 * b0.Width / 3);
                x1 = b0.Width;
            }
        }

        //деление в правильном порядке 
        public void cut_Task(Bitmap b0, List<Tuple<Bitmap, int>> list1)
        {
            int x0, y0, x1, y1;
            for (int j = 0; j < 9; j++)
            {
                F_square(j, b0, out x0, out y0, out x1, out y1);
                int w = x1 - x0;
                int h = y1 - y0;
                Rectangle rect = new Rectangle(x0, y0, w, h);

                System.Drawing.Imaging.PixelFormat format = b0.PixelFormat;
                Bitmap b_clone = b0.Clone(rect, format);

                var curr_b = new Tuple<Bitmap, int>(b_clone, j);
                list1.Add(curr_b);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TB2.Text = "";
                t0 = new Stopwatch();
                t0.Start();
                Th0.Start();

                t1 = new Stopwatch();
                t1.Start();
                Th1.Start();

                Th2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n" + ex, "Исключение");
            }
        }

        private void PB2_Click(object sender, EventArgs e)
        {

        }

        private void PB1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {

        }

        //деление в произвольном порядке 
        public void random_Cut(Bitmap b0, List<Tuple<Bitmap, int>> list1, Graphics dc1)
        {
            int x0, y0, x1, y1;
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                int i1 = 0;
                int i2 = 0;
                while (i1 == i2)
                {
                    i1 = rnd.Next(0, 9);
                    i2 = rnd.Next(0, 9);
                }

                var tmp_bmp = list1[i1];
                list1[i1] = list1[i2];
                list1[i2] = tmp_bmp;
            }
            for (int j = 0; j < 9; j++)
            {
                F_square(j, b0, out x0, out y0, out x1, out y1);
                int w = x1 - x0;
                int h = y1 - y0;
                Rectangle rect = new Rectangle(x0, y0, w, h);
                dc1.DrawImage(list1[j].Item1, x0, y0, w, h);
            }
        }

        public void func_Task0()
        {
            List<Tuple<Bitmap, int>> list1 = new List<Tuple<Bitmap, int>>();
            List<Tuple<Bitmap, int>> list2 = new List<Tuple<Bitmap, int>>();

            Random rnd = new Random();
            Bitmap b0 = new Bitmap(@"D:\study_mpei\семестр 5\SP\SP8\cat.bmp", true);
            int x0, y0, x1, y1;
            Graphics dc1 = PB1.CreateGraphics();

            //разбиваем bitmap на части по порядку
            cut_Task(b0, list1);
            random_Cut(b0, list1, dc1);
            bool fl1 = false;

            for (int i = 0; i < 9; i++)
            { list2.Add(list1[i]); }

            for (int i = 0; i < 9; i++)
            {
                while (list1[i].Item2 != i)
                {
                    list1[i] = list2[rnd.Next(0, 9)];
                    F_square(i, b0, out x0, out y0, out x1, out y1);
                    int w = x1 - x0;
                    int h = y1 - y0;
                    Rectangle rect = new Rectangle(x0, y0, w, h);
                    Thread.Sleep(rnd.Next(50, 150));
                    dc1.DrawImage(list1[i].Item1, x0, y0, w, h);
                }
            }

            t0.Stop();
            //Доступный только для чтения объект TimeSpan, который представляет общее затраченное время, измеренное текущим экземпляром.
            ts0 = t0.Elapsed;
            this.TB2.BeginInvoke((MethodInvoker)(delegate {
                this.TB2.Text = this.TB2.Text + "Время 1-го потока: \n" +
                String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts0.Hours, ts0.Minutes, ts0.Seconds, ts0.Milliseconds / 10) + "\n";
            }));
            Th0.Abort();
            return;

        }
        public void func_Task1()
        {
            List<Tuple<Bitmap, int>> list3 = new List<Tuple<Bitmap, int>>();
            List<Tuple<Bitmap, int>> list4 = new List<Tuple<Bitmap, int>>();
            Random rnd = new Random();
            Bitmap b1 = new Bitmap(@"D:\study_mpei\семестр 5\SP\SP8\newyear1.bmp", true);
            int x0, y0, x1, y1;
            Graphics dc2 = PB2.CreateGraphics();

            //разбиваем bitmap на части по порядку
            cut_Task(b1, list3);
            random_Cut(b1, list3, dc2);
            bool fl1 = false;

            for (int i = 0; i < 9; i++)
            { list4.Add(list3[i]); }

            for (int i = 0; i < 9; i++)
            {
                while (list3[i].Item2 != i)
                {
                    list3[i] = list4[rnd.Next(0, 9)];
                    F_square(i, b1, out x0, out y0, out x1, out y1);
                    int w = x1 - x0;
                    int h = y1 - y0;
                    Rectangle rect = new Rectangle(x0, y0, w, h);
                    Thread.Sleep(50);
                    dc2.DrawImage(list3[i].Item1, x0, y0, w, h);
                }
            }

            t1.Stop();
            //Доступный только для чтения объект TimeSpan, который представляет общее затраченное время, измеренное текущим экземпляром.
            ts1 = t1.Elapsed;
            this.TB2.BeginInvoke((MethodInvoker)(delegate { this.TB2.Text = this.TB2.Text + "Время 2-го потока: \n" + 
                String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10) + "\n";
            }));
            Th1.Abort();
            return;
        }

        private void func_SystemInfo()
        {
            var output = new StringBuilder();
            output.AppendFormat("Версия Windows: {0}\n", Environment.OSVersion);
            output.AppendFormat("64 Bit операционная система? : {0}\n",
                Environment.Is64BitOperatingSystem ? "Да" : "Нет");
            output.AppendFormat("Имя компьютера: {0}\n", Environment.MachineName);
            output.AppendFormat("Число процессоров: {0}\n", Environment.ProcessorCount);
            output.AppendFormat("Системная папка : {0}\n", Environment.SystemDirectory);
            output.AppendFormat("Текущая директория: {0}\n", Environment.CurrentDirectory);
            output.AppendFormat("UserDomainName: {0}\n", Environment.UserDomainName);
            output.AppendFormat("UserInteractive: {0}\n", Environment.UserInteractive);
            output.AppendFormat("WorkingSet: {0}\n", Environment.WorkingSet);
            output.AppendFormat("Логические диски : {0}\n",
                string.Join(", ", Environment.GetLogicalDrives())
                    .Replace("\\", string.Empty));

            Th0.Join();
            Th1.Join();

            var graphicWnd = CreateGraphics();
            var font = new Font("Arial", 11, FontStyle.Italic);
            graphicWnd.Clear(Color.White);
            graphicWnd.DrawString(output.ToString(), font, Brushes.Black, 10, 350);
        }
    }
}
