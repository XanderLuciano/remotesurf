using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace RemoteSurf
{
    public partial class RemoteSurfWebForm : Form
    {
        public RemoteSurfWebForm()
        {
            InitializeComponent();

            InitBrowser();
        }
        public bool fullscreen = false;
        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(@"file:///resources/html/index.html");
            //browser = new ChromiumWebBrowser(@"http://xanderluciano.com/remotesurf/");
            this.Controls.Add(browser);
            browser.BringToFront();
            browser.Dock = DockStyle.Fill;

            browser.RegisterJsObject("winform", new jsInteraction(this));
        }

        private void ToggleFullScreen(object sender, EventArgs e)
        {
            if (!fullscreen)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            fullscreen = !fullscreen;
        }

        private void OpenDevTools(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void Resized(object sender, EventArgs e)
        {
            Console.WriteLine(this.Size);
        }
    }
}
