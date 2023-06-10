using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void btnSum_Click(object sender, EventArgs e)
        {

            try
            {
                double x = Convert.ToInt32(txt1.Text);
                double y = Convert.ToInt32(txt2.Text);
                double q = x + y;
                txtRes.Text = Convert.ToString(q);
            }

            catch
            {
                MessageBox.Show("خطا");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToInt32(txt1.Text);
                double y = Convert.ToInt32(txt2.Text);
                double q = x * y;
                txtRes.Text = Convert.ToString(q);
            }

            catch
            {
                MessageBox.Show("خطا");
            }
        }

        private void btnDevid_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToInt32(txt1.Text);
                double y = Convert.ToInt32(txt2.Text);
                double q = x / y;
                txtRes.Text = Convert.ToString(q);
            }

            catch
            {
                MessageBox.Show("خطا");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToInt32(txt1.Text);
                double y = Convert.ToInt32(txt2.Text);
                double q = x - y;
                txtRes.Text = Convert.ToString(q);
            }

            catch
            {
                MessageBox.Show("خطا");
            }
        }
    }
}
