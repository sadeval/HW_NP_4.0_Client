using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ComputerPartsClientGUI
{
    public partial class MainForm : Form
    {
        private UdpClient udpClient = new UdpClient();
        private IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5500);

        public MainForm()
        {
            InitializeComponent();
            SendRequestButton.Click += SendRequestButton_Click;
        }

        private void SendRequestButton_Click(object sender, EventArgs e)
        {
            string partName = textBoxRequest.Text;
            if (!string.IsNullOrEmpty(partName))
            {
                try
                {
                    SendRequest(partName);
                    string response = ReceiveResponse();
                    listBoxResponses.Items.Add($"Ответ от сервера: {response}");
                }
                catch (SocketException ex)
                {
                    MessageBox.Show($"Ошибка связи с сервером: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите название запчасти.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SendRequest(string request)
        {
            byte[] requestData = Encoding.UTF8.GetBytes(request);
            udpClient.Send(requestData, requestData.Length, serverEndPoint);
        }

        private string ReceiveResponse()
        {
            IPEndPoint remoteEndPoint = null;
            byte[] receivedData = udpClient.Receive(ref remoteEndPoint);
            return Encoding.UTF8.GetString(receivedData);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient.Close();
        }
    }
}
