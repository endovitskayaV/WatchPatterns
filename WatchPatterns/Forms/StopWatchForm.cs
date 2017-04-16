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
    public partial class StopWatchForm : Form
    {
        private System.Timers.Timer timer;
        private DateTime time;

        public StopWatchForm()
        {
            InitializeComponent();
            time = new DateTime(1, 1, 1, 0, 0, 0);

            timer = new System.Timers.Timer();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
            MessageBox.Show("done");
        }

        
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
           
            time.AddSeconds(30);
            MessageBox.Show(time.ToLongTimeString());
            label.Text = time.ToLongTimeString();

        }
    }
}
