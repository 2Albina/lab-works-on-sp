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

namespace LR6_list
{
    public partial class change : Form
    {
        public static int cur = 0;
        public change()
        {
            InitializeComponent();
            checkButton();
            textFirm.Text = Form1.lst[cur].firm;
            textType.Text = Form1.lst[cur].type;
            textPower.Text = Convert.ToString(Form1.lst[cur].power);
        }
        public void checkButton()
        {
            Prev.Enabled = (cur > 0);
            Next.Enabled = (cur + 1 < Form1.lst.Count());
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            Form1.lst.Remove(Form1.lst[cur]);
            textFirm.Text = "";
            textType.Text = "";
            textPower.Text = "";
            if (cur != 0) cur--;
            checkButton();
            textFirm.Text = Form1.lst[cur].firm;
            textType.Text = Form1.lst[cur].type;
            textPower.Text = Convert.ToString(Form1.lst[cur].power);
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (cur > 0)
            {
                cur--;
                textFirm.Text = Form1.lst[cur].firm;
                textType.Text = Form1.lst[cur].type;
                textPower.Text = Convert.ToString(Form1.lst[cur].power);
            }
            checkButton();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (cur + 1 < Form1.lst.Count())
            {
                cur++;
                textFirm.Text = Form1.lst[cur].firm;
                textType.Text = Form1.lst[cur].type;
                textPower.Text = Convert.ToString(Form1.lst[cur].power);
            }
            checkButton();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textPower_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.lst[cur].firm = textFirm.Text;
            Form1.lst[cur].type = textType.Text;
            Form1.lst[cur].power = Convert.ToInt32(textPower.Text);
        }
    }
}
