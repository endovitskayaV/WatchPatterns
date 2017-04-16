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
    public partial class EventsForm : Form, IWatchForm
    {
        private Watch watch;
        public EventsForm(Watch watch)
        {
            InitializeComponent();
            this.watch = watch;
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            comboBox.SelectedItem = "Alarm";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Alarm": new AlarmObserver().Update(watch.Time); break;
                case "Timer": new TimerObserver().Update(watch.Time); break;
                case "Stopwatch": new StopwatchObserver().Update(watch.Time); break;
            }
        }

        public TimeSpan GetFormTime()
        {
            return new TimeSpan(Convert.ToInt32(numericUpDownH.Value), Convert.ToInt32(numericUpDownM.Value), Convert.ToInt32(numericUpDownS.Value));
        }
    }

        
    }
