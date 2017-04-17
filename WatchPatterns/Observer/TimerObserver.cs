using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    class TimerObserver : IObserver
    {
      public void OnHandleEvent(TimeSpan time)
        {
            TimeViewForm form = new TimeViewForm("Timer");
            form.Show();
        }
    }
}

