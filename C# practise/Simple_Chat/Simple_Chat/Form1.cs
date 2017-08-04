using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Simple_Chat
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private EndPoint endPointLocal, endPointRemote;
        private byte[] buffer;

        public Form1()
        {
            InitializeComponent();

            // set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get userIP
            LocalIp.Text = GetLocalIp();
            RemoteIp.Text = GetLocalIp();

        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            // binding socket
            endPointLocal = new IPEndPoint(IPAddress.Parse(LocalIp.Text), Convert.ToInt32(LocalPort.Text));
            socket.Bind(endPointLocal);

            // Connecting to Remote
            endPointRemote = new IPEndPoint(IPAddress.Parse(RemoteIp.Text), Convert.ToInt32(RemotePort.Text));
            socket.Connect(endPointRemote);

            //Listening the specific port
            buffer = new byte[2000];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote,
                new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] recievedData = new byte[2000];
                recievedData = (byte[]) aResult.AsyncState;
                // Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string recievedMessage = aEncoding.GetString(recievedData);

                // Adding this message into Listbox
                MessageList.Items.Add("Friend : " + recievedMessage);

                buffer = new byte[2000];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote,
                    new AsyncCallback(MessageCallBack), buffer);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        private void Send_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert string to bye[]
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                byte[] sendingMessage = new byte[2000];
                sendingMessage = aEncoding.GetBytes(messageBox.Text);
                // sending message
                socket.Send(sendingMessage);
                // adding to listbox
                MessageList.Items.Add("Me: " + messageBox.Text);
                messageBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show((e.ToString()));
                throw;
            }
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }
    }
}
