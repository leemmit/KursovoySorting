using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovoySorting.output
{
    class Notification
    {
        public static void notify(string title, string text)
        {
            Form1.NotifyIcon.BalloonTipTitle = title;
            Form1.NotifyIcon.BalloonTipText = text;
            Form1.NotifyIcon.ShowBalloonTip(2000);
        }
    }
}
