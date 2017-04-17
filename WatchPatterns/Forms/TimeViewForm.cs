using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public partial class TimeViewForm : Form
    {
        private System.Timers.Timer timer;
        private DateTime time;
        private string type;
        public event EventHandler OnHappens;

        public TimeViewForm(string type)
        {
            InitializeComponent();
            this.type = type;
            //if (type.Equals("Stopwatch"))  time = new DateTime(1, 1, 1, 0, 0, 0);
            //else time = new DateTime(1, 1, 1, EventsForm.h, EventsForm.m, EventsForm.s);
            timer = new System.Timers.Timer();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (type.Equals("Stopwatch"))
            {
                time = time.AddSeconds(1);
                label.Text = time.ToLongTimeString();
            }
            else
            {
                time = time.AddSeconds(-1);
                if (time.Hour==0 && time.Minute==0 && time.Second==0)
                {
                    label.Text = "Time is up!";
                    timer.Stop();
                }
                else
                {
                    time = time.AddSeconds(-1);
                    label.Text = time.ToLongTimeString();
                }
            }
            
        }
    }
}
