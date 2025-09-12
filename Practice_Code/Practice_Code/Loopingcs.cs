using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Code
{
    public partial class Loopingcs : Form
    {
        public Loopingcs()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            double x = 0;

            for (x = 0; x < 10;)
            {
               x++;
               lbLoop.Items.Add(x);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
