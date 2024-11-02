using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}



