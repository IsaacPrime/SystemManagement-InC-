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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private SimpleTcpClient client;

       
        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txtStatus.Text += $"Server disconnected.{Environment.NewLine}";
            });

        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txtStatus.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });


        }
        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txtStatus.Text += $"Server connected.{Environment.NewLine}";
            });

        }

       
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormServer sr = new FormServer();
            sr.Show();
        }

        private void btnconnect2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnsend2.Enabled = true;
                btnconnect2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormClient_Load_1(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtip.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnsend2.Enabled = false;
        }

        private void btnsend2_Click_1(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtmsge.Text))
                {
                    client.Send(txtmsge.Text);
                    txtStatus.Text += $"Me:{txtmsge.Text}{Environment.NewLine}";
                    txtmsge.Text = string.Empty;
                }
            }
        }
    }
}
