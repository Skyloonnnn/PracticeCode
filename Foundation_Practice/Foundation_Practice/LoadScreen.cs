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
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            pbLoading.Value = Convert.ToInt32(pbLoading.Value)+1;
            lblLoading.Text = "Loading..." + pbLoading.Value.ToString() + "%";

            if (pbLoading.Value == 100) 
            {
                timerLoad.Enabled = false;
                Calculator calculator = new Calculator();
                calculator.Show();
                this.Hide();
            }
        }
    }
}
