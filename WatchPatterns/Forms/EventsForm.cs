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
        private List<string> events;
        private IObserver goingBeDeletedEvent;

        public EventsForm(Watch watch)
        {
            InitializeComponent();
            this.watch = watch;
            events = new List<string>();
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
            string info = comboBox.Text;
            switch (comboBox.Text)
            {
                case "Alarm":
                    newEvent = new AlarmObserver(watch, "alarm.wav", curUserTime);
                    info += ":  " + curUserTime.ToLongTimeString();
                    break;
                case "Timer":
                    newEvent = new TimerObserver(watch, "alarm.wav", curUserTime);
                    info += ":  " + curUserTime.ToLongTimeString();
                    break;
                case "Stopwatch":
                    newEvent = new StopwatchObserver(watch);
                    break;
            }
            events.Add(info);
            eventsGrid.Rows.Add(info);
        }

        private void showEventsBtn_Click(object sender, EventArgs e)
        {
            if (showEventsBtn.Text.Equals("Hide"))
            {
                this.Height -= 170;
                showEventsBtn.Text = "Show all";
            }
            else
            {
                this.Height += 170;
                showEventsBtn.Text = "Hide";
            }
        }

        private void eventsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //goingBeDeletedEvent=ne
        }

        private void removeEvent_Btn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox.Text.Equals("Stopwatch")) groupBox.Enabled = false;
            else groupBox.Enabled = true;
        }
    }      
  }
