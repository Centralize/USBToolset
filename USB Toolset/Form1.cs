using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using DiskSpaceMon;
using System.Diagnostics;
using System.Security;

namespace USB_Toolset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        class RAMDisk
        {
            public const string MountPoint = "X:";

            public void createRamDisk()
            {
                try
                {
                    string initializeDisk = "imdisk -a ";
                    string imdiskSize = "-s 1024M";
                    string mountPoint = "-m " + MountPoint + " ";

                    ProcessStartInfo procStartInfo = new ProcessStartInfo();
                    procStartInfo.UseShellExecute = false;
                    procStartInfo.CreateNoWindow = true;
                    procStartInfo.FileName = "cmd";
                    procStartInfo.Arguments = "/C " + initializeDisk + imdiskSize + mountPoint;
                    Process.Start(procStartInfo);

                    formatRAMDisk();
                }
                catch (Exception objException)
                {
                    System.Windows.Forms.MessageBox.Show(Convert.ToString(objException));
                }
            }

            private void formatRAMDisk()
            {
                string cmdFormatHDD = "format " + MountPoint + "/Q /FS:FAT32";

                SecureString password = new SecureString();
                password.AppendChar('0');
                password.AppendChar('8');
                password.AppendChar('1');
                password.AppendChar('5');

                ProcessStartInfo formatRAMDiskProcess = new ProcessStartInfo();
                formatRAMDiskProcess.UseShellExecute = false;
                formatRAMDiskProcess.CreateNoWindow = true;
                formatRAMDiskProcess.RedirectStandardInput = true;
                formatRAMDiskProcess.FileName = "cmd";
                formatRAMDiskProcess.Verb = "runas";
                formatRAMDiskProcess.UserName = "Administrator";
                formatRAMDiskProcess.Password = password;
                formatRAMDiskProcess.Arguments = "/C " + cmdFormatHDD;
                Process process = Process.Start(formatRAMDiskProcess);

                sendCMDInput(process);
            }

            private void sendCMDInput(Process process)
            {
                StreamWriter inputWriter = process.StandardInput;
                inputWriter.WriteLine("J");
                inputWriter.Flush();
                inputWriter.WriteLine("RAMDisk for valueable data");
                inputWriter.Flush();
            }

            public string getMountPoint()
            {
                return MountPoint;
            }
        }

        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public void getUSBdrives()
        {
            string driveLabel = "";
            string driveSize = "";
            long convertDriveSize;
            decimal GB;
            ComboboxItem item = new ComboboxItem();
            DriveInfo[] removableDrives = DriveInfo.GetDrives();

            listBox1.Items.Clear();

            foreach (DriveInfo d in removableDrives)
            {
                if (d.DriveType == DriveType.Removable && d.IsReady)
                {
                    item.Text = d.Name;
                    if(item.Value != "")
                    {
                        item.Value = d.VolumeLabel;
                    }

                    driveSize = FormatBytes(d.TotalSize);

                    driveLabel = item.Text + " [ " + item.Value + " ] " + " - " + driveSize;
                    listBox1.Items.Add(driveLabel);
                    listBox1.SelectedIndex = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            getUSBdrives();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUSBdrives();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = listBox1.SelectedItem.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RAMDisk ramDisk = new RAMDisk();
            ramDisk.createRamDisk();
            
        }
    }
}
