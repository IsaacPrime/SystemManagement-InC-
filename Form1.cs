using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;
using System.Security;
using System.IO.Ports;
using Microsoft.Win32;

namespace SystemManagement
{
    public partial class Form1 : Form
    {

        [DllImport("user32")]
        public static extern void LockWorkStation();
        public Form1()
        {
            InitializeComponent();
            getdrives();
        }
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(GraphicsUnit uFlags, uint DwReason);

        //no panel activities is displayed during form load
        private void Form1_Load(object sender, EventArgs e)
        {
            Processespanel.Visible = false;
            Devicepanel.Visible = false;
            IOpanel.Visible = false;
            panelname.Visible = false;
        }

        //Enables when the process button is clicked to display a process panel that has different Process Activities
        private void btnProcess_Click(object sender, EventArgs e)
        {
            Processespanel.Visible = true;
            Filepanel.Visible = false;
            IOpanel.Visible = false;
            panelname.Visible = false;
            Devicepanel.Visible = false;
        }

        //Terminates the application from running 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Gives options for exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
             
            const string message = "Would you Wish To Close This Application";
            const string caption = "Application Closing";
            var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Enables the form to be dragable by amouse i.e the form can be moved to any location on the screen
        Point lastPoint;
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //Starts Processes Provided in the comboBox
        private void btnStartP_Click(object sender, EventArgs e)
        {
            string text = comboBox1.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
            clear();
            
        }

