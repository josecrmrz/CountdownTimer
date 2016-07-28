using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerCountDown.Start();
        }

        private void timerCountDown_Tick_1(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
        }
    }
}
