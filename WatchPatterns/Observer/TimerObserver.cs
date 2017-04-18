using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WatchPatterns
{
    class TimerObserver : IObserver
    {
        private SoundPlayer sound;
        private IObservable watch;
        private DateTime timerTime;
        private Label label;
        private Form form;
        private bool IsRinging;

        public TimerObserver(IObservable watch, string soundString, DateTime time)
        {
            this.timerTime = time;
            this.watch = watch;
            watch.AddObserver(this);
            sound = new SoundPlayer(soundString);
            CreateForm();
            IsRinging = false;
        }
        public void OnHandleEvent(TimeSpan time)
        {
            if (timerTime.Hour == 0 && timerTime.Minute == 0 && timerTime.Second == 0 && (!IsRinging))
            {
                IsRinging= true;
                Ring();
                
            }
            else
            {
                timerTime = timerTime.AddSeconds(-1);
                //MessageBox.Show(alarmTime.ToLongTimeString());
               // label.Text = alarmTime.ToLongTimeString();
                form.Text= timerTime.ToLongTimeString(); 
            }
        }

        private void CreateForm()
        {
            form = new Form();
            form.Text= timerTime.ToLongTimeString();
            // label = new Label();
            // form.Controls.Add(label);
            // label.Text = "dhfg"; //alarmTime.ToLongTimeString();
            form.Show();
        }
        private void Ring()
        {
            sound.Play();
            if (MessageBox.Show("Time is up!") == DialogResult.OK)
            {
                sound.Stop();
                IsRinging = false;
                watch.RemoveObserver(this);      
            }
        }


    }
}//если форму закрыли-удалить из списка событий! 

