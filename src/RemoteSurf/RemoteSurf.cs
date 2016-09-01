using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RemoteSurf
{
    public partial class RemoteSurf : Form
    {
        private AsyncSocket client = new AsyncSocket();
        private int currentDevice = 0;
        private int refreshRate = 100;

        public RemoteSurf()
        {
            InitializeComponent();
        }

        private async void Connect_Clicked(object sender, EventArgs e)
        {
            if (!client.connected)
            {
                client = new AsyncSocket();
                ConnectionStatus.Text = "Attempting To Connect";
                await client.Connect("127.0.0.1", 33666);
                EnableGroupBoxes(client.connected);
                if (client.connected)
                {
                    ConnectionStatus.Text = "Connected";
                    ConnectionStatus.ForeColor = Color.LimeGreen;
                    ConnectButton.Text = "Disconnect";
                    deviation_progress.Style = ProgressBarStyle.Blocks;
                    await client.SendAsync("<device_list />");
                    var uselessvariable1 = ReceiveDataAsync();
                    var uselessvariable2 = GetDeviceInfoAsync();
                }
                else
                {
                    ConnectionStatus.Text = "Failed to Connect";
                    ConnectionStatus.ForeColor = Color.IndianRed;
                    ConnectButton.Text = "Retry";
                    deviation_progress.Style = ProgressBarStyle.Marquee;
                }
            }
            else
            {
                client.Disconnect();
                ConnectButton.Text = "Connect";
                ConnectionStatus.Text = "Disconnected";
                ConnectionStatus.ForeColor = Color.Black;
                deviation_progress.Style = ProgressBarStyle.Marquee;
                EnableGroupBoxes(client.connected);
            }
        }

        private void EnableGroupBoxes(bool enabled)
        {
            MeasureGroup.Enabled = LiveReportGroup.Enabled = OrientationGroup.Enabled = CADViewGroup.Enabled = enabled;
        }

        private async void RefreshButton_Clicked(object sender, EventArgs e)
        {
            await client.SendAsync("<device_list />");
        }

        private async Task ReceiveDataAsync()
        {
            string data = string.Empty;
            while (client.connected)
            {
                try
                {
                    data = await client.ReadLineAsync();
                    ParseResponseAsync(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"RCV Data: {ex.GetType()}: {ex.Message}");
                }
            }
        }

        private async Task GetDeviceInfoAsync()
        {
            while (client.connected)
            {
                await Task.Delay(refreshRate);
                await client.SendAsync($"<device_info id=\"{ currentDevice }\" />");
            }
        }

        private void ParseResponseAsync(string xmlresponse)
        {
            // Check that we have a valid response and load it
            if (string.IsNullOrWhiteSpace(xmlresponse))
                return;
            //Console.WriteLine(xmlresponse);
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlresponse);

            // Check for errors
            XmlNode node = xml["response"].SelectSingleNode("error");
            if (node != null)
            {
                ErrorLabel.Text = $"Error: {node["code"].InnerText} - {node["name"].InnerText}";
                if(node["code"].InnerText == "404")
                    return;
            }
            else
                ErrorLabel.Text = "Error: ";

            // Use a switch case to call the corresponding functions
            string command = xml["response"]["command_received"].InnerText;
            switch(command)
            {
                case "device_list":
                    UpdateDeviceList(xml.SelectNodes("response/device_list/device"));
                    break;
                case "device_info":
                    UpdateDeviceInfo(xml.SelectSingleNode("response/device_info"));
                    break;
                default:
                    break;
            }
        }

        private void UpdateDeviceList(XmlNodeList devices)
        {
            ActiveDeviceCombo.Items.Clear();
            foreach (XmlNode device in devices)
            {
                if (device.Attributes["name"].Value != "")
                    ActiveDeviceCombo.Items.Add($"{device.Attributes["id"].Value} - {device.Attributes["name"].Value}");
            }
            ActiveDeviceCombo.SelectedIndex = 0;
        }

        private void UpdateDeviceInfo(XmlNode info)
        {
            if (info.Attributes["X"] == null)
            {
                nom_x.Text = nom_y.Text = nom_z.Text = dev_x.Text = dev_y.Text = dev_z.Text =  total_deviation.Text = "0.0000";
                return;
            }
            else
            {
                nom_x.Text = (float.Parse(info.Attributes["X"].Value)).ToString("F4");
                nom_y.Text = (float.Parse(info.Attributes["Y"].Value)).ToString("F4");
                nom_z.Text = (float.Parse(info.Attributes["Z"].Value)).ToString("F4");
            }

            if (info.Attributes["D3"] == null)
            {
                dev_x.Text = dev_y.Text = dev_z.Text = total_deviation.Text = "0.0000";
            }
            else
            {
                dev_x.Text = (float.Parse(info.Attributes["DX"].Value)).ToString("F4");
                dev_y.Text = (float.Parse(info.Attributes["DY"].Value)).ToString("F4");
                dev_z.Text = (float.Parse(info.Attributes["DZ"].Value)).ToString("F4");
                total_deviation.Text = (float.Parse(info.Attributes["D3"].Value)).ToString("F4");

                int clampedDeviation = (int)((float.Parse(info.Attributes["D3"].Value)) * 2000);
                clampedDeviation = ((clampedDeviation >= 500) ? 500 : ((clampedDeviation <= 0) ? 0 : clampedDeviation));
                deviation_progress.Value = 500 - clampedDeviation;
            }
            
        }

        private async void SendCommand_Clicked(object sender, EventArgs e)
        {
            if (!client.connected)
                return;

            await client.SendAsync($"<{CommandText.Text} />");
            CommandText.Text = string.Empty;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            deviation_progress.Style = ProgressBarStyle.Marquee;
            EnableGroupBoxes(client.connected);
        }

        private async void MeasureButton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = (string)btn.Tag;

            if (tag == "build")
                await client.SendAsync("<build />");
            if (tag == "measure")
                await client.SendAsync($"<measure_{btn.Text.ToLower()} />");
            if (tag == "cancel")
                await client.SendAsync("<measure_cancel />");
        }

        private async void CADViewButton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = (string)btn.Tag;
            string view = btn.Text;

            if (tag == "orientation")
                await client.SendAsync($"<CADView_{view} />");
            if (tag == "pan")
                await client.SendAsync($"<CADView_pan{view} />");
            if (tag == "zoom")
                await client.SendAsync($"<CADView_zoom{view} />");
        }
    }
}
