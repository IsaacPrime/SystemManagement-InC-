using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace SystemManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        RegistryKey Regkey, RegKey2;
        Int32 rValue, rsvalue, Gvalue, tvalue;
        string Regpath = "System\\CurrentControlSet\\Services\\USBSTOR";

        private void Form2_Load(object sender, EventArgs e)
        {
            isAdmin = IsUserAnAdmin();
            if (isAdmin == false)
            {
                MessageBox.Show("You don't have proper privileges level to make changes, administrators privileges are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                Regkey = Registry.LocalMachine.OpenSubKey(Regpath, true);
                Gvalue = Convert.ToInt32(Regkey.GetValue("Start"));
              
                if (Gvalue == 3)
                {
                    radioButton1.Checked = true;
                }
                else if (Gvalue == 4)
                {
                    radioButton2.Checked = true;
                }
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, true);
                try
                {
                    tvalue = Convert.ToInt32(RegKey2.GetValue("WriteProtect"));
                    if (tvalue == 1)
                    {
                        radioButton4.Checked = true;
                    }
                    else if (tvalue == 0)
                    {
                        radioButton3.Checked = true;
                    }
                }
                catch (NullReferenceException) { }
            }

        }

        string ReadAndWriteRegPath2 = "System\\CurrentControlSet\\Control";
        string ReadAndWriteRegPath = "System\\CurrentControlSet\\Control\\StorageDevicePolicies";

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            rValue = 3;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            rValue = 4;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            rsvalue = 1;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            rsvalue = 0;
        }

        private void btnok_Click_1(object sender, EventArgs e)
        {
            Regkey = Registry.LocalMachine.OpenSubKey(Regpath, true);
            Regkey.SetValue("Start", rValue);
            if (groupBox1.Enabled == true)
            {
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath2, true);
                RegKey2.CreateSubKey("StorageDevicePolicies");
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, true);
                RegKey2.SetValue("WriteProtect", rsvalue);
            }
            if ((rValue == 3) && (rsvalue == 1))
            {
                MessageBox.Show("USB Port were enable and Read only is enabled");
            }
            else if ((rValue == 3) && (rsvalue == 0))
            {
                MessageBox.Show("USB Port were enable and Read and write is enabled");
            }
            else
            {
                MessageBox.Show("USB Port were disable");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 bk = new Form1();
            bk.Show();
            this.Hide();
        }
     
        bool isAdmin;
        [DllImport("shell32")]
        static extern bool IsUserAnAdmin();

    }

}

