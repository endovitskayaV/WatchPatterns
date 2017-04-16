using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchPatterns
{
    class TimerObserver : IObserver
    {

        public void Update(TimeSpan time)
        {
            EventsForm1 form = new EventsForm1();
            form.Show();
        }
    }
}

