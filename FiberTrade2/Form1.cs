using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace FiberTrade2
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private int sentPacketsCount;
        private int receivedPacketsCount;
        private int lostPacketsCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(destinationIPTextBox.Text, out IPAddress destinationIP) && int.TryParse(destinationPortTextBox.Text, out int destinationPort))
            {
                byte[] data = Encoding.ASCII.GetBytes(messageTextBox.Text);
                udpClient.Send(data, data.Length, new IPEndPoint(destinationIP, destinationPort));
                sentPacketsCount++;
                sentPacketsLabel.Text = $"Sent Packets: {sentPacketsCount}";
            }
            else
            {
                MessageBox.Show("Invalid IP address or port.");
            }
        }

        private void StartListeningButton_Click(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(listenIPTextBox.Text, out IPAddress listenIP) && int.TryParse(listenPortTextBox.Text, out int listenPort))
            {
                UdpClient listener = new UdpClient(listenPort);
                IPEndPoint endPoint = new IPEndPoint(listenIP, listenPort);

                try
                {
                    while (true)
                    {
                        byte[] receivedData = listener.Receive(ref endPoint);
                        string receivedMessage = Encoding.ASCII.GetString(receivedData);
                        receivedPacketsCount++;
                        receivedPacketsLabel.Text = $"Received Packets: {receivedPacketsCount}";
                    }
                }
                catch (SocketException ex)
                {
                    // SocketException will occur when the listener is closed
                    listener.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid IP address or port.");
            }
        }

        private void StopListeningButton_Click(object sender, EventArgs e)
        {
            // Closing the listener will break out of the Receive loop
            udpClient.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient.Close();
        }


    }
}
