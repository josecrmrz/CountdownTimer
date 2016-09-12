using System;
using System.Drawing;
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
            DateTime original = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 30, 0);
            DateTime updated = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            TimeSpan timeleft = original.Subtract(updated);
            lblTimer.Text = timeleft.ToString();
            this.Text = lblTimer.Text;
            if (timeleft.ToString() == "00:01:00")
                lblTimer.ForeColor = Color.Red;
            if (timeleft.ToString() == "00:00:00")
                timerCountDown.Stop();
        }

        private void timerLabel_DoubleClick(object sender, EventArgs e)
        {
            timerCountDown.Start();
        }

    }
}
