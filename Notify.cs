using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekml
{
    class Notify:Form
    {
        public void NotiCreated()
        {
       
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipTitle = "Export Kml";
            notifyIcon1.BalloonTipText = "Kml File created";
            notifyIcon1.ShowBalloonTip(1000);
            notifyIcon1.Visible = true;
        }
    }
}
