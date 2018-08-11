using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TSGame
{
    public static class Controls
    {
        public static void GetLocation(Control form)
        {
            foreach (Control control in form.Controls)
            {
                controlOrigin.Add(control, control.Location);
            }
        }

        public static void SetLocation(Control form)
        {
            foreach (Control control in form.Controls)
            {
                control.Location = controlOrigin[control];
            }
        }

        static Dictionary<Control, Point> controlOrigin = new Dictionary<Control, Point>();
    }
}
