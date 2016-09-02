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

/// <summary>
/// A WinForms example program to show how to use the Verisurf API with an async C# client.
/// </summary>
namespace RemoteSurf
{
    /// <summary>
    /// WinForm events and code
    /// </summary>
    public partial class RemoteSurf : Form
    {
        private AsyncSocket client = new AsyncSocket();
        private int currentDevice = 0;
        private int refreshRate = 100;

        /// <summary>
        /// Initialization
        /// </summary>
        public RemoteSurf()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the default states for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            deviation_progress.Style = ProgressBarStyle.Marquee;
            EnableGroupBoxes(client.connected);
        }

        /// <summary>
        /// Attempt to connect to Verisurf
        /// </summary>
        /// <remarks>
        /// <para>Connects over localhost to default port API port. Updates labels and Text.</para>
        /// <para>Creates 2 async loops to handle the socket connection</para>
        /// <para>The first loop awaits incoming data from the Verisurf API server</para>
        /// <para>The second loop sends device_info requests at the current refresh rate</para>
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    await client.SendAsync("<device_list />");
                    var rcvdata = ReceiveDataAsync();
                    var getdevinfo = GetDeviceInfoAsync();
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

        /// <summary>
        /// Function to quickly enable/disable all relevent group boxes.
        /// </summary>
        /// <param name="enabled">Enabled group boxes?</param>
        private void EnableGroupBoxes(bool enabled)
        {
            MeasureGroup.Enabled = LiveReportGroup.Enabled = OrientationGroup.Enabled = CADViewGroup.Enabled = enabled;
        }

        /// <summary>
        /// Request an updated device list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RefreshButton_Clicked(object sender, EventArgs e)
        {
            await client.SendAsync("<device_list />");
        }

        /// <summary>
        /// Async task loop to continuously read socket data and pass it to our parsing function.
        /// </summary>
        /// <returns>Task</returns>
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

        /// <summary>
        /// Async task loop to request device info at the current refresh rate.
        /// </summary>
        /// <returns>Task</returns>
        private async Task GetDeviceInfoAsync()
        {
            while (client.connected)
            {
                await Task.Delay(refreshRate);
                await client.SendAsync($"<device_info id=\"{ currentDevice }\" />");
            }
        }

        /// <summary>
        /// Parse the XML response from the Verisurf API server.
        /// </summary>
        /// <remarks>
        /// Properly intercepts errors,
        /// Sends filtered XML data to UI Updating functions
        /// </remarks>
        /// <param name="xmlresponse">Verisurf API response</param>
        private void ParseResponseAsync(string xmlresponse)
        {
            // Check that we have a valid response and load it
            if (string.IsNullOrWhiteSpace(xmlresponse))
                return;
            
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlresponse);

            // Check for errors
            XmlNode node = xml["response"].SelectSingleNode("error");
            if (node != null)
            {
                ErrorLabel.Text = $"Error: { node["code"].InnerText } - { node["name"].InnerText }";
                return;
            }

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
            if (command != "device_info")
                ErrorLabel.Text = "Error: ";
        }

        /// <summary>
        /// Updates Active Device UI combo box
        /// </summary>
        /// <param name="devices">Verisurf API response with filtered available devices XML string</param>
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

        /// <summary>
        /// Updates All UI elements that report device info.
        /// </summary>
        /// <param name="info">Verisurf API response with filtered device info XML string</param>
        private void UpdateDeviceInfo(XmlNode info)
        {
            // If we didn't receive an X position we didn't receive anything else so return early.
            if (info.Attributes["X"] == null)
            {
                nom_x.Text = nom_y.Text = nom_z.Text = dev_x.Text = dev_y.Text = dev_z.Text =  total_deviation.Text = "0.0000";
                deviation_progress.Style = ProgressBarStyle.Marquee;
                return;
            }
            else
            {
                nom_x.Text = (float.Parse(info.Attributes["X"].Value)).ToString("F4");
                nom_y.Text = (float.Parse(info.Attributes["Y"].Value)).ToString("F4");
                nom_z.Text = (float.Parse(info.Attributes["Z"].Value)).ToString("F4");
            }

            // Check if we have 3D deviation data, return early if null.
            if (info.Attributes["D3"] == null)
            {
                dev_x.Text = dev_y.Text = dev_z.Text = total_deviation.Text = "0.0000";
                deviation_progress.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                deviation_progress.Style = ProgressBarStyle.Continuous;

                dev_x.Text = (float.Parse(info.Attributes["DX"].Value)).ToString("F4");
                dev_y.Text = (float.Parse(info.Attributes["DY"].Value)).ToString("F4");
                dev_z.Text = (float.Parse(info.Attributes["DZ"].Value)).ToString("F4");
                total_deviation.Text = (float.Parse(info.Attributes["D3"].Value)).ToString("F4");

                // Progress bar indicating 3D deviation
                int clampedDeviation = (int)((float.Parse(info.Attributes["D3"].Value)) * 2000);
                clampedDeviation = ((clampedDeviation >= 500) ? 500 : ((clampedDeviation <= 0) ? 0 : clampedDeviation));
                // This 'hack' makes the progress bar instantly update
                deviation_progress.Value = 500 - clampedDeviation;
                deviation_progress.Value -= 1;
            }
            
        }

        /// <summary>
        /// Send user command to Verisurf API server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SendCommand_Clicked(object sender, EventArgs e)
        {
            if (!client.connected)
                return;

            await client.SendAsync($"<{CommandText.Text} />");
            CommandText.Text = string.Empty;
        }

        /// <summary>
        /// Send the corresponding measure command the the Verisurf API server
        /// </summary>
        /// <param name="sender">Measure Button Pressed</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Send the corresponding CADView command to the Verisurf API server
        /// </summary>
        /// <param name="sender">CADView Button Pressed</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Changes the active device ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveDevice_Changed(object sender, EventArgs e)
        {
            currentDevice = ActiveDeviceCombo.SelectedIndex;
        }

        /// <summary>
        /// Changes the device info refresh rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshRate_Changed(object sender, EventArgs e)
        {
            refreshRate = (int)RefreshRateNum.Value;
        }
    }
}
