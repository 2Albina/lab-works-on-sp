using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LR6_list
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firm, type;
            int power;
            elem el;
            firm = textFirm.Text;
            type = textType.Text;
            power = Convert.ToInt32(textPower.Text);
            el = new elem(firm, type, power);
            Form1.lst.Add(el);
            textFirm.Text = "";
            textType.Text = "";
            textPower.Text = "";
        }
        private void TaskBut_Click(object sender, EventArgs e)
        {
            Task t1;
            t1 = new Task();
            t1.Show();
        }

        private void ButChange_Click(object sender, EventArgs e)
        {
            change ch1;
            ch1 = new change();
            ch1.Show();
        }
        private void textFirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            
        }
        private void Next_Click(object sender, EventArgs e)
        {
        }
        
        private void CloseBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
        }
    }
}
