using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WatchPatterns
{
    class AnologTimeDecorator : TimeDecorator
    {
        public override void Draw(Label lb, Graphics graphTime)
        {
            Bitmap bitmap = new Bitmap(150, 150);
            Graphics grBuffer = Graphics.FromImage(bitmap);
            grBuffer.DrawImage(Image.FromFile("clock.jpg"), 0, 0);
            grBuffer.DrawLine(new Pen(Brushes.Black, 1), 75, 75, (float)(65 * Math.Sin(this.Time.Seconds * 6 * (Math.PI / 180)) + 75), (float)(65 * Math.Cos(this.Time.Seconds * 6 * (Math.PI / 180)) * (-1) + 75));
            grBuffer.DrawLine(new Pen(Brushes.Black, 2), 75, 75, (float)(60 * Math.Sin(this.Time.Minutes*6* (Math.PI / 180)) + 75), (float)(60 * Math.Cos(this.Time.Minutes * 6 * (Math.PI / 180)) * (-1) + 75));
            double h = (this.Time.Hours);
            if (h > 12)  h -= 12;
            h = (h+ this.Time.Minutes / 60.0)*30*(Math.PI / 180);
            grBuffer.DrawLine(new Pen(Brushes.Black, 3), 75, 75, (float)( 50*Math.Sin(h) +75), (float)(50* Math.Cos(h)*(-1)  + 75));
            graphTime.DrawImage(bitmap, 0, 0);
            grBuffer.Dispose();
            base.Draw(lb, graphTime);
        }
    }
}
