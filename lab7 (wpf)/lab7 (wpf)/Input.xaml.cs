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
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public Input()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Edit ed1;
            ed1 = new Edit();
            ed1.t1.Text = MainWindow.lst[0].firm;
            ed1.t2.Text = Convert.ToString(MainWindow.lst[0].type);
            ed1.t3.Text = Convert.ToString(MainWindow.lst[0].power);
            ed1.Prev.IsEnabled = false;
            ed1.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string firm, type;
            int power;
            elem el;
            firm = t1.Text;
            type = t2.Text;
            power = Convert.ToInt32(t3.Text);
            el = new elem(firm, type, power);
            MainWindow.lst.Add(el);
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
        }

    }

}
