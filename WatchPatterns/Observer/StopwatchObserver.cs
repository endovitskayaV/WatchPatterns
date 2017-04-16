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
        public void Update(TimeSpan time)
        {
            StopWatchForm form = new StopWatchForm();
            form.Show();
        }
       
    }
}

