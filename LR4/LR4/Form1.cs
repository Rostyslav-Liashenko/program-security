using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace LR4
{
    public partial class Form1 : Form
    {
        private string userName;
        private string computerName;
        private string pathOs;
        private string pathOsConfig;
        private int countButtonMouse;
        private double widthScreen;
        private string diskNames;
        private string selectedDiskVolume;
        
        public Form1()
        {
            InitializeComponent();
        }

        private string getDriveName()
        {
            string driverNames = "";
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                driverNames += d.Name + " ";
            }

            return driverNames;
        }

        private void initInfoAboutComputer()
        {
            userName = Environment.UserName;
            computerName = Environment.MachineName;
            pathOs = Environment.GetEnvironmentVariable("SystemRoot");
            pathOsConfig = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            countButtonMouse = SystemInformation.MouseButtons;
            widthScreen = SystemParameters.PrimaryScreenWidth;
            diskNames = getDriveName();
        }

        private void showInfoInForm()
        {
            label8.Text = userName;
            label7.Text = computerName;
            label6.Text = pathOs;
            label5.Text = pathOsConfig;
            label16.Text = countButtonMouse.ToString();
            label15.Text = widthScreen.ToString();
            label14.Text = diskNames;
            label13.Text = "Невідомо";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initInfoAboutComputer();
            showInfoInForm();
        }
    }
}