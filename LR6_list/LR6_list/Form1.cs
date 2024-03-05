using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6_list
{
    
    public partial class Form1 : Form
    {
        public static List<elem> lst;
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst = new List<elem>();
            List l1;
            l1 = new List();
            l1.Show();
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
