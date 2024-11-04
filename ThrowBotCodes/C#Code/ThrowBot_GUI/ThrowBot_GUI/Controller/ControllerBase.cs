using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ThrowBot_GUI.Controller
{
    public abstract class ControllerBase
    {
        protected static void ChangeLabel(Label label, string text)
        {
            if(label.IsHandleCreated) 
                label.Invoke((MethodInvoker)delegate{ label.Text = text; });
            else
                label.Text = text;
        }

        protected static void ChangePanel(Panel panel, String color)
        {
            if (panel.IsHandleCreated)
                if(color == "Red")
                    panel.Invoke((MethodInvoker)delegate { panel.BackColor = Color.FromArgb(255, 10, 10); });
                else if(color == "Green")
                    panel.Invoke((MethodInvoker)delegate { panel.BackColor = Color.FromArgb(10, 255, 10); });
        }

        protected static void ChangePictureBox(PictureBox pictureBox, Bitmap bitmap)
        {
            if (pictureBox.IsHandleCreated)
                pictureBox.Invoke(new Action(() => pictureBox.Image = bitmap));
            else
                pictureBox.Image = bitmap;
        }
    }
}



