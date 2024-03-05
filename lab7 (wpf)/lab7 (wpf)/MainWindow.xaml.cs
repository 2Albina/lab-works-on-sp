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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab7__wpf_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<elem> lst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About ab;
            ab = new About();
            ab.ShowDialog();
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            lst = new List<elem>();
            Input inp;
            inp = new Input();
            inp.Show();

        }
    }
    public class elem
    {
        public string firm;
        public string type;
        public int power;
        public elem(string f, string t, int p)
        {
            firm = f;
            type = t;
            power = p;
        }
    }
}
