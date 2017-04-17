using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public class Watch : WatchComponent
    {
        public override void Draw(Label dL, Graphics graphTime)
        {
            DrawDate(dL);
        }

        private void DrawDate(Label dL)
        {
            dL.Text = Date.ToString("d");
            
        }
    }
}
