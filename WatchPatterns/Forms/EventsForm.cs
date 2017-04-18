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
    public partial class EventsForm : Form
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
            IObserver newEvent = new AlarmObserver();
            DateTime curUserTime = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day, (int)numericUpDownH.Value, (int)numericUpDownM.Value, (int)numericUpDownS.Value);
            MessageBox.Show(comboBox.Text+" added");
            switch (comboBox.Text)
            {
                case "Alarm":
                    newEvent = new AlarmObserver(watch, "alarm.wav", curUserTime);
                    break;
                case "Timer":
                    newEvent = new TimerObserver(watch, "alarm.wav", curUserTime);
                    break;
                case "Stopwatch":
                    newEvent = new StopwatchObserver();
                    break;
            }
            watch.AddObserver(newEvent);
        }
    }      
  }
