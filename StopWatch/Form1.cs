using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour = 0;
        int minute = 0;
        int second = 0;
        int split_second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            split_second++;
            lblSplitSecond.Text = "" + split_second;
            if (split_second == 60)
            {
                second++;
                lblSecond.Text = "" + second;
                split_second = 0;
                if (second == 60)
                {
                    second = 0;
                    minute++;
                    lblMinute.Text = "" + minute;
                }
            }
            else if (minute == 60)
            {
                minute = 0;
                hour++;
                lblHour.Text = "" + hour;
            }
        }
    }
}
