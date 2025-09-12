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
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {

        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            progressBarLoad.Value = Convert.ToInt32(progressBarLoad.Value) + 5;
            lblResult.Text = "Loading..." + progressBarLoad.Value.ToString() + "%";
            
            if (progressBarLoad.Value == 100 )
            {
               
                timerLoad.Enabled = false;
                Loopingcs loopingcs = new Loopingcs();
                loopingcs.Show();
                this.Hide();
            }
        }
    }
}
