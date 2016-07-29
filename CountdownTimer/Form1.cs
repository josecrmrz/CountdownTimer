using System;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
            timerCountDown.Start();
        }

        private void timerCountDown_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            Text = lblTimer.Text;
        }
    }
}