        //terminates running processes in the comboBox
        private void btnTerminate_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName(comboBox2.Text))
            {
                process.Kill();
               
            }
            clear();
        }

        //Starts processes available in the combobox once clicked
        private void btnList_Click(object sender, EventArgs e)
        {
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                listBox1.Items.Add(proc.ProcessName);
            }
        }

        //Displays properties of running processes i.e process id, start time, stoptime
        private void btnprop_Click(object sender, EventArgs e)
        {
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                if (listBox1.SelectedItem.ToString() == proc.ProcessName)
                {
                    string temp = string.Empty;
                    temp += "Process ID: " + proc.Id.ToString();
                    temp += "\nProcessor Time: " + proc.UserProcessorTime.ToString();
                    temp += "\nProcess Start Time: " + proc.StartTime.ToString();
                    MessageBox.Show(temp);
                    break;
                }
            }
        }

        //Displays the File attributes panel
        private void btnFile_Click(object sender, EventArgs e)
        {
            Filepanel.Visible = true;
            Processespanel.Visible = true;
            Devicepanel.Visible = false;
            IOpanel.Visible = false;
            panelname.Visible = false;
        }

        //dispays names of items and folders in a drive together with their paths
        private void btnBrowseF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                foreach (string file in files)
                {
                    listBox2.Items.Add((file));
                }
                foreach (string dir in dirs)
                {
                    listBox2.Items.Add((dir));
                }
            }
        }

        //Creates a text file
        string Path = Environment.CurrentDirectory + "/" + "CSharp.txt";
        private void btnCreateF_Click(object sender, EventArgs e)
        {

            if (!File.Exists(Path))
            {
                File.CreateText(Path);
                MessageBox.Show("File Created successfully");
            }
        }
        //Opens a text file in the textbox
        private void btnOpenF_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog di = new OpenFileDialog();
            if (di.ShowDialog() == DialogResult.OK)
            {
                if ((st = di.OpenFile()) != null)
                {
                    string file = di.FileName;
                    string str = File.ReadAllText(file);
                    richTextBox1.Text = str;
                }
            }
        }

        //Writes data in the above created file
        private void btnWriteF_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine("I-Connect computer solutions and graphics design");
            }
        }

        //Dispays data written in the file inside a textbox
        private void btnReadF_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                string text = sr.ReadLine();
                richTextBox1.Text = text;
            }
        }

        //Deletes information in the file created above
        private void btnDelF_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
                MessageBox.Show("Delete File");
            }
        }

        //Shuts down the computer
        private void ShutDbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        //Restarts the computer
        private void Restartbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 0");
        }

        //Makes the computer go to sleep
        private void Sleepbtn_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        //Togs out the user and prompts for a new a sign in 
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }

        private void getdrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string item in drives)
            {
                comboBox3.Items.Add(item.ToString());

            }
        }

        //Displays storage information of the selected drive
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ginfo = comboBox3.SelectedItem.ToString();
            DriveInfo dr = new DriveInfo(ginfo);
            string Available_space = dr.AvailableFreeSpace / 1073741824 + "GB".ToString();
            string Totalspace = dr.TotalSize / 1073741824 + "GB".ToString(); ;
            string drivety = dr.DriveType.ToString();
            MessageBox.Show("Available space= " + Available_space + "\n Total space= " + Totalspace + "\n Drivetype= " + drivety);

        }
        //Fetches information about the host machiene
        private void Getinfobtn_Click(object sender, EventArgs e)
        {
            //Displays Machine Name
            string m1 = Environment.MachineName;
            txtCName.Text = m1;

            //Displays user name
            string m2 = Environment.UserName;
            txtUser.Text = Convert.ToString(m2);

            //Displays OS version
            string m3 = (Environment.OSVersion.ToString());
            txtVersion.Text = m3;

            //Displays OS type
            string m4 = Environment.OSVersion.Version.ToString();
            txtOS.Text = m4;

            //Displays systems platform
            string m5 = Environment.OSVersion.Platform.ToString();
            txtOSplatform.Text = m5;

            //Displays number of processors
            int m6 = Environment.ProcessorCount;
            txtProCounter.Text = Convert.ToString(m6);

            //Displays whether the OS is a 64bit 
            bool m7 = Environment.Is64BitOperatingSystem;
            txt64bitOS.Text = Convert.ToString(m7);

            //Displays whether the processors are 64bit
            bool m8 = Environment.Is64BitProcess;
            txt64bitProcessor.Text = Convert.ToString(m8);
        }

        //Clears all textboxes and comboboxes 
        public void clear()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            txt64bitOS.Text = "";
            txt64bitProcessor.Text = "";
            txtCName.Text = "";
            txtOS.Text = "";
            txtOSplatform.Text = "";
            txtProCounter.Text = "";
            txtUser.Text = "";
            txtVersion.Text = "";
            comboBox3.Text = "";
            txtName.Text = "";
            txtDformat.Text = "";
            txtDtype.Text = "";
            txtIready.Text = "";
            txtTspace.Text = "";
            txtFspace.Text = "";
        }

        //Displays the Device management panel when clicked
        private void btnDevice_Click(object sender, EventArgs e)
        {
            Devicepanel.Visible = true;
            Filepanel.Visible = true;
            Processespanel.Visible = true;
            IOpanel.Visible = false;
            panelname.Visible = false;
        }

        //Clears content displayed in this Device management panel
        private void clearDMbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        //Displays the Input/Output panel when clicked
        private void btnIO_Click(object sender, EventArgs e)
        {
            IOpanel.Visible = true;
            Devicepanel.Visible = true;
            Filepanel.Visible = true;
            Processespanel.Visible = true;
            panelname.Visible = false;
        }

        //Gets and displays information about a usb drive plugged in
        private void btnget_Click(object sender, EventArgs e)
        {
            
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                txtName.Text = drives.FirstOrDefault().Name.ToString();
                txtDformat.Text = drives.FirstOrDefault().DriveFormat.ToString();
                txtDtype.Text = drives.FirstOrDefault().DriveType.ToString();
                txtIready.Text = drives.FirstOrDefault().IsReady.ToString();
                txtTspace.Text = drives.FirstOrDefault().TotalSize / 1073741824 + "GB".ToString();
                txtFspace.Text = drives.FirstOrDefault().TotalFreeSpace / 1073741824 + "GB".ToString();
            }
            else
            {
                MessageBox.Show("No Pendrive Connected...");
            }

        }

        //Displays list of usb ports
        private void btncheck_Click(object sender, EventArgs e)
        {
            ManagementObjectCollection collection;
            using (var finddevice = new ManagementObjectSearcher(@"select * from win32_USBHub"))
                collection = finddevice.Get();
            foreach (var device in collection)
            {
                checkedListBox1.Items.Add(device.GetPropertyValue("DeviceID"));
                checkedListBox1.Items.Add(device.GetPropertyValue("Description"));
            }
        }

        //Opens the usb control panel
        private void btnUSB_Click(object sender, EventArgs e)
        {

            Form2 sb = new Form2();
            sb.Show();
            this.Hide();
        }
        
        //Opens client form
        private void btnComms_Click(object sender, EventArgs e)
        {
            FormClient fc = new FormClient();
            fc.Show();
            this.Hide();
        }

        //Opens my name and registration number
        private void About_Click(object sender, EventArgs e)
        {
            panelname.Visible = true;
            IOpanel.Visible = true;
            Devicepanel.Visible = true;
            Filepanel.Visible = true;
            Processespanel.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IOpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
