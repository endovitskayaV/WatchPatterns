using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    class StopwatchObserver : IObserver
    {
        private Label label;
        private Form form;
        private DateTime time;

        public StopwatchObserver()
        {
            time = new DateTime(1, 1, 1, 0, 0, 0);
            CreateForm();
        }

        private void CreateForm()
        {
            form = new Form();
            form.Text = time.ToLongTimeString();
            // label = new Label();
            // form.Controls.Add(label);
            // label.Text = "dhfg"; //alarmTime.ToLongTimeString();
            form.Show();
        }
        public void OnHandleEvent(TimeSpan time)
        {
            this.time = this.time.AddSeconds(1);
            MessageBox.Show(this.time.ToLongTimeString());
            // label.Text = alarmTime.ToLongTimeString();
            form.Text = this.time.ToLongTimeString();
        }

    }
}

