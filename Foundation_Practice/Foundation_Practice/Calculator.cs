using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foundation_Practice
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirst.Text);
            double num2 = Convert.ToDouble(txtSecond.Text);

            double sum = num1 + num2;
            lblResult.Text = sum.ToString();

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirst.Text);
            double num2 = Convert.ToDouble(txtSecond.Text);

            double diff = num1 - num2;
            lblResult.Text = diff.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirst.Text);
            double num2 = Convert.ToDouble(txtSecond.Text);

            double quo = num1 / num2;
            lblResult.Text = quo.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirst.Text);
            double num2 = Convert.ToDouble(txtSecond.Text);

            double prod = num1 * num2;
            lblResult.Text = prod.ToString();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtSecond.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Loop loop = new Loop();
            loop.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
