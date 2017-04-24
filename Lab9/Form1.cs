using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string [] A = s.Split(',');
            int temp = 0;
            int nums = 0;
            int i = 0;
            while (i < A.Length)
            {
                nums = Convert.ToInt32(A[i]);
                temp += nums;
                i++;
            }
            label2.Text = (temp / i).ToString();
        }
    }
}
