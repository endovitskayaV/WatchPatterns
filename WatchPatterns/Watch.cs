using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public class Watch : WatchComponent, IObservable
    {
        public override void Draw(Label dL, Graphics graphTime)
        {
            DrawDate(dL);
        }

        private void DrawDate(Label dL)
        {
            dL.Text = Date.ToString("d");
            
        }

        public void AddObserver(IObserver o) { }
        public void RemoveObserver(IObserver o) { }
        public void NotifyObservers() { }
       
       
    }
}
