using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace SystemManagement
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
      

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                lstClientIP.Items.Remove(e.IpPort);
            });
        }
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                lstClientIP.Items.Add(e.IpPort);
            });
        }


        private void btnstart1_Click_1(object sender, EventArgs e)
        {
            server.Start();
            txtStatus.Text += $"Starting....{Environment.NewLine}";
            btnstart1.Enabled = false;
            btnsend2.Enabled = true;
        }

        private void btnsend2_Click_1(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtmsge.Text) && lstClientIP.SelectedItem != null)
                {
                    server.Send(lstClientIP.SelectedItem.ToString(), txtmsge.Text);
                    txtStatus.Text += $"Server: {txtmsge.Text}{Environment.NewLine}";
                    txtmsge.Text = string.Empty;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormClient cl = new FormClient();
            cl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.Show();
            this.Hide();
        }

        private void FormServer_Load_1(object sender, EventArgs e)
        {
            btnsend2.Enabled = false;
            server = new SimpleTcpServer(txtip.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }
    }
}
