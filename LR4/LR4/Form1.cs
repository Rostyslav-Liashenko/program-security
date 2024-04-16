using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Microsoft.Win32;
using MessageBox = System.Windows.MessageBox;

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
        private string selectedDiskPath;
        
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

        private byte[] getHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        
        private string getHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in getHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private string getHashAboutComputer()
        {
            string stringForHash = userName + computerName + pathOs + pathOsConfig + countButtonMouse + widthScreen +
                                   diskNames;
            return getHashString(stringForHash);
        }

        private void writeInRegister(string keyForValue, string value)
        {
            string keyPath = @"Software";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
                {
                    key.SetValue(keyForValue, value);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Помилка при записі в реєстр");
            }
        }

        private void writeHashInRegister()
        {
            string StudentLastName = "Liashenko";
            string hash = getHashAboutComputer();
            writeInRegister(StudentLastName, hash);
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