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
            grBuffer.DrawLine(new Pen(Brushes.Black), 75, 75, (int)Math.Truncate(75 + 75 * Math.Sin(2 * Math.PI * (double)this.Time.Seconds / 60)), (int)Math.Truncate(75 - 75 * Math.Cos(2 * Math.PI * (double)this.Time.Seconds / 60)));
            grBuffer.DrawLine(new Pen(Brushes.Black, 2), 75, 75, (int)Math.Truncate(75 + 60 * Math.Sin(2 * Math.PI * (double)this.Time.Minutes / 60)), (int)Math.Truncate(75 - 60 * Math.Cos(2 * Math.PI * (double)this.Time.Minutes / 60)));
            grBuffer.DrawLine(new Pen(Brushes.Black, 3), 75, 75, (int)Math.Truncate(75 + 45 * Math.Sin(2 * Math.PI * (double)this.Time.Hours / 12)), (int)Math.Truncate(75 - 45 * Math.Cos(2 * Math.PI * (double)this.Time.Hours / 12)));
            graphTime.DrawImage(bitmap, 0, 0);
            grBuffer.Dispose();
            base.Draw(lb, graphTime);
        }
    }
}
