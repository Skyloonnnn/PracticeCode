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
    public partial class Loop : Form
    {
        public Loop()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            double x = 0;

            for (x = 0; x < 10;)
            {
                x++;
                Looping.Items.Add(x);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
            this.Hide();
        }
    }
}
