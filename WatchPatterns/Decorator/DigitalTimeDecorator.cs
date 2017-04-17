using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WatchPatterns
{
    class DigitalTimeDecorator : TimeDecorator
    {
        public override void Draw(Label lb, Graphics graphTime)
        {
            graphTime.DrawString(this.watch.Time.ToString("hh':'mm':'ss"), new Font(new FontFamily("Times New Roman"), 30), new SolidBrush(Color.Blue), 0, 50);
            base.Draw(lb, graphTime);
        }
    }
}
