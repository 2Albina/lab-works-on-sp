using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace lab7__wpf_
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        public Result()
        {
            InitializeComponent();
        }
        static int max_el = -1;
        static string s = "";
        static bool max(elem p)
        {
            if (p.power > max_el)
            {
                max_el = p.power;
                s = "";
            }
            if (p.power == max_el)
            {
                s += Convert.ToString(p.firm) + " ";
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richBox1.Content = "";
            List<elem> list_firm = new List<elem>();
            list_firm = MainWindow.lst.Where(p => max(p)).ToList();
            richBox1.Content = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var minEl = MainWindow.lst.Min(p => p.power);
            var maxEl = MainWindow.lst.Max(p => p.power);
            richBox2.Content = "[" + minEl + "; " + maxEl + "]";
        }
    }
}
