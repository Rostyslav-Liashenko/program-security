using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        private ManagementObjectSearcher theSearcher;
        protected string serial = null;
        
        public Form1()
        {
            int count = 0;

            InitializeComponent();
            if (System.IO.File.Exists("id.pas"))
            {
                StreamReader read = new StreamReader(new FileStream("id.pas", FileMode.Open,
                    FileAccess.Read));
                try
                {
                    theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB' AND SerialNumber='"+ read.ReadLine()+"'");
                    foreach (ManagementObject currentObject in theSearcher.Get()) count++;
                    read.Close();

                    if (count != 0)
                    {
                        MessageBox.Show("Ваш цифровой пароль приняйтий!");
                    }
                    else
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
                catch (InvalidCastException e) {
                    read.Close();
                    Process.GetCurrentProcess().Kill();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                Process.GetCurrentProcess().Kill();
            }
            
            theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");

            foreach (ManagementObject currentObject in theSearcher.Get())
            {
                comboBox1.Items.Add(currentObject["DeviceID"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                Process.GetCurrentProcess().Kill();
            }
            
            button1.Enabled = true;
            
            foreach (ManagementObject currentObject in theSearcher.Get())
            {
                if (currentObject["DeviceID"].ToString() != comboBox1.Text) continue;
                
                ManagementObject theSerialNumberObjectQuery = new ManagementObject("Win32_PhysicalMedia.Tag='" + comboBox1.Text + "'");
                label8.Text = currentObject["Model"].ToString();
                label7.Text = currentObject["Description"].ToString();
                label6.Text = currentObject["SerialNumber"].ToString();
                label5.Text = Math.Round(((Convert.ToDouble(currentObject["Size"])) /
                                          1073741824), 1).ToString() + " Гб.";
                serial = currentObject["SerialNumber"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                Process.GetCurrentProcess().Kill();
            }
            
            StreamWriter write = new StreamWriter(new FileStream("id.pas", FileMode.Create,
                FileAccess.Write));
            write.Write(serial);
            write.Close();
            Process.GetCurrentProcess().Kill();
        }
    }
}