using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteSurf
{
    public class jsInteraction
    {
        public bool fullscreen = false;

        private Form form;

        public jsInteraction(Form remoteSurf)
        {
            form = remoteSurf;
        }

        public void toggleFullScreen()
        {
            fullscreen = !fullscreen;
            if (form.InvokeRequired)
            {
                form.Invoke((MethodInvoker)delegate
                {
                    form.TopMost = fullscreen;
                    form.FormBorderStyle = (fullscreen) ? FormBorderStyle.None : FormBorderStyle.Sizable;
                    form.WindowState = (fullscreen) ? FormWindowState.Maximized : FormWindowState.Normal;
                });
            }
            else
            {
                form.TopMost = fullscreen;
                form.FormBorderStyle = (fullscreen) ? FormBorderStyle.None : FormBorderStyle.Sizable;
                form.WindowState = (fullscreen) ? FormWindowState.Maximized : FormWindowState.Normal;
            }
        }
    }
}
