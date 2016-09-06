using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RemoteSurf
{
    /// <summary>
    /// Async Wrapper for TCPclient to allow proper async usage.
    /// </summary>
    public class AsyncSocket
    {
        private TcpClient m_client;
        private NetworkStream m_stream;
        private StreamReader m_reader;

        /// <summary>
        /// TCPclient timeout in ms
        /// </summary>
        public int timeout = 5000;
        /// <summary>
        /// Are we currently connected to the Versisurf API server?
        /// </summary>
        public bool connected;

        /// <summary>
        /// Creates a new AsyncSocket and sets the timeout (default 5 seconds)
        /// </summary>
        public AsyncSocket()
        {
            m_client = new TcpClient();
            m_client.SendTimeout = timeout;
            m_client.ReceiveTimeout = timeout;
            connected = false;
        }

        /// <summary>
        /// Attempt to create a TCP socket connection
        /// </summary>
        /// <param name="hostIP">IP of the server</param>
        /// <param name="hostPort">Port server</param>
        /// <returns>true if connection was successful, false if connection failed</returns>
        public async Task<bool> Connect(string hostIP, int hostPort)
        {
            try
            {
                Console.WriteLine("Attempting to connect..");
                await m_client.ConnectAsync(hostIP, hostPort);
                m_stream = m_client.GetStream();
                m_reader = new StreamReader(m_stream);
                connected = true;
                Console.WriteLine("Connected!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed!");
                if (ex.GetType() != typeof(SocketException))
                {
                    Console.WriteLine($"Connect Clicked: {ex.GetType()}: {ex.Message}");
                }
                connected = false;
            }
            return connected;
        }

        /// <summary>
        /// Disconnect from the socket
        /// </summary>
        public void Disconnect()
        {
            m_client.Close();
            connected = false;
        }

        /// <summary>
        /// Send data to socket asynchronously
        /// </summary>
        /// <param name="data">string to send to socket</param>
        /// <returns>Task</returns>
        public async Task SendAsync(string data)
        {
            if (!connected)
                return;
            try
            {
                data += "\n";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                await m_stream.WriteAsync(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Reads a line from the active socket connection asynchronously.
        /// </summary>
        /// <returns>recieved data as string</returns>
        public async Task<string> ReadLineAsync()
        {
            byte[] data = new byte[2048];
            string message;
            CancellationTokenSource cts = new CancellationTokenSource(500);
            try
            {
                int bytes = await m_stream.ReadAsync(data, 0, data.Length, cts.Token);
                if (bytes > 0)
                    message = Encoding.ASCII.GetString(data, 0, bytes);
                else
                    message = string.Empty;

                return message;

                // I can use this after I get the latest version
                //return await m_reader.ReadLineAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ReadLineAsync: {ex.GetType()}: {ex.Message}");
                connected = false;
                if (ex.GetType() == typeof(IOException))
                    return ex.Message;
                else
                    return string.Empty;
            }
        }
    }
}
