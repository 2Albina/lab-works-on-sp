using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace lab7__wpf_
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public static int i = 0;
        public static int cur = 0;
        public Edit()
        {
            InitializeComponent();
        }
        public void checkButton()
        {
            Prev.IsEnabled = (cur > 0);
            Next.IsEnabled = (cur + 1 < MainWindow.lst.Count());
        }
        private void Prev_Click(object sender, EventArgs e)
        {
            if (cur > 0)
            {
                cur--;
                t1.Text = MainWindow.lst[cur].firm;
                t2.Text = MainWindow.lst[cur].type;
                t3.Text = Convert.ToString(MainWindow.lst[cur].power);
            }
            checkButton();
        }

        private void Nextt_Click(object sender, EventArgs e)
        {
            if (cur + 1 < MainWindow.lst.Count())
            {
                cur++;
                t1.Text = MainWindow.lst[cur].firm;
                t2.Text = MainWindow.lst[cur].type;
                t3.Text = Convert.ToString(MainWindow.lst[cur].power);
            }
            checkButton();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            MainWindow.lst.Remove(MainWindow.lst[cur]);
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            if (cur != 0) cur--;
            checkButton();
            t1.Text = MainWindow.lst[cur].firm;
            t2.Text = MainWindow.lst[cur].type;
            t3.Text = Convert.ToString(MainWindow.lst[cur].power);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            MainWindow.lst[i].firm = t1.Text;
            MainWindow.lst[i].type = t2.Text;
            MainWindow.lst[i].power = int.Parse(t3.Text);
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            Result res;
            res = new Result();
            res.Show();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
