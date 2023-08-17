using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiberTrade2
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private int sentPacketsCount;
        private int receivedPacketsCount;
        private bool listening;
        private UdpClient udpListener;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
            udpListener = new UdpClient();
            listening = false;
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

        private async Task StartListeningAsync(IPAddress listenIP, int listenPort)
        {
            using (UdpClient udpListener = new UdpClient(new IPEndPoint(listenIP, listenPort)))
            {
                while (listening)
                {
                    try
                    {
                        UdpReceiveResult receivedResult = await udpListener.ReceiveAsync();
                        byte[] receivedData = receivedResult.Buffer;
                        string receivedMessage = Encoding.ASCII.GetString(receivedData);
                        receivedMessageLabel.Text = receivedMessage;
                        receivedPacketsCount++;
                        receivedPacketsLabel.Text = $"Received Packets: {receivedPacketsCount}";
                    }
                    catch (SocketException ex)
                    {

                    }
                }
            }
        }

        private void StartListeningButton_Click(object sender, EventArgs e)
        {
            if (!listening)
            {
                if (IPAddress.TryParse(listenIPTextBox.Text, out IPAddress listenIP) && int.TryParse(listenPortTextBox.Text, out int listenPort))
                {
                    listening = true;
                    StartListeningButton.Text = "Stop Listening";

                    Task.Run(async () => await StartListeningAsync(listenIP, listenPort));
                }
                else
                {
                    MessageBox.Show("Invalid IP address or port.");
                }
            }
            else
            {
                listening = false;
                StartListeningButton.Text = "Start Listening";
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient.Close();
        }


    }
}
