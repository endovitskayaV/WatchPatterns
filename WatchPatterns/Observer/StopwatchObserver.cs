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
       public void OnHandleEvent(TimeSpan time)
        {
            TimeViewForm form = new TimeViewForm("Stopwatch");
            form.Show();
        }
       
    }
}

