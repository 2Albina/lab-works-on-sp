using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6_list
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            List<elem> list_firm = new List<elem>();
            list_firm = Form1.lst.Where(p => max(p)).ToList();
            result1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var minEl = Form1.lst.Min(p => p.power);
            var maxEl = Form1.lst.Max(p => p.power);
            result2.Text = "[" + minEl + "; " + maxEl + "]";
        }

        private void result1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
